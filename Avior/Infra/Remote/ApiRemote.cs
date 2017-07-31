using Bridge.Html5;
using Bridge.jQuery2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Avior.Pages.Infra.Remote
{
    public abstract class ApiRemote
    {
        private String Url;

        public ApiRemote(String Url)
        {
            this.Url = Url;
        }

        private void execute<T>(String type, String url, object obj, Action<T> callback)
        {
            LowLevelRemote.ajax(
                new RemoteOptions()
                {
                    type = type,
                    url = url,
                    //data = JSON.Stringify(obj),
                    data = obj,
                    success = delegate (object data, string str, jqXHR jqXHR)
                    {
                        callback((T)data);
                    },
                    dataType = "json",
                    //contentType = "application/json; charset=utf-8"
                }
            );
        }

        private async Task<object> execute(String type, object obj)
        {
            var options = new RemoteOptions()
            {
                type = type,
                url = Url,
                cache = false,
                data = JSON.Stringify(obj),
                //data = obj,
                dataType = "json",
                contentType = "application/json; charset=utf-8",
                crossDomain = true
            };

            var callback = (Func<object, string, jqXHR, object>)((response, status, xhr) => response);

            var task = Task.FromPromise<object>(LowLevelRemote.ajax(options), callback);

            await task;

            return task.Result;
        }

        private async Task<T> execute<T>(String type, object obj)
        {
            var options = new RemoteOptions()
            {
                type = type,
                url = Url,
                cache = false,
                data = JSON.Stringify(obj),
                //data = obj,
                //dataType = "json",
                dataType = "text",
                contentType = "application/json; charset=utf-8",
                crossDomain = true
            };

            var callback = (Func<string, string, jqXHR, string>)((response, status, xhr) => response);

            var task = Task.FromPromise<string>(LowLevelRemote.ajax(options), callback);

            await task;

            string result = task.Result;

            return JSON.Parse<T>(result);
        }

        protected void executePost<T>(String url, object obj, Action<T> callback)
        {
            execute("POST", url, obj, callback);
        }

        public async Task<object> Post(object o)
        {
            var result = await execute("POST", o);
            return result;
        }

        public async Task<T> Post<T>(object o)
        {
            var result = await execute<T>("POST", o);
            return result;
        }
    }
}
