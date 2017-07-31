using Bridge;
using Bridge.Html5;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Avior.Components
{
    public abstract class Component<T> : IComponent where T : Component<T>
    {
        protected HTMLElement Content { get; }

        public Component(HTMLElement content)
        {
            this.Content = content;
        }

        public virtual void PreRender() { }

        public abstract HTMLElement Render();

        public virtual void PosRender() { }

        protected T Add(IElementBuilder elem)
        {
            this.Content.AppendChild(elem.BuildElement());
            return this as T;
        }

        public T Add(IComponent child)
        {
            child.PreRender();
            this.Content.AppendChild(child.Render());
            child.PosRender();
            return this as T;
        }

        public T Id(String id)
        {
            Content.Id = id;
            return this as T;
        }

        public T AddClass(String css)
        {
            Content.ClassList.Add(css);
            return this as T;
        }

        protected DivBuilder Div()
        {
            return new DivBuilder();
        }

        protected H1Builder H1()
        {
            return new H1Builder();
        }

        protected ButtonBuilder Button()
        {
            return new ButtonBuilder();
        }

        protected LinkBuilder Link()
        {
            return new LinkBuilder();
        }

        protected IconBuilder I()
        {
            return new IconBuilder();
        }

        protected MaterialIconBuilder Icon()
        {
            return new MaterialIconBuilder();
        }

        protected SpanBuilder Span()
        {
            return new SpanBuilder();
        }

        protected LiBuilder Li()
        {
            return new LiBuilder();
        }

        protected ParagraphBuilder P()
        {
            return new ParagraphBuilder();
        }
    }
}
