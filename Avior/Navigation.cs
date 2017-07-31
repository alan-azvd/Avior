using Bridge;
using Bridge.Html5;
using System;
using Avior.Components;

namespace Avior
{
    public class Navigation<T> where T : Page
    {
        public static void Go()
        {
            var pageToGo = Activator.CreateInstance<T>();
            var currentPage = Document.Body.QuerySelector("page");
            Document.Body.RemoveChild(currentPage);
            pageToGo.PreRender();
            Document.Body.AppendChild(pageToGo.Render());
            pageToGo.PosRender();
        }

        //public static void Go(params object[] param)
        //{
        //    String s = String.Empty;
        //    foreach (var obj in param)
        //    {
        //        String o = String.Empty;

        //        if (obj.GetType().Equals(typeof(String)))
        //        {
        //            o = "'" + obj.ToString() + "'";
        //        }
        //        else
        //        {
        //            o = obj.ToString();
        //        }
        //        s = s + o + ",";
        //    }
        //    s = s.Remove(s.LastIndexOf(","));
        //    Script.Eval(String.Format("new {0}({1})", typeof(T).Name, s));
        //}
    }
}
