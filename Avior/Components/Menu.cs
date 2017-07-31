using Bridge;
using Bridge.Html5;
using Newtonsoft.Json;
using System;

namespace Avior.Components
{
    public class Menu : Component<Menu>
    {
        public Menu() : base(new HTMLUListElement())
        {
            AddClass("list");
        }

        public override HTMLElement Render()
        {
            var div = new HTMLDivElement()
            {
                ClassName = "menu"
            };
            
            div.AppendChild(Content);
            return div;
        }
    }

    //public abstract class MenuItem<T> : Component<MenuItem<T>> where T : MenuItem<T>
    public abstract class MenuItem : Component<MenuItem>
    {
        //private String text = String.Empty;
        //private String iconType = String.Empty;
        public String Text { get; set; }
        public String IconType { get; set; }

        public MenuItem() : base(new HTMLLIElement()) { }

        //public String Text()
        //{
        //    return text;
        //}

        //public T Text(String text)
        //{
        //    this.text = text;
        //    return this as T;
        //}

        //public String IconType()
        //{
        //    return iconType;
        //}

        //public T IconType(String iconType)
        //{
        //    this.iconType = iconType;
        //    return this as T;
        //}
    }

    public class MenuHeader : MenuItem//<MenuHeader>
    {
        public MenuHeader()
        {
            AddClass("header");
        }

        public override HTMLElement Render()
        {
            var node = Document.CreateTextNode(Text);
            Content.AppendChild(node);
            return Content;
        }
    }

    public class ClicableItem : MenuItem//<ClicableItem>
    {
        public override HTMLElement Render()
        {
            var link = Link().Href("javascript:void(0);");

            if (!String.IsNullOrEmpty(IconType))
                link.Add(Icon().IconType(this.IconType))
                    .Add(Span().Text(Text));

            Add(link);
            return Content;
        }
    }

    public static class MenuItemFluent
    {
        public static MenuItem Text(this MenuItem item, String text)
        {
            item.Text = text;
            return item;
        }
        
        public static MenuItem IconType(this MenuItem item, String iconType)
        {
            item.IconType = iconType;
            return item;
        }
    }
}
