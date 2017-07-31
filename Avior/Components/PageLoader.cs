using Bridge;
using Bridge.Html5;
using Newtonsoft.Json;
using System;

namespace Avior.Components
{
    public class PageLoader : Component<PageLoader>
    {
        public String Text { get; set; }

        public PageLoader() : base(new HTMLDivElement())
        {
            AddClass("page-loader-wrapper");
        }

        public override HTMLElement Render()
        {
            Add(Div().AddClass("loader").Add(
                        Div().AddClass("preloader").Add(
                            Div().AddClass("spinner-layer pl-red").Add(
                                Div().AddClass("circle-clipper left").Add(
                                    Div().AddClass("circle"))).Add(
                                Div().AddClass("circle-clipper right").Add(
                                    Div().AddClass("circle"))))).Add(
                        P().Text(Text)));

            return Content;
        }
    }

    public static class PageLoaderFluent
    {
        public static PageLoader Text(this PageLoader pageLoader, String text)
        {
            pageLoader.Text = text;
            return pageLoader;
        }
    }
}
