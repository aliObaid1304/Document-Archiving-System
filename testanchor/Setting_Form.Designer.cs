namespace testanchor
{
    partial class Setting_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_Form));
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.upload_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_post_button = new System.Windows.Forms.Button();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(452, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(438, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "تصدير جميع البيانات الى ملف اكسل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.BackColor = System.Drawing.Color.Lime;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(218, 18);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(673, 42);
            this.metroLabel4.TabIndex = 80;
            this.metroLabel4.Text = "تمكنك هذه الواجهة من تصدير و استيراد بياناتك و حفظها في هارد خارجي ";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(20, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 455);
            this.panel1.TabIndex = 81;
            this.panel1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(865, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(32, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(415, 41);
            this.button2.TabIndex = 82;
            this.button2.Text = "استيراد بيانات من ملف اكسل";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(20, 28);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(43, 38);
            this.button3.TabIndex = 83;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // upload_btn
            // 
            this.upload_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.upload_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.upload_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.upload_btn.Location = new System.Drawing.Point(23, 660);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(178, 47);
            this.upload_btn.TabIndex = 84;
            this.upload_btn.Text = "رفع البيانات";
            this.upload_btn.UseVisualStyleBackColor = false;
            this.upload_btn.Visible = false;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.add_post_button);
            this.panel2.Controls.Add(this.password);
            this.panel2.Location = new System.Drawing.Point(93, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 80);
            this.panel2.TabIndex = 85;
            // 
            // add_post_button
            // 
            this.add_post_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_post_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_post_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_post_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_post_button.Location = new System.Drawing.Point(92, 13);
            this.add_post_button.Name = "add_post_button";
            this.add_post_button.Size = new System.Drawing.Size(138, 60);
            this.add_post_button.TabIndex = 18;
            this.add_post_button.Text = "اختبر الصلاحية";
            this.add_post_button.UseVisualStyleBackColor = false;
            this.add_post_button.Click += new System.EventHandler(this.add_post_button_Click_1);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(46, 53);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.password.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(238, 15);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(271, 55);
            this.password.TabIndex = 17;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.UseSelectable = true;
            this.password.UseSystemPasswordChar = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Setting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 742);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel4);
            this.Movable = false;
            this.Name = "Setting_Form";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.Setting_Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add_post_button;
        private MetroFramework.Controls.MetroTextBox password;
    }
}