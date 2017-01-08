using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EVEOnlineSingleSignOnWinForms.Extensions;
using EVEOnlineSingleSignOnWinForms.Properties;
using Flurl;
using Flurl.Util;

namespace EVEOnlineSingleSignOnWinForms.Controllers {
    public class CallbackController : ApiController {
        public HttpResponseMessage Get() {
            var query = Request.GetQueryNameValuePairs().ToDictionary();

            if (!query.ContainsKey("code")) return RedirectTo("failed");

            var code = query["code"];

            TokenOperations.FromAuthorizationCode(code);

            return RedirectTo("success");
        }

        private HttpResponseMessage RedirectTo(string pathSegment) {
            var url = Settings.Default.InternalServerBaseUrl
                .AppendPathSegment($"{pathSegment}.html");
            var response = Request.CreateResponse(HttpStatusCode.Moved);
            response.Headers.Location = new Uri(url.ToInvariantString());
            return response;
        }
    }
}