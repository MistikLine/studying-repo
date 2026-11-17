using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BuilderAndPrototypeDLL
{
    public class HTMLReport
    {
        public string CoverPage { get; set; }
        public string Introduction { get; set; }
        public string MainBody { get; set; }
        public string Conclusions { get; set; }
        public string References { get; set; }


        public void Export(string filePath = "report.html")
        {
            var sb = new StringBuilder();

            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html lang=\"uk\">");
            sb.AppendLine("<head>");
            sb.AppendLine("    <meta charset=\"UTF-8\">");
            sb.AppendLine("    <title>HTML Report</title>");
            sb.AppendLine("    <style>");
            sb.AppendLine("        body { font-family: Arial, sans-serif; line-height: 1.6; max-width: 800px; margin: 40px auto; padding: 0 20px; }");
            sb.AppendLine("        section { margin-bottom: 30px; }");
            sb.AppendLine("        .cover { text-align: center; padding: 50px 0; border-bottom: 2px solid #333; }");
            sb.AppendLine("    </style>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");

            if (!string.IsNullOrWhiteSpace(CoverPage))
                sb.AppendLine($"    <section class=\"cover\">{CoverPage}</section>");

            if (!string.IsNullOrWhiteSpace(Introduction))
                sb.AppendLine($"    <section><h2>Вступ</h2><p>{Introduction}</p></section>");

            if (!string.IsNullOrWhiteSpace(MainBody))
                sb.AppendLine($"    <section><h2>Основна частина</h2><div>{MainBody}</div></section>");

            if (!string.IsNullOrWhiteSpace(Conclusions))
                sb.AppendLine($"    <section><h2>Висновки</h2><p>{Conclusions}</p></section>");

            if (!string.IsNullOrWhiteSpace(References))
                sb.AppendLine($"    <section><h2>Список використаних джерел</h2><div>{References}</div></section>");

            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }

        public string GetHTMLContent()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html lang=\"uk\">");
            sb.AppendLine("<head>");
            sb.AppendLine("    <meta charset=\"UTF-8\">");
            sb.AppendLine("    <title>HTML Report</title>");
            sb.AppendLine("    <style>");
            sb.AppendLine("        body { font-family: Arial, sans-serif; line-height: 1.6; max-width: 800px; margin: 40px auto; padding: 0 20px; }");
            sb.AppendLine("        section { margin-bottom: 30px; }");
            sb.AppendLine("        .cover { text-align: center; padding: 50px 0; border-bottom: 2px solid #333; }");
            sb.AppendLine("    </style>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");
            if (!string.IsNullOrWhiteSpace(CoverPage))
                sb.AppendLine($"    <section class=\"cover\">{CoverPage}</section>");
            if (!string.IsNullOrWhiteSpace(Introduction))
                sb.AppendLine($"    <section><h2>Вступ</h2><p>{Introduction}</p></section>");
            if (!string.IsNullOrWhiteSpace(MainBody))
                sb.AppendLine($"    <section><h2>Основна частина</h2><div>{MainBody}</div></section>");
            if (!string.IsNullOrWhiteSpace(Conclusions))
                sb.AppendLine($"    <section><h2>Висновки</h2><p>{Conclusions}</p></section>");
            if (!string.IsNullOrWhiteSpace(References))
                sb.AppendLine($"    <section><h2>Список використаних джерел</h2><div>{References}</div></section>");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");
            return sb.ToString();
        }

        public HTMLReport clone()
        {
            return new HTMLReport
            {
                CoverPage = this.CoverPage,
                Introduction = this.Introduction,
                MainBody = this.MainBody,
                Conclusions = this.Conclusions,
                References = this.References
            };
        }
    }
}
