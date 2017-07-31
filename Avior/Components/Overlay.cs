using Bridge;
using Bridge.Html5;
using Newtonsoft.Json;
using System;

namespace Avior.Components
{
    public class Overlay : Component<Overlay>
    {
        public Overlay() : base(new HTMLDivElement())
        {
            AddClass("overlay");
        }

        public override HTMLElement Render()
        {
            return Content;
        }
    }
}
