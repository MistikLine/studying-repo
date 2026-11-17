using BuilderAndPrototypeDLL.Metrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderAndPrototypeDLL.ReportBuilders
{
    public class TaskHTMLReportBuilder : AReportBuilder
    {
        public TaskHTMLReportBuilder() : base()
        {
            metrics = new List<VMetric>
            {
                new Task("Розробка архітектури БД", "Олександр Коваленко", true),
                new Task("Верстка головної сторінки", "Марія Шевченко", true),
                new Task("Налаштування CI/CD", "Дмитро Бондаренко", false),
                new Task("Інтеграція платіжного шлюзу", "Анна Мельник", true),
                new Task("Написання unit-тестів", "Ігор Ткаченко", false)
            };
        }

        public override void BuildMainBody()
        {
            var tasks = metrics?.OfType<Task>().ToList();

            if (tasks == null || tasks.Count == 0)
            {
                _htmlReport.MainBody = "<p>Список завдань порожній.</p>";
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine("<div style=\"display: flex; flex-direction: column; gap: 10px;\">");

            foreach (var task in tasks)
            {
                string statusText = task.IsCompleted ? "✅ Виконано" : "⏳ В процесі";
                string borderColor = task.IsCompleted ? "#4CAF50" : "#FF9800";
                string bgColor = task.IsCompleted ? "#f4fbf4" : "#fffaf2";

                sb.AppendLine($"  <div style=\"border-left: 5px solid {borderColor}; background-color: {bgColor}; padding: 12px 16px; border-radius: 4px;\">");
                sb.AppendLine($"    <h3 style=\"margin: 0 0 6px 0;\">{task.Name}</h3>");
                sb.AppendLine($"    <p style=\"margin: 0; color: #555;\"><strong>Виконавець:</strong> {task.EmployeeName} | <strong>Статус:</strong> {statusText}</p>");
                sb.AppendLine("  </div>");
            }

            sb.AppendLine("</div>");

            _htmlReport.MainBody = sb.ToString();
        }

        public override void BuildConclusions()
        {
            var tasks = metrics?.OfType<Task>().ToList();

            if (tasks == null || tasks.Count == 0)
            {
                _htmlReport.Conclusions = "<p>Недостатньо даних для підбиття підсумків за завданнями.</p>";
                return;
            }

            int totalTasks = tasks.Count;
            int completedTasks = tasks.Count(t => t.IsCompleted);
            int pendingTasks = totalTasks - completedTasks;
            double completionRate = (double)completedTasks / totalTasks * 100;

            var topPerformer = tasks
                .Where(t => t.IsCompleted)
                .GroupBy(t => t.EmployeeName)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            var sb = new StringBuilder();
            sb.AppendLine("<ul>");
            sb.AppendLine($"  <li><strong>Всього завдань:</strong> {totalTasks}</li>");
            sb.AppendLine($"  <li><strong>Виконано:</strong> {completedTasks} ({completionRate:F1}%)</li>");
            sb.AppendLine($"  <li><strong>Залишилось у роботі:</strong> {pendingTasks}</li>");

            if (topPerformer != null)
            {
                sb.AppendLine($"  <li><strong>Найпродуктивніший виконавець:</strong> {topPerformer.Key} (виконано завдань: {topPerformer.Count()})</li>");
            }

            sb.AppendLine("</ul>");

            _htmlReport.Conclusions = sb.ToString();
        }
    }
}