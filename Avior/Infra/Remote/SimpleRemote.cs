using Bridge;
using Bridge.jQuery2;
using System;

namespace Avior.Infra.Remote
{
    [External]
    [Constructor("$")]
    [Name("$")]
    public class SimpleRemote
    {
        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        /// <param name="url">A string containing the URL to which the request is sent.</param>
        /// <param name="data">A plain object or string that is sent to the server with the request.</param>
        /// <param name="success">A callback function that is executed if the request succeeds. The data, textStatus and jqXHR instance are passed to the success handler.</param>
        /// <returns>A jqXHR instance</returns>
        public static jqXHR post(string url, object data, Delegate success)
        {
            return null;
        }

        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        /// <param name="url">A string containing the URL to which the request is sent.</param>
        /// <param name="data">A plain object or string that is sent to the server with the request.</param>
        /// <param name="success">A callback function that is executed if the request succeeds. The data, textStatus and jqXHR instance are passed to the success handler.</param>
        /// <returns>A jqXHR instance</returns>
        public static jqXHR post(string url, object data, Action<object, string, jqXHR> success)
        {
            return null;
        }

        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        /// <param name="url">A string containing the URL to which the request is sent.</param>
        /// <param name="data">A plain object or string that is sent to the server with the request.</param>
        /// <param name="success">A callback function that is executed if the request succeeds. The data, textStatus and jqXHR instance are passed to the success handler.</param>
        /// <param name="dataType">The type of data expected from the server. Default: Intelligent Guess (xml, json, script, or html).</param>
        /// <returns>A jqXHR instance</returns>
        public static jqXHR post(string url, object data, Delegate success, string dataType)
        {
            return null;
        }

        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        /// <param name="url">A string containing the URL to which the request is sent.</param>
        /// <param name="data">A plain object or string that is sent to the server with the request.</param>
        /// <param name="success">A callback function that is executed if the request succeeds. The data, textStatus and jqXHR instance are passed to the success handler.</param>
        /// <param name="dataType">The type of data expected from the server. Default: Intelligent Guess (xml, json, script, or html).</param>
        /// <returns>A jqXHR instance</returns>
        public static jqXHR post(string url, object data, Action<object, string, jqXHR> success, string dataType)
        {
            return null;
        }
    }
}
