namespace testanchor
{
    partial class update_book_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_book_form));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new System.Windows.Forms.ComboBox();
            this.book_date = new System.Windows.Forms.DateTimePicker();
            this.notes = new MetroFramework.Controls.MetroTextBox();
            this.subject = new MetroFramework.Controls.MetroTextBox();
            this.from_to = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.add_post_button = new MetroFramework.Controls.MetroButton();
            this.book_type = new System.Windows.Forms.ComboBox();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.book_number = new MetroFramework.Controls.MetroTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.select_button = new MetroFramework.Controls.MetroButton();
            this.scan_button = new MetroFramework.Controls.MetroButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.Location = new System.Drawing.Point(362, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "تعديل البريد";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.metroComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.metroComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.Location = new System.Drawing.Point(50, 352);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(563, 37);
            this.metroComboBox1.TabIndex = 87;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // book_date
            // 
            this.book_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.book_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.book_date.Location = new System.Drawing.Point(50, 192);
            this.book_date.Name = "book_date";
            this.book_date.Size = new System.Drawing.Size(563, 30);
            this.book_date.TabIndex = 86;
            // 
            // notes
            // 
            this.notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.notes.CustomButton.Image = null;
            this.notes.CustomButton.Location = new System.Drawing.Point(475, 2);
            this.notes.CustomButton.Name = "";
            this.notes.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.notes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.notes.CustomButton.TabIndex = 1;
            this.notes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.notes.CustomButton.UseSelectable = true;
            this.notes.CustomButton.Visible = false;
            this.notes.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.notes.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.notes.Lines = new string[0];
            this.notes.Location = new System.Drawing.Point(51, 408);
            this.notes.MaxLength = 32767;
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.PasswordChar = '\0';
            this.notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notes.SelectedText = "";
            this.notes.SelectionLength = 0;
            this.notes.SelectionStart = 0;
            this.notes.ShortcutsEnabled = true;
            this.notes.Size = new System.Drawing.Size(563, 90);
            this.notes.TabIndex = 85;
            this.notes.UseSelectable = true;
            this.notes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.notes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // subject
            // 
            this.subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.subject.CustomButton.Image = null;
            this.subject.CustomButton.Location = new System.Drawing.Point(516, 2);
            this.subject.CustomButton.Name = "";
            this.subject.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.subject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subject.CustomButton.TabIndex = 1;
            this.subject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subject.CustomButton.UseSelectable = true;
            this.subject.CustomButton.Visible = false;
            this.subject.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.subject.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.subject.Lines = new string[0];
            this.subject.Location = new System.Drawing.Point(50, 296);
            this.subject.MaxLength = 32767;
            this.subject.Name = "subject";
            this.subject.PasswordChar = '\0';
            this.subject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subject.SelectedText = "";
            this.subject.SelectionLength = 0;
            this.subject.SelectionStart = 0;
            this.subject.ShortcutsEnabled = true;
            this.subject.Size = new System.Drawing.Size(564, 50);
            this.subject.TabIndex = 84;
            this.subject.UseSelectable = true;
            this.subject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // from_to
            // 
            this.from_to.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.from_to.CustomButton.Image = null;
            this.from_to.CustomButton.Location = new System.Drawing.Point(516, 2);
            this.from_to.CustomButton.Name = "";
            this.from_to.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.from_to.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.from_to.CustomButton.TabIndex = 1;
            this.from_to.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.from_to.CustomButton.UseSelectable = true;
            this.from_to.CustomButton.Visible = false;
            this.from_to.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.from_to.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.from_to.Lines = new string[0];
            this.from_to.Location = new System.Drawing.Point(50, 240);
            this.from_to.MaxLength = 32767;
            this.from_to.Name = "from_to";
            this.from_to.PasswordChar = '\0';
            this.from_to.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.from_to.SelectedText = "";
            this.from_to.SelectionLength = 0;
            this.from_to.SelectionStart = 0;
            this.from_to.ShortcutsEnabled = true;
            this.from_to.Size = new System.Drawing.Size(564, 50);
            this.from_to.TabIndex = 83;
            this.from_to.UseSelectable = true;
            this.from_to.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.from_to.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Location = new System.Drawing.Point(641, 126);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(232, 50);
            this.metroTile1.TabIndex = 88;
            this.metroTile1.Text = ": رقم الكتاب";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile2.Location = new System.Drawing.Point(641, 184);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(232, 50);
            this.metroTile2.TabIndex = 89;
            this.metroTile2.Text = ": التاريخ";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile3.Location = new System.Drawing.Point(641, 240);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(232, 50);
            this.metroTile3.TabIndex = 90;
            this.metroTile3.Text = ": من / الى";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile4.Location = new System.Drawing.Point(641, 296);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(232, 50);
            this.metroTile4.TabIndex = 91;
            this.metroTile4.Text = ": موضوع الكتاب";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile5.Location = new System.Drawing.Point(641, 352);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(232, 50);
            this.metroTile5.TabIndex = 92;
            this.metroTile5.Text = ": نوع الصادر / الاستلام";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile5.UseSelectable = true;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile6.Location = new System.Drawing.Point(641, 408);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(232, 50);
            this.metroTile6.TabIndex = 93;
            this.metroTile6.Text = ": الملاحظات";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile6.UseSelectable = true;
            // 
            // add_post_button
            // 
            this.add_post_button.AllowDrop = true;
            this.add_post_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_post_button.AutoSize = true;
            this.add_post_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_post_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_post_button.BackgroundImage")));
            this.add_post_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_post_button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.add_post_button.ForeColor = System.Drawing.Color.White;
            this.add_post_button.Location = new System.Drawing.Point(66, 736);
            this.add_post_button.Name = "add_post_button";
            this.add_post_button.Size = new System.Drawing.Size(547, 65);
            this.add_post_button.TabIndex = 94;
            this.add_post_button.Text = "تعديل";
            this.add_post_button.UseSelectable = true;
            this.add_post_button.Click += new System.EventHandler(this.add_post_button_Click);
            // 
            // book_type
            // 
            this.book_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.book_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_type.FormattingEnabled = true;
            this.book_type.Location = new System.Drawing.Point(51, 74);
            this.book_type.Name = "book_type";
            this.book_type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.book_type.Size = new System.Drawing.Size(562, 33);
            this.book_type.TabIndex = 95;
            this.book_type.SelectedIndexChanged += new System.EventHandler(this.book_type_SelectedIndexChanged);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile7.Location = new System.Drawing.Point(641, 74);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(232, 45);
            this.metroTile7.TabIndex = 96;
            this.metroTile7.Text = ": نوع الكتاب";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTile7.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile7.UseSelectable = true;
            // 
            // book_number
            // 
            this.book_number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.book_number.CustomButton.Image = null;
            this.book_number.CustomButton.Location = new System.Drawing.Point(516, 2);
            this.book_number.CustomButton.Name = "";
            this.book_number.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.book_number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.book_number.CustomButton.TabIndex = 1;
            this.book_number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.book_number.CustomButton.UseSelectable = true;
            this.book_number.CustomButton.Visible = false;
            this.book_number.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.book_number.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.book_number.Lines = new string[0];
            this.book_number.Location = new System.Drawing.Point(49, 126);
            this.book_number.MaxLength = 32767;
            this.book_number.Name = "book_number";
            this.book_number.PasswordChar = '\0';
            this.book_number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.book_number.SelectedText = "";
            this.book_number.SelectionLength = 0;
            this.book_number.SelectionStart = 0;
            this.book_number.ShortcutsEnabled = true;
            this.book_number.Size = new System.Drawing.Size(564, 50);
            this.book_number.TabIndex = 97;
            this.book_number.UseSelectable = true;
            this.book_number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.book_number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 597);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 30);
            this.dateTimePicker1.TabIndex = 105;
            this.dateTimePicker1.Visible = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(259, 561);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(54, 20);
            this.metroLabel11.TabIndex = 104;
            this.metroLabel11.Text = ": المبلغ";
            this.metroLabel11.Visible = false;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(66, 561);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(187, 30);
            this.metroTextBox3.TabIndex = 103;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.Visible = false;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox3.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(338, 561);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(164, 30);
            this.metroTextBox1.TabIndex = 102;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.Visible = false;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(504, 597);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(93, 20);
            this.metroLabel10.TabIndex = 101;
            this.metroLabel10.Text = ": تاريخ الوصل";
            this.metroLabel10.Visible = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(508, 561);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(89, 20);
            this.metroLabel9.TabIndex = 100;
            this.metroLabel9.Text = ": رقم الوصل ";
            this.metroLabel9.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(422, 514);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 35);
            this.radioButton2.TabIndex = 99;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "وصل";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(528, 514);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 35);
            this.radioButton1.TabIndex = 98;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "مذكرة";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // select_button
            // 
            this.select_button.AllowDrop = true;
            this.select_button.AutoSize = true;
            this.select_button.BackColor = System.Drawing.Color.White;
            this.select_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select_button.BackgroundImage")));
            this.select_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.select_button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.select_button.ForeColor = System.Drawing.Color.Maroon;
            this.select_button.Location = new System.Drawing.Point(66, 645);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(196, 62);
            this.select_button.TabIndex = 107;
            this.select_button.Text = "اختر ملف";
            this.select_button.UseSelectable = true;
            this.select_button.Visible = false;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // scan_button
            // 
            this.scan_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scan_button.AutoSize = true;
            this.scan_button.BackColor = System.Drawing.Color.White;
            this.scan_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scan_button.BackgroundImage")));
            this.scan_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scan_button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.scan_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scan_button.Location = new System.Drawing.Point(279, 645);
            this.scan_button.Name = "scan_button";
            this.scan_button.Size = new System.Drawing.Size(335, 62);
            this.scan_button.TabIndex = 106;
            this.scan_button.Text = "البدء بعملية المسح الضوئي";
            this.scan_button.UseSelectable = true;
            this.scan_button.Visible = false;
            this.scan_button.Click += new System.EventHandler(this.scan_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(692, 659);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 30);
            this.checkBox1.TabIndex = 108;
            this.checkBox1.Text = "تبديل الملف";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.BackColor = System.Drawing.Color.Turquoise;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(641, 475);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(232, 54);
            this.metroButton1.TabIndex = 109;
            this.metroButton1.Text = "افتح الملف";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(7, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 44);
            this.label4.TabIndex = 113;
            this.label4.Text = "*";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 44);
            this.label3.TabIndex = 112;
            this.label3.Text = "*";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 44);
            this.label2.TabIndex = 111;
            this.label2.Text = "*";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(7, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 44);
            this.label1.TabIndex = 110;
            this.label1.Text = "*";
            this.label1.Visible = false;
            // 
            // update_book_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 824);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.scan_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.book_number);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.book_type);
            this.Controls.Add(this.add_post_button);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.book_date);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.from_to);
            this.Controls.Add(this.metroLabel1);
            this.Name = "update_book_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.update_book_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox metroComboBox1;
        private System.Windows.Forms.DateTimePicker book_date;
        private MetroFramework.Controls.MetroTextBox notes;
        private MetroFramework.Controls.MetroTextBox subject;
        private MetroFramework.Controls.MetroTextBox from_to;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroButton add_post_button;
        private System.Windows.Forms.ComboBox book_type;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTextBox book_number;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private MetroFramework.Controls.MetroButton select_button;
        private MetroFramework.Controls.MetroButton scan_button;
        private System.Windows.Forms.CheckBox checkBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}