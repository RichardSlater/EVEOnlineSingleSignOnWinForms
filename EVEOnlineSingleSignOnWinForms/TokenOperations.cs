using System.Collections.Generic;
using System.Net.Http;
using EVEOnlineSingleSignOnWinForms.Properties;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json.Linq;

namespace EVEOnlineSingleSignOnWinForms {
    public static class TokenOperations {
        public static void FromAuthorizationCode(string code) {
            var body = new Dictionary<string, string> {
                {"grant_type", "authorization_code"},
                {"code", code}
            };
            GetToken(code, body);
        }

        public static void FromRefreshToken(string refreshToken) {
            var body = new Dictionary<string, string> {
                {"grant_type", "refresh_token"},
                {"refresh_token", refreshToken}
            };
            GetToken(refreshToken, body);
        }

        private static void GetToken(string code, Dictionary<string, string> body) {
            var settings = Settings.Default;
            var content = new FormUrlEncodedContent(body);
            var result = settings.LoginServerBaseUrl
                .AppendPathSegment("token")
                .WithBasicAuth(settings.ClientID, settings.ClientSecret)
                .PostAsync(content)
                .ReceiveString()
                .Result;

            var obj = JObject.Parse(result);
            var args = new SignOnCompleteEventArgs {
                AuthorizationToken = code,
                AccessToken = obj.SelectToken("access_token").Value<string>(),
                Expires = obj.SelectToken("expires_in").Value<int>(),
                RefreshToken = obj.SelectToken("refresh_token").Value<string>()
            };

            GlobalEvents.Complete(null, args);
        }
    }
}