using System;

namespace EVEOnlineSingleSignOnWinForms {
    public class SignOnCompleteEventArgs : EventArgs {
        public string AuthorizationToken { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public int Expires { get; set; }
    }
}