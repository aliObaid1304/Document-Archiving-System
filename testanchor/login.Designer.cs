namespace testanchor
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_post_button = new System.Windows.Forms.Button();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // add_post_button
            // 
            this.add_post_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_post_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_post_button.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_post_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_post_button.Location = new System.Drawing.Point(189, 204);
            this.add_post_button.Name = "add_post_button";
            this.add_post_button.Size = new System.Drawing.Size(298, 60);
            this.add_post_button.TabIndex = 13;
            this.add_post_button.Text = "دخول";
            this.add_post_button.UseVisualStyleBackColor = false;
            this.add_post_button.Click += new System.EventHandler(this.add_post_button_Click_1);
            this.add_post_button.Enter += new System.EventHandler(this.add_post_button_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile2.Location = new System.Drawing.Point(19, 143);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(164, 55);
            this.metroTile2.TabIndex = 12;
            this.metroTile2.Text = "كلمة السر";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile1.Location = new System.Drawing.Point(19, 71);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(164, 55);
            this.metroTile1.TabIndex = 11;
            this.metroTile1.Text = "اسم المستخدم";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(155, 0);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(34, 23);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.password.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(189, 143);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(298, 55);
            this.password.TabIndex = 10;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.UseSelectable = true;
            this.password.UseSystemPasswordChar = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.username.CustomButton.Image = null;
            this.username.CustomButton.Location = new System.Drawing.Point(155, 0);
            this.username.CustomButton.Name = "";
            this.username.CustomButton.Size = new System.Drawing.Size(34, 23);
            this.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username.CustomButton.TabIndex = 1;
            this.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username.CustomButton.UseSelectable = true;
            this.username.CustomButton.Visible = false;
            this.username.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.username.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.username.Lines = new string[0];
            this.username.Location = new System.Drawing.Point(189, 71);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.ShortcutsEnabled = true;
            this.username.Size = new System.Drawing.Size(298, 55);
            this.username.TabIndex = 9;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.UseSelectable = true;
            this.username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 298);
            this.Controls.Add(this.add_post_button);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "login";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_post_button;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroTextBox username;
    }
}