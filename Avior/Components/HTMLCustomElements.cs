using Bridge;
using Bridge.Html5;

namespace Avior.Components
{
    [External]
    [Name("PageElement")]
    public sealed class PageElement : HTMLElement<PageElement>
    {
        [Template("document.createElement('page')")]
        public PageElement() { }
    }

    [External]
    [Name("HTMLNavElement")]
    public sealed class HTMLNavElement : HTMLElement<HTMLNavElement>
    {
        [Template("document.createElement('nav')")]
        public HTMLNavElement() { }
    }

    [External]
    [Name("HTMLASideElement")]
    public sealed class HTMLASideElement : HTMLElement<HTMLASideElement>
    {
        [Template("document.createElement('aside')")]
        public HTMLASideElement() { }
    }

    [External]
    [Name("HTMLIconElement")]
    public sealed class HTMLIconElement : HTMLElement<HTMLIconElement>
    {
        [Template("document.createElement('i')")]
        public HTMLIconElement() { }
    }
}
