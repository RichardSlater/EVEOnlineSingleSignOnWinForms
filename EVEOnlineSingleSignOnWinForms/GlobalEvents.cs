using System;

namespace EVEOnlineSingleSignOnWinForms {
    public static class GlobalEvents {
        public static event EventHandler<SignOnCompleteEventArgs> OnComplete;

        public static void Complete(object sender, SignOnCompleteEventArgs e) {
            OnComplete(sender, e);
        }
    }
}