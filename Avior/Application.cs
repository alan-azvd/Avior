using System;
using Bridge;
using Bridge.Html5;

namespace Avior
{
    public class Application
    {
        private ApplicationConfig configuration;

        public Application(ApplicationConfig configuration)
        {
            this.configuration = configuration;
        }

        public void Run()
        {
            configuration.Configure();

            ThemeConfig.browserConfig();

            configuration.FirstPage.PreRender();
            Document.Body.AppendChild(configuration.FirstPage.Render());
            configuration.FirstPage.PosRender();
        }
    }

    [External]
    static class ThemeConfig
    {
        [Template("$.AdminBSB.browser.activate()")]
        public static void browserConfig()
        {

        }

        [Template("$.AdminBSB.navbar.activate()")]
        public static void navbarConfig()
        {

        }

        [Template("$.AdminBSB.leftSideBar.activate()")]
        public static void leftSideBarConfig()
        {

        }
    }
}
