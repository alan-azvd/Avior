using Bridge;
using Bridge.Html5;
using Bridge.jQuery2;
using System;

namespace Avior.Infra.Remote
{
    [External]
    [ObjectLiteral]
    public class RemoteOptions
    {
        /// <summary>
        /// The content type sent in the request header that tells the server what kind of response it will accept in return.
        /// </summary>
        public virtual object accepts
        {
            get;
            set;
        }

        /// <summary>
        /// By default, all requests are sent asynchronously (i.e. this is set to true by default). If you need synchronous requests, set this option to false. Cross-domain requests and dataType: "jsonp" requests do not support synchronous operation. Note that synchronous requests may temporarily lock the browser, disabling any actions while the request is active.
        /// </summary>
        public virtual bool async
        {
            get;
            set;
        }

        /// <summary>
        /// A pre-request callback function that can be used to modify the jqXHR (in jQuery 1.4.x, XMLHTTPRequest) object before it is sent. Use this to set custom headers, etc. The jqXHR and settings objects are passed as arguments. This is an Ajax Event. Returning false in the beforeSend function will cancel the request.
        /// </summary>
        public virtual Func<jqXHR, object, bool> beforeSend
        {
            get;
            set;
        }

        /// <summary>
        /// If set to false, it will force requested pages not to be cached by the browser. Note: Setting cache to false will only work correctly with HEAD and GET requests. It works by appending "_={timestamp}" to the GET parameters. The parameter is not needed for other types of requests, except in IE8 when a POST is made to a URL that has already been requested by a GET.
        /// </summary>
        public virtual bool cache
        {
            get;
            set;
        }

        /// <summary>
        /// A function to be called when the request finishes (after success and error callbacks are executed). The function gets passed two arguments: The jqXHR (in jQuery 1.4.x, XMLHTTPRequest) object and a string categorizing the status of the request ("success", "notmodified", "error", "timeout", "abort", or "parsererror").
        /// </summary>
        public virtual Action<jqXHR, string> complete
        {
            get;
            set;
        }

        /// <summary>
        /// A function to be called when the request finishes (after success and error callbacks are executed). The function gets passed two arguments: The jqXHR (in jQuery 1.4.x, XMLHTTPRequest) object and a string categorizing the status of the request ("success", "notmodified", "error", "timeout", "abort", or "parsererror").
        /// </summary>
        public virtual Action<jqXHR, string>[] completeArray
        {
            get;
            set;
        }

        /// <summary>
        /// An object of string/regular-expression pairs that determine how jQuery will parse the response, given its content type.
        /// </summary>
        public virtual object contents
        {
            get;
            set;
        }

        /// <summary>
        /// When sending data to the server, use this content type. Default is "application/x-www-form-urlencoded; charset=UTF-8", which is fine for most cases. If you explicitly pass in a content-type to $.ajax(), then it is always sent to the server (even if no data is sent). The W3C XMLHttpRequest specification dictates that the charset is always UTF-8; specifying another charset will not force the browser to change the encoding.
        /// </summary>
        public virtual Union<string, bool> contentType
        {
            get;
            set;
        }

        /// <summary>
        /// This object will be made the context of all Ajax-related callbacks. By default, the context is an object that represents the ajax settings used in the call ($.ajaxSettings merged with the settings passed to $.ajax).
        /// </summary>
        public virtual object context
        {
            get;
            set;
        }

        /// <summary>
        /// An object containing dataType-to-dataType converters. Each converter's value is a function that returns the transformed value of the response.
        /// </summary>
        public virtual object converters
        {
            get;
            set;
        }

        /// <summary>
        /// If you wish to force a crossDomain request (such as JSONP) on the same domain, set the value of crossDomain to true. This allows, for example, server-side redirection to another domain.
        /// </summary>
        public virtual bool crossDomain
        {
            get;
            set;
        }

        /// <summary>
        /// Data to be sent to the server. It is converted to a query string, if not already a string. It's appended to the url for GET-requests. See processData option to prevent this automatic processing. Object must be Key/Value pairs. If value is an Array, jQuery serializes multiple values with same key based on the value of the traditional setting (described below).
        /// </summary>
        public virtual object data
        {
            get;
            set;
        }

        /// <summary>
        /// Data to be sent to the server. It is converted to a query string, if not already a string. It's appended to the url for GET-requests. See processData option to prevent this automatic processing. Object must be Key/Value pairs. If value is an Array, jQuery serializes multiple values with same key based on the value of the traditional setting (described below).
        /// </summary>
        public virtual object dataString
        {
            get;
            set;
        }

        /// <summary>
        /// A function to be used to handle the raw response data of XMLHttpRequest.This is a pre-filtering function to sanitize the response. You should return the sanitized data. The function accepts two arguments: The raw data returned from the server and the 'dataType' parameter.
        /// </summary>
        public virtual Func<string, string, object> dataFilter
        {
            get;
            set;
        }

        /// <summary>
        /// The type of data that you're expecting back from the server. If none is specified, jQuery will try to infer it based on the MIME type of the response (an XML MIME type will yield XML, in 1.4 JSON will yield a JavaScript object, in 1.4 script will execute the script, and anything else will be returned as a string). (xml, json, script, or html)
        /// </summary>
        public virtual string dataType
        {
            get;
            set;
        }

        /// <summary>
        /// A function to be called if the request fails. The function receives three arguments: The jqXHR (in jQuery 1.4.x, XMLHttpRequest) object, a string describing the type of error that occurred and an optional exception object, if one occurred. Possible values for the second argument (besides null) are "timeout", "error", "abort", and "parsererror". When an HTTP error occurs, errorThrown receives the textual portion of the HTTP status, such as "Not Found" or "Internal Server Error."
        /// </summary>
        public virtual Action<jqXHR, string, string> error
        {
            get;
            set;
        }

        /// <summary>
        /// A function to be called if the request fails. The function receives three arguments: The jqXHR (in jQuery 1.4.x, XMLHttpRequest) object, a string describing the type of error that occurred and an optional exception object, if one occurred. Possible values for the second argument (besides null) are "timeout", "error", "abort", and "parsererror". When an HTTP error occurs, errorThrown receives the textual portion of the HTTP status, such as "Not Found" or "Internal Server Error."
        /// </summary>
        public virtual Action<jqXHR, string, string>[] errorArray
        {
            get;
            set;
        }

        /// <summary>
        /// Whether to trigger global Ajax event handlers for this request. The default is true. Set to false to prevent the global handlers like ajaxStart or ajaxStop from being triggered. This can be used to control various Ajax Events.
        /// </summary>
        public virtual bool global
        {
            get;
            set;
        }

        /// <summary>
        /// An object of additional header key/value pairs to send along with requests using the XMLHttpRequest transport. The header X-Requested-With: XMLHttpRequest is always added, but its default XMLHttpRequest value can be changed here. Values in the headers setting can also be overwritten from within the beforeSend function.
        /// </summary>
        public virtual object headers
        {
            get;
            set;
        }

        /// <summary>
        /// Allow the request to be successful only if the response has changed since the last request. This is done by checking the Last-Modified header. Default value is false, ignoring the header. In jQuery 1.4 this technique also checks the 'etag' specified by the server to catch unmodified data.
        /// </summary>
        public virtual bool ifModified
        {
            get;
            set;
        }

        /// <summary>
        /// Allow the current environment to be recognized as "local," (e.g. the filesystem), even if jQuery does not recognize it as such by default. The following protocols are currently recognized as local: file, *-extension, and widget. If the isLocal setting needs modification, it is recommended to do so once in the $.ajaxSetup() method.
        /// </summary>
        public virtual bool isLocal
        {
            get;
            set;
        }

        /// <summary>
        /// Override the callback function name in a jsonp request. This value will be used instead of 'callback' in the 'callback=?' part of the query string in the url. So {jsonp:'onJSONPLoad'} would result in 'onJSONPLoad=?' passed to the server.
        /// </summary>
        [Name("jsonp")]
        public virtual Union<string, bool> jsonP
        {
            get;
            set;
        }

        /// <summary>
        /// Specify the callback function name for a JSONP request. This value will be used instead of the random name automatically generated by jQuery. It is preferable to let jQuery generate a unique name as it'll make it easier to manage the requests and provide callbacks and error handling. You may want to specify the callback when you want to enable better browser caching of GET requests.
        /// </summary>
        public virtual string jsonpCallback
        {
            get;
            set;
        }

        /// <summary>
        /// Specify the callback function name for a JSONP request. This value will be used instead of the random name automatically generated by jQuery. It is preferable to let jQuery generate a unique name as it'll make it easier to manage the requests and provide callbacks and error handling. You may want to specify the callback when you want to enable better browser caching of GET requests.
        /// </summary>
        public virtual Action jsonpCallbackFn
        {
            get;
            set;
        }

        /// <summary>
        /// A mime type to override the XHR mime type.
        /// </summary>
        public virtual string mimeType
        {
            get;
            set;
        }

        /// <summary>
        /// A password to be used with XMLHttpRequest in response to an HTTP access authentication request.
        /// </summary>
        public virtual string password
        {
            get;
            set;
        }

        /// <summary>
        /// By default, data passed in to the data option as an object (technically, anything other than a string) will be processed and transformed into a query string, fitting to the default content-type "application/x-www-form-urlencoded". If you want to send a DOMDocument, or other non-processed data, set this option to false.
        /// </summary>
        public virtual bool processData
        {
            get;
            set;
        }

        /// <summary>
        /// Only applies when the "script" transport is used (e.g., cross-domain requests with "jsonp" or "script" dataType and "GET" type). Sets the charset attribute on the script tag used in the request. Used when the character set on the local page is not the same as the one on the remote script.
        /// </summary>
        public virtual string scriptCharset
        {
            get;
            set;
        }

        /// <summary>
        /// An object of numeric HTTP codes and functions to be called when the response has the corresponding code.
        /// </summary>
        public virtual object statusCode
        {
            get;
            set;
        }

        /// <summary>
        /// A function to be called if the request succeeds. The function gets passed three arguments: The data returned from the server, formatted according to the dataType parameter; a string describing the status; and the jqXHR (in jQuery 1.4.x, XMLHttpRequest) object.
        /// </summary>
        public virtual Action<object, string, jqXHR> success
        {
            get;
            set;
        }

        /// <summary>
        /// A function to be called if the request succeeds. The function gets passed three arguments: The data returned from the server, formatted according to the dataType parameter; a string describing the status; and the jqXHR (in jQuery 1.4.x, XMLHttpRequest) object.
        /// </summary>
        public virtual Action<object, string, jqXHR>[] successArray
        {
            get;
            set;
        }

        /// <summary>
        /// Set a timeout (in milliseconds) for the request. This will override any global timeout set with $.ajaxSetup(). The timeout period starts at the point the $.ajax call is made; if several other requests are in progress and the browser has no connections available, it is possible for a request to time out before it can be sent.
        /// </summary>
        public virtual int timeout
        {
            get;
            set;
        }

        /// <summary>
        /// Set this to true if you wish to use the traditional style of param serialization.
        /// </summary>
        public virtual bool traditional
        {
            get;
            set;
        }

        /// <summary>
        /// The type of request to make ("POST" or "GET"), default is "GET". Note: Other HTTP request methods, such as PUT and DELETE, can also be used here, but they are not supported by all browsers.
        /// </summary>
        public virtual string type
        {
            get;
            set;
        }

        /// <summary>
        /// A string containing the URL to which the request is sent.
        /// </summary>
        public virtual string url
        {
            get;
            set;
        }

        /// <summary>
        /// A username to be used with XMLHttpRequest in response to an HTTP access authentication request.
        /// </summary>
        public virtual string username
        {
            get;
            set;
        }

        /// <summary>
        /// Callback for creating the XMLHttpRequest object. Defaults to the ActiveXObject when available (IE), the XMLHttpRequest otherwise. Override to provide your own implementation for XMLHttpRequest or enhancements to the factory.
        /// </summary>
        public virtual Func<XMLHttpRequest> xhr
        {
            get;
            set;
        }

        /// <summary>
        /// An object of fieldName-fieldValue pairs to set on the native XHR object. For example, you can use it to set withCredentials to true for cross-domain requests if needed.
        /// </summary>
        public virtual object xhrFields
        {
            get;
            set;
        }
    }
}
