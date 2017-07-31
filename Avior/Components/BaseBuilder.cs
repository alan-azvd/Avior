using Bridge;
using Bridge.Html5;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Avior.Components
{
    public class BaseBuilder<T> : IElementBuilder where T : BaseBuilder<T>
    {
        private HTMLElement element = null;

        protected void BaseElement(HTMLElement element)
        {
            this.element = element;
        }

        public HTMLElement BuildElement()
        {
            return element;
        }

        public T Add(IElementBuilder child)
        {
            element.AppendChild(child.BuildElement());
            return this as T;
        }

        public T Id(String id)
        {
            element.Id = id;
            return this as T;
        }

        public T AddClass(String css)
        {
            String[] list = css.Split(" ");
            foreach (var item in list)
                element.ClassList.Add(item);

            return this as T;
        }

        public T Text(String text)
        {
            var node = Document.CreateTextNode(text);
            element.AppendChild(node);
            return this as T;
        }

        public T AriaHidden(bool value)
        {
            element.SetAttribute("aria-hidden", value.ToString());
            return this as T;
        }

        public T AriaExpanded(bool value)
        {
            element.SetAttribute("aria-expanded", value.ToString());
            return this as T;
        }

        public T OnClick(Action<MouseEvent> OnClick)
        {
            element.OnClick += OnClick;
            return this as T;
        }
    }
}
