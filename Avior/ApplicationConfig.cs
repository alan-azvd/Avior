using System;
using Bridge;
using Bridge.Html5;
using Avior.Components;

namespace Avior
{
    public class ApplicationConfig
    {
        public Page FirstPage { get; set; }

        protected String ApplicationTitle { get; set; }
        protected String[] Stylesheets { get; set; } = new[] { "" };
        protected String[] Scripts { get; set; } = new[] { "" };
        protected String ApplicationTheme { get; set; }
        protected String LoaderText { get; set; }

        public void Configure()
        {
            Document.Title = ApplicationTitle;

            loadAssets();

            Document.Body.ClassName = ApplicationTheme;
            Document.Body.AppendChild(new PageLoader().Text(LoaderText).Render());
            Document.Body.AppendChild(new Overlay().Render());
        }

        private void loadAssets()
        {
            foreach (var url in Stylesheets)
                addStylesheetCss(url);

            foreach (var url in Scripts)
                addScripts(url);
        }

        private void addStylesheetCss(String url)
        {
            var link = Document.CreateElement("link");
            link.SetAttribute("type", "text/css");
            link.SetAttribute("rel", "stylesheet");
            link.SetAttribute("href", url);
            Document.Head.AppendChild(link);
        }

        private void addScripts(String url)
        {
            var script = Document.CreateElement("script");
            script.SetAttribute("src", url);
            Document.Head.AppendChild(script);
        }
    }
}
