using System;
using Bridge;
using Bridge.Html5;

namespace Avior.Components
{
    public class TopBar : Component<TopBar>
    {
        public String Title { get; set; }

        public TopBar() : base(new HTMLNavElement())
        {
            AddClass("navbar");
        }

        public override HTMLElement Render()
        {
            Add(new TopBarHeader(Title));
            return Content;
        }
    }

    public static class TopBarFluent
    {
        public static TopBar Title(this TopBar topBar, String title)
        {
            topBar.Title = title;
            return topBar;
        }
    }

    public class TopBarHeader : Component<TopBar>
    {
        private String headerText;

        public TopBarHeader(string headerText) : base(new HTMLNavElement())
        {
            this.headerText = headerText;
            AddClass("navbar-header");
        }

        public override HTMLElement Render()
        {
            Add(Link().Href("javascript:void(0);").AddClass("navbar-toggle collapsed").DataTarget("collapse").DataTarget("#navbar-collapse").AriaExpanded(true));
            Add(Link().Href("javascript:void(0);").AddClass("bars"));
            Add(Link().Href("javascript:void(0);").AddClass("navbar-brand").Text(headerText));
            return Content;
        }
    }
}
