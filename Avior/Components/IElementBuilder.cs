using Bridge;
using Bridge.Html5;
using Newtonsoft.Json;
using System;

namespace Avior.Components
{
    public interface IElementBuilder
    {
        HTMLElement BuildElement();

        //IElementBuilder Add(IElementBuilder child);

        //IElementBuilder Id(String id);

        //IElementBuilder CssClass(String css);

        //IElementBuilder Text(String text);

        //IElementBuilder AriaHidden(bool value);

        //IElementBuilder OnClick(Action<MouseEvent> OnClick);
    }
}
