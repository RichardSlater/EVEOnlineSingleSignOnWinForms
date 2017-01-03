using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Flurl;
using Flurl.Http;
using Flurl.Util;
using Newtonsoft.Json.Linq;
using EVEOnlineSingleSignOnWinForms.Extensions;

namespace EVEOnlineSingleSignOnWinForms.Controllers {
    public class CallbackController : ApiController {
        public async Task<HttpResponseMessage> Get() {
            var query = Request.GetQueryNameValuePairs().ToDictionary();
            var settings = Properties.Settings.Default;

            if (!query.ContainsKey("code")) {
                return RedirectTo("failed");
            }

            var code = query["code"];

            var body = new Dictionary<string, string> {
                {"grant_type", "authorization_code"},
                {"code", code}
            };
            var content = new FormUrlEncodedContent(body);
            var result = await settings.LoginServerBaseUrl
                .AppendPathSegment("token")
                .WithBasicAuth(settings.ClientID, settings.ClientSecret)
                .PostAsync(content)
                .ReceiveString();

            var obj = JObject.Parse(result);
            var args = new SignOnCompleteEventArgs {
                AuthorizationToken = code,
                AccessToken = obj.SelectToken("access_token").Value<string>(),
                Expires = obj.SelectToken("expires_in").Value<int>(),
                RefreshToken = obj.SelectToken("refresh_token").Value<string>()
            };

            GlobalEvents.Complete(this, args);

            return RedirectTo("success");
        }

        private HttpResponseMessage RedirectTo(string pathSegment) {
            var url = Properties.Settings.Default.InternalServerBaseUrl
                .AppendPathSegment($"{pathSegment}.html");
            var response = Request.CreateResponse(HttpStatusCode.Moved);
            response.Headers.Location = new Uri(url.ToInvariantString());
            return response;
        }
    }
}