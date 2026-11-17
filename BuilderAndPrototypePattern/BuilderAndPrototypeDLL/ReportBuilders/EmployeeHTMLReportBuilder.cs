using BuilderAndPrototypeDLL.Metrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndPrototypeDLL.ReportBuilders
{
    public class EmployeeHTMLReportBuilder : AReportBuilder
    {
        public EmployeeHTMLReportBuilder() : base()
        {
            metrics = new List<VMetric>
            {
                new Employee("Олександр Коваленко", 35000, 5000),
                new Employee("Марія Шевченко", 42000, 8000),
                new Employee("Дмитро Бондаренко", 28000, 3500),
                new Employee("Анна Мельник", 50000, 10000),
                new Employee("Ігор Ткаченко", 31000, 2000)
            };
        }

        public override void BuildConclusions()
        {
            var employees = metrics?.OfType<Employee>().ToList();

            if (employees == null || employees.Count == 0)
            {
                _htmlReport.Conclusions = "<p>Недостатньо даних для формування висновків.</p>";
                return;
            }

            int totalCount = employees.Count;
            int totalPayroll = employees.Sum(e => e.TotalCompensation);
            double averageCompensation = employees.Average(e => e.TotalCompensation);
            var topEmployee = employees.OrderByDescending(e => e.TotalCompensation).First();

            var sb = new StringBuilder();
            sb.AppendLine("<ul>");
            sb.AppendLine($"  <li><strong>Загальна кількість працівників:</strong> {totalCount}</li>");
            sb.AppendLine($"  <li><strong>Загальний фонд оплати праці (із бонусами):</strong> {totalPayroll} грн</li>");
            sb.AppendLine($"  <li><strong>Середня загальна компенсація:</strong> {averageCompensation:F2} грн</li>");
            sb.AppendLine($"  <li><strong>Найвища компенсація:</strong> {topEmployee.Name} ({topEmployee.TotalCompensation} грн)</li>");
            sb.AppendLine("</ul>");

            _htmlReport.Conclusions = sb.ToString();
        }

        public override void BuildMainBody()
        {
            if (metrics == null || metrics.Count == 0)
            {
                _htmlReport.MainBody = "<p>Дані відсутні.</p>";
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine("<table border=\"1\" style=\"border-collapse: collapse; width: 100%; text-align: left;\">");

            var properties = metrics.First().GetType().GetProperties();

            sb.AppendLine("  <thead>");
            sb.AppendLine("    <tr style=\"background-color: #f2f2f2;\">");
            foreach (var prop in properties)
            {
                sb.AppendLine($"      <th style=\"padding: 8px;\">{prop.Name}</th>");
            }
            sb.AppendLine("    </tr>");
            sb.AppendLine("  </thead>");

            sb.AppendLine("  <tbody>");
            foreach (var metric in metrics)
            {
                sb.AppendLine("    <tr>");
                foreach (var prop in properties)
                {
                    var value = prop.GetValue(metric) ?? "";
                    sb.AppendLine($"      <td style=\"padding: 8px;\">{value}</td>");
                }
                sb.AppendLine("    </tr>");
            }
            sb.AppendLine("  </tbody>");

            sb.AppendLine("</table>");

            _htmlReport.MainBody = sb.ToString();
        }
    }
}