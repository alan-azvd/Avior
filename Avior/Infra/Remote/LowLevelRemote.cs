using Bridge;
using Bridge.jQuery2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avior.Pages.Infra.Remote
{
    [External]
    [Constructor("$")]
    [Name("$")]
    public class LowLevelRemote
    {
        /// <summary>
        /// Perform an asynchronous HTTP (Ajax) request.
        /// </summary>
        /// <param name="settings">A set of key/value pairs that configure the Ajax request. All settings are optional. A default can be set for any option with $.ajaxSetup(). See jQuery.ajax( settings ) below for a complete list of all settings. </param>
        /// <returns></returns>
        public static jqXHR ajax(RemoteOptions settings)
        {
            return null;
        }
    }
}
