using Bridge;
using Bridge.Html5;
using Newtonsoft.Json;
using System;

namespace Avior.Components
{
    public class Icon : Component<Icon>
    {
        private String type = String.Empty;

        public Icon() : base(new HTMLIconElement())
        {
            AddClass("material-icons");
        }

        

        public override HTMLElement Render()
        {
            return Content;
        }
    }
}
