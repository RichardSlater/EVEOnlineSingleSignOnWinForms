﻿namespace EVEOnlineSingleSignOnWinForms {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RefreshTokenText = new System.Windows.Forms.TextBox();
            this.AccessTokenText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AccessTokenExpiryText = new System.Windows.Forms.Label();
            this.AuthTokenText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RefreshTokenButton = new System.Windows.Forms.Button();
            this.GetCharacterButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.RefreshTokenText, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.AccessTokenText, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LoginButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.AccessTokenExpiryText, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.AuthTokenText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 774);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // RefreshTokenText
            // 
            this.RefreshTokenText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshTokenText.Location = new System.Drawing.Point(6, 540);
            this.RefreshTokenText.Margin = new System.Windows.Forms.Padding(6);
            this.RefreshTokenText.Multiline = true;
            this.RefreshTokenText.Name = "RefreshTokenText";
            this.RefreshTokenText.Size = new System.Drawing.Size(533, 149);
            this.RefreshTokenText.TabIndex = 9;
            // 
            // AccessTokenText
            // 
            this.AccessTokenText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccessTokenText.Location = new System.Drawing.Point(6, 286);
            this.AccessTokenText.Margin = new System.Windows.Forms.Padding(6);
            this.AccessTokenText.Multiline = true;
            this.AccessTokenText.Name = "AccessTokenText";
            this.AccessTokenText.Size = new System.Drawing.Size(533, 149);
            this.AccessTokenText.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 444);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Access Token Expiry";
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Image = ((System.Drawing.Image)(resources.GetObject("LoginButton.Image")));
            this.LoginButton.Location = new System.Drawing.Point(3, 3);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(276, 51);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "One-time Authorization Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Access Token";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 506);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Refresh Token";
            // 
            // AccessTokenExpiryText
            // 
            this.AccessTokenExpiryText.AutoSize = true;
            this.AccessTokenExpiryText.Location = new System.Drawing.Point(3, 475);
            this.AccessTokenExpiryText.Margin = new System.Windows.Forms.Padding(3);
            this.AccessTokenExpiryText.Name = "AccessTokenExpiryText";
            this.AccessTokenExpiryText.Size = new System.Drawing.Size(54, 25);
            this.AccessTokenExpiryText.TabIndex = 6;
            this.AccessTokenExpiryText.Text = "TBD";
            // 
            // AuthTokenText
            // 
            this.AuthTokenText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthTokenText.Location = new System.Drawing.Point(6, 94);
            this.AuthTokenText.Margin = new System.Windows.Forms.Padding(6);
            this.AuthTokenText.Multiline = true;
            this.AuthTokenText.Name = "AuthTokenText";
            this.AuthTokenText.ReadOnly = true;
            this.AuthTokenText.Size = new System.Drawing.Size(533, 149);
            this.AuthTokenText.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.RefreshTokenButton);
            this.flowLayoutPanel1.Controls.Add(this.GetCharacterButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 698);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(539, 73);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // RefreshTokenButton
            // 
            this.RefreshTokenButton.Enabled = false;
            this.RefreshTokenButton.Location = new System.Drawing.Point(3, 3);
            this.RefreshTokenButton.Name = "RefreshTokenButton";
            this.RefreshTokenButton.Size = new System.Drawing.Size(200, 65);
            this.RefreshTokenButton.TabIndex = 11;
            this.RefreshTokenButton.Text = "Refresh Token";
            this.RefreshTokenButton.UseVisualStyleBackColor = true;
            this.RefreshTokenButton.Click += new System.EventHandler(this.RefreshTokenButton_Click);
            // 
            // GetCharacterButton
            // 
            this.GetCharacterButton.Enabled = false;
            this.GetCharacterButton.Location = new System.Drawing.Point(209, 3);
            this.GetCharacterButton.Name = "GetCharacterButton";
            this.GetCharacterButton.Size = new System.Drawing.Size(200, 65);
            this.GetCharacterButton.TabIndex = 12;
            this.GetCharacterButton.Text = "Get Character";
            this.GetCharacterButton.UseVisualStyleBackColor = true;
            this.GetCharacterButton.Click += new System.EventHandler(this.GetCharacterButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 774);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "EVE Online SSO Example";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RefreshTokenText;
        private System.Windows.Forms.TextBox AccessTokenText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AccessTokenExpiryText;
        private System.Windows.Forms.TextBox AuthTokenText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button RefreshTokenButton;
        private System.Windows.Forms.Button GetCharacterButton;
    }
}

