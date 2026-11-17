using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndPrototypeDLL
{
    public abstract class AReportBuilder
    {
        protected HTMLReport _htmlReport;
        protected List<VMetric> metrics;

        public AReportBuilder()
        {
            _htmlReport = new HTMLReport();
        }

        public void BuildCoverPage()
        {
            _htmlReport.CoverPage = $"<h1>Аналітичний звіт</h1><p>Дата формування: {DateTime.Now:dd.MM.yyyy}</p>";
        }

        public void BuildIntroduction()
        {
            _htmlReport.Introduction = "<p>Цей звіт містить аналіз основних показників ефективності на основі зібраних метрик.</p>";
        }

        public abstract void BuildMainBody();
        public abstract void BuildConclusions();

        public void BuildReferences()
        {
            _htmlReport.References = "<ul><li>Внутрішня база даних обліку показників</li><li>Корпоративна звітність</li></ul>";
        }

        public HTMLReport GetHTMLReport()
        {
            return _htmlReport;
        }
    }
}