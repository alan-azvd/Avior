using Bridge;
using Bridge.Html5;
using Newtonsoft.Json;
using System;
using Bridge.jQuery2;

namespace Avior.Components
{
    public abstract class SideBar<T> : Component<SideBar<T>> where T : SideBar<T>
    {
        private SideBarType type;

        public SideBar(SideBarType type) : base(new HTMLASideElement())
        {
            this.type = type;
        }

        public override HTMLElement Render()
        {
            if (type.Equals(SideBarType.Left))
                AddClass("sidebar");
            else if (type.Equals(SideBarType.Right))
                AddClass("right-sidebar");

            return Content;
        }
    }

    public class LeftSideBar : SideBar<LeftSideBar>
    {
        public LeftSideBar() : base(SideBarType.Left)
        {
            //var body = jQuery.Select("body");
            //var overlay = jQuery.Select(".overlay");

            ////Close sidebar
            //jQuery.Select(Document.Body).Click((e)=> {
            //    var target = jQuery.Select(e.Target);

            //    if (e.Target.NodeName.ToLowerCase().Equals("i")) { target = target.Parent(); }

            //    if (!target.HasClass("bars") && this.isOpen() && target.Parents("#leftsidebar").Length == 0) {
            //        //if (!$target.hasClass('js-right-sidebar')) $overlay.fadeOut();
            //        if (!target.HasClass("js-right-sidebar")) overlay.FadeOut();
            //        body.RemoveClass("overlay-open");
            //    }
            //});
        }

        //private bool isOpen()
        //{
        //    return jQuery.Select("body").HasClass("overlay-open");
        //}
    }

    public class RightSideBar : SideBar<RightSideBar>
    {
        public RightSideBar() : base(SideBarType.Right) { }
    }

    public enum SideBarType
    {
        Left,
        Right
    }
}
