using System;
using Bridge;
using Bridge.Html5;
using Newtonsoft.Json;
using Bridge.jQuery2;

namespace Avior.Components
{
    public class DivBuilder : BaseBuilder<DivBuilder>
    {
        private HTMLDivElement div = new HTMLDivElement();

        public DivBuilder()
        {
            BaseElement(div);
        }
    }

    public class H1Builder : BaseBuilder<H1Builder>
    {
        private HTMLHeadingElement h1 = new HTMLHeadingElement(HeadingType.H1);

        public H1Builder()
        {
            BaseElement(h1);
        }
    }

    public class ButtonBuilder : BaseBuilder<ButtonBuilder>
    {
        private HTMLButtonElement button = new HTMLButtonElement();

        public ButtonBuilder()
        {
            BaseElement(button);
            AddClass("btn waves-effect");
            AddClass(ButtonStyle.Default.ToString().ToLower());
        }

        public ButtonBuilder Style(ButtonStyle type)
        {
            var jbutton = jQuery.Select(button);

            foreach (ButtonStyle style in Enum.GetValues(typeof(ButtonStyle)))
                if (jbutton.HasClass(style.ToString().ToLower()))
                    jbutton.RemoveClass(style.ToString().ToLower());

            AddClass(type.ToString().ToLower());
            return this;
        }
    }

    public enum ButtonStyle
    {
        Default,
        Primary,
        Success,
        Info,
        Warning,
        Danger,
        Link
    }

    public class LinkBuilder : BaseBuilder<LinkBuilder>
    {
        private HTMLAnchorElement anchor = new HTMLAnchorElement();

        public LinkBuilder()
        {
            BaseElement(anchor);
        }

        public LinkBuilder Href(String href)
        {
            anchor.Href = href;
            return this;
        }

        public LinkBuilder DataToggle(String value)
        {
            anchor.SetAttribute("data-toggle", value);
            return this;
        }

        public LinkBuilder DataTarget(String value)
        {
            anchor.SetAttribute("data-target", value);
            return this;
        }
    }

    public class IconBuilder : BaseBuilder<IconBuilder>
    {
        private HTMLIconElement icon = new HTMLIconElement();

        public IconBuilder()
        {
            BaseElement(icon);
        }
    }

    public class MaterialIconBuilder : BaseBuilder<MaterialIconBuilder>
    {
        private HTMLIconElement icon = new HTMLIconElement();
        private String type = String.Empty;

        public MaterialIconBuilder()
        {
            BaseElement(icon);
            AddClass("material-icons");
        }

        public String IconType()
        {
            return type;
        }

        public MaterialIconBuilder IconType(String type)
        {
            this.type = type;
            var node = Document.CreateTextNode(this.type);
            icon.AppendChild(node);
            return this;
        }
    }

    public class NavBuilder : BaseBuilder<NavBuilder>
    {
        private HTMLNavElement nav = new HTMLNavElement();

        public NavBuilder()
        {
            BaseElement(nav);
        }
    }

    public class SpanBuilder : BaseBuilder<SpanBuilder>
    {
        private HTMLSpanElement span = new HTMLSpanElement();

        public SpanBuilder()
        {
            BaseElement(span);
        }
    }

    public class LiBuilder : BaseBuilder<LiBuilder>
    {
        private HTMLLIElement li = new HTMLLIElement();

        public LiBuilder()
        {
            BaseElement(li);
        }
    }

    
    public class ParagraphBuilder : BaseBuilder<ParagraphBuilder>
    {
        private HTMLParagraphElement p = new HTMLParagraphElement();

        public ParagraphBuilder()
        {
            BaseElement(p);
        }
    }
}
