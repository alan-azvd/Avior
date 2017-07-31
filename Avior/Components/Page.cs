using Bridge;
using Bridge.Html5;
using Newtonsoft.Json;
using System;

namespace Avior.Components
{
    public class Page : Component<Page>
    {
        public Page() : base(new PageElement()) { }

        public override HTMLElement Render()
        {
            return Content;
        }

        public override void PosRender()
        {
            ThemeConfig.navbarConfig();
            ThemeConfig.leftSideBarConfig();
        }

        protected TopBar TopBar()
        {
            return new TopBar();
        }

        protected LeftSideBar LeftSideBar()
        {
            return new LeftSideBar();
        }
    }
}
