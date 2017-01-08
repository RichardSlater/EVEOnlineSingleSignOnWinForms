using System;
using System.Diagnostics;
using System.Windows.Forms;
using EVEOnlineSingleSignOnWinForms.Properties;
using Flurl;
using Microsoft.Owin.Hosting;

namespace EVEOnlineSingleSignOnWinForms {
    public partial class MainWindow : Form {
        private readonly Timer _timer = new Timer();
        private IDisposable _webServer;

        public MainWindow() {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            _timer.Enabled = false;
            _timer.Tick += ShutdownServer;
            _timer.Interval = 5000;

            GlobalEvents.OnComplete += GlobalEventsOnOnComplete;
            var baseUrl = Settings.Default.InternalServerBaseUrl;
            _webServer = WebApp.Start<Startup>(baseUrl);
            var startUrl = baseUrl.AppendPathSegment("start");
            Process.Start(startUrl);
        }

        private void GlobalEventsOnOnComplete(object sender, SignOnCompleteEventArgs signOnCompleteEventArgs) {
            var expiryTime = DateTimeOffset.UtcNow.AddSeconds(signOnCompleteEventArgs.Expires);
            var expiryText = $"{signOnCompleteEventArgs.Expires} seconds (~{expiryTime})";

            MethodInvoker updateForm = delegate {
                AuthTokenText.Text = signOnCompleteEventArgs.AuthorizationToken;
                AccessTokenText.Text = signOnCompleteEventArgs.AccessToken;
                RefreshTokenText.Text = signOnCompleteEventArgs.RefreshToken;
                AccessTokenExpiryText.Text = expiryText;
            };

            if (InvokeRequired)
                Invoke(updateForm);
            else
                updateForm();

            _timer.Enabled = true;
        }

        private void ShutdownServer(object sender, EventArgs e) {
            _timer.Enabled = false;

            if (_webServer == null) return;
            lock (_webServer) {
                if (_webServer == null) return;
                _webServer.Dispose();
                _webServer = null;
            }
        }

        private void RefreshTokenButton_Click(object sender, EventArgs e) {
            TokenOperations.FromRefreshToken(RefreshTokenText.Text);
        }
    }
}