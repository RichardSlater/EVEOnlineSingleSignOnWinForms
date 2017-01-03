using EVEOnlineSingleSignOnWinForms.Extensions;
using Owin;

namespace EVEOnlineSingleSignOnWinForms {
    public class Startup {
        public void Configuration(IAppBuilder app) {
            app.UseStaticContent();
            app.UseRedirectionEndPoints();
        }
    }
}