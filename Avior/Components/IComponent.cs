
using Bridge;
using Bridge.Html5;
using Newtonsoft.Json;
using System;

namespace Avior.Components
{
    public interface IComponent
    {
        void PreRender();
        HTMLElement Render();
        void PosRender();
    }
}
