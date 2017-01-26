using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EVEOnlineSingleSignOnWinForms.Properties;
using Flurl;
using Flurl.Util;

namespace EVEOnlineSingleSignOnWinForms.Controllers {
    public class StartController : ApiController {
        public HttpResponseMessage Get() {
            var state = Guid.NewGuid();
            var settings = Settings.Default;
            var callbackUrl = settings.InternalServerBaseUrl
                .AppendPathSegment("callback");
            var scopes = new string[settings.Scopes.Count];
            settings.Scopes.CopyTo(scopes, 0);
            var redirectUrl = settings.LoginServerBaseUrl
                .AppendPathSegment("authorize")
                .SetQueryParam("response_type", "code")
                .SetQueryParam("redirect_uri", callbackUrl)
                .SetQueryParam("client_id", settings.ClientID)
                .SetQueryParam("state", state)
                .SetQueryParam("scope", string.Join(" ", scopes));

            var response = Request.CreateResponse(HttpStatusCode.TemporaryRedirect);
            response.Headers.Location = new Uri(redirectUrl.ToInvariantString());
            return response;
        }
    }
}