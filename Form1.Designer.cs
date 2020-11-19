namespace OOPLab2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonLinq = new System.Windows.Forms.RadioButton();
            this.radioButtonSax = new System.Windows.Forms.RadioButton();
            this.radioButtonDom = new System.Windows.Forms.RadioButton();
            this.artistCheckBox = new System.Windows.Forms.CheckBox();
            this.albumCheckBox = new System.Windows.Forms.CheckBox();
            this.yearCheckBox = new System.Windows.Forms.CheckBox();
            this.genreCheckBox = new System.Windows.Forms.CheckBox();
            this.durationCheckBox = new System.Windows.Forms.CheckBox();
            this.likesCheckBox = new System.Windows.Forms.CheckBox();
            this.playsCheckBox = new System.Windows.Forms.CheckBox();
            this.outputRich = new System.Windows.Forms.RichTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.toHTMLButton = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.artistBox = new System.Windows.Forms.ComboBox();
            this.albumBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.durationBox = new System.Windows.Forms.ComboBox();
            this.likesBox = new System.Windows.Forms.ComboBox();
            this.playsBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // radioButtonLinq
            // 
            this.radioButtonLinq.AutoSize = true;
            this.radioButtonLinq.Location = new System.Drawing.Point(77, 322);
            this.radioButtonLinq.Name = "radioButtonLinq";
            this.radioButtonLinq.Size = new System.Drawing.Size(61, 21);
            this.radioButtonLinq.TabIndex = 0;
            this.radioButtonLinq.TabStop = true;
            this.radioButtonLinq.Text = "LINQ";
            this.radioButtonLinq.UseVisualStyleBackColor = true;
            // 
            // radioButtonSax
            // 
            this.radioButtonSax.AutoSize = true;
            this.radioButtonSax.Location = new System.Drawing.Point(185, 322);
            this.radioButtonSax.Name = "radioButtonSax";
            this.radioButtonSax.Size = new System.Drawing.Size(56, 21);
            this.radioButtonSax.TabIndex = 1;
            this.radioButtonSax.TabStop = true;
            this.radioButtonSax.Text = "SAX";
            this.radioButtonSax.UseVisualStyleBackColor = true;
            // 
            // radioButtonDom
            // 
            this.radioButtonDom.AutoSize = true;
            this.radioButtonDom.Location = new System.Drawing.Point(302, 322);
            this.radioButtonDom.Name = "radioButtonDom";
            this.radioButtonDom.Size = new System.Drawing.Size(61, 21);
            this.radioButtonDom.TabIndex = 2;
            this.radioButtonDom.TabStop = true;
            this.radioButtonDom.Text = "DOM";
            this.radioButtonDom.UseVisualStyleBackColor = true;
            // 
            // artistCheckBox
            // 
            this.artistCheckBox.AutoSize = true;
            this.artistCheckBox.Location = new System.Drawing.Point(32, 33);
            this.artistCheckBox.Name = "artistCheckBox";
            this.artistCheckBox.Size = new System.Drawing.Size(62, 21);
            this.artistCheckBox.TabIndex = 3;
            this.artistCheckBox.Text = "Artist";
            this.artistCheckBox.UseVisualStyleBackColor = true;
            this.artistCheckBox.Click += new System.EventHandler(this.artistCheckBox_Click);
            // 
            // albumCheckBox
            // 
            this.albumCheckBox.AutoSize = true;
            this.albumCheckBox.Location = new System.Drawing.Point(32, 66);
            this.albumCheckBox.Name = "albumCheckBox";
            this.albumCheckBox.Size = new System.Drawing.Size(69, 21);
            this.albumCheckBox.TabIndex = 4;
            this.albumCheckBox.Text = "Album";
            this.albumCheckBox.UseVisualStyleBackColor = true;
            this.albumCheckBox.Click += new System.EventHandler(this.albumCheckBox_Click);
            // 
            // yearCheckBox
            // 
            this.yearCheckBox.AutoSize = true;
            this.yearCheckBox.Location = new System.Drawing.Point(32, 95);
            this.yearCheckBox.Name = "yearCheckBox";
            this.yearCheckBox.Size = new System.Drawing.Size(60, 21);
            this.yearCheckBox.TabIndex = 5;
            this.yearCheckBox.Text = "Year";
            this.yearCheckBox.UseVisualStyleBackColor = true;
            this.yearCheckBox.Click += new System.EventHandler(this.yearCheckBox_Click);
            // 
            // genreCheckBox
            // 
            this.genreCheckBox.AutoSize = true;
            this.genreCheckBox.Location = new System.Drawing.Point(32, 126);
            this.genreCheckBox.Name = "genreCheckBox";
            this.genreCheckBox.Size = new System.Drawing.Size(70, 21);
            this.genreCheckBox.TabIndex = 6;
            this.genreCheckBox.Text = "Genre";
            this.genreCheckBox.UseVisualStyleBackColor = true;
            this.genreCheckBox.Click += new System.EventHandler(this.genreCheckBox_Click);
            // 
            // durationCheckBox
            // 
            this.durationCheckBox.AutoSize = true;
            this.durationCheckBox.Location = new System.Drawing.Point(32, 155);
            this.durationCheckBox.Name = "durationCheckBox";
            this.durationCheckBox.Size = new System.Drawing.Size(84, 21);
            this.durationCheckBox.TabIndex = 7;
            this.durationCheckBox.Text = "Duration";
            this.durationCheckBox.UseVisualStyleBackColor = true;
            this.durationCheckBox.Click += new System.EventHandler(this.durationCheckBox_Click);
            // 
            // likesCheckBox
            // 
            this.likesCheckBox.AutoSize = true;
            this.likesCheckBox.Location = new System.Drawing.Point(31, 186);
            this.likesCheckBox.Name = "likesCheckBox";
            this.likesCheckBox.Size = new System.Drawing.Size(63, 21);
            this.likesCheckBox.TabIndex = 8;
            this.likesCheckBox.Text = "Likes";
            this.likesCheckBox.UseVisualStyleBackColor = true;
            this.likesCheckBox.Click += new System.EventHandler(this.likesCheckBox_Click);
            // 
            // playsCheckBox
            // 
            this.playsCheckBox.AutoSize = true;
            this.playsCheckBox.Location = new System.Drawing.Point(30, 216);
            this.playsCheckBox.Name = "playsCheckBox";
            this.playsCheckBox.Size = new System.Drawing.Size(64, 21);
            this.playsCheckBox.TabIndex = 9;
            this.playsCheckBox.Text = "Plays";
            this.playsCheckBox.UseVisualStyleBackColor = true;
            this.playsCheckBox.Click += new System.EventHandler(this.playsCheckBox_Click);
            // 
            // outputRich
            // 
            this.outputRich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputRich.Location = new System.Drawing.Point(463, 12);
            this.outputRich.Name = "outputRich";
            this.outputRich.ReadOnly = true;
            this.outputRich.Size = new System.Drawing.Size(325, 426);
            this.outputRich.TabIndex = 10;
            this.outputRich.Text = "";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(77, 372);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(134, 48);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // toHTMLButton
            // 
            this.toHTMLButton.Location = new System.Drawing.Point(229, 372);
            this.toHTMLButton.Name = "toHTMLButton";
            this.toHTMLButton.Size = new System.Drawing.Size(134, 48);
            this.toHTMLButton.TabIndex = 12;
            this.toHTMLButton.Text = "To HTML";
            this.toHTMLButton.UseVisualStyleBackColor = true;
            this.toHTMLButton.Click += new System.EventHandler(this.toHTMLButton_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(286, 114);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(134, 48);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // artistBox
            // 
            this.artistBox.Enabled = false;
            this.artistBox.FormattingEnabled = true;
            this.artistBox.Location = new System.Drawing.Point(129, 33);
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(121, 24);
            this.artistBox.TabIndex = 14;
            // 
            // albumBox
            // 
            this.albumBox.Enabled = false;
            this.albumBox.FormattingEnabled = true;
            this.albumBox.Location = new System.Drawing.Point(129, 63);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(121, 24);
            this.albumBox.TabIndex = 15;
            // 
            // yearBox
            // 
            this.yearBox.Enabled = false;
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(129, 93);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(121, 24);
            this.yearBox.TabIndex = 16;
            // 
            // genreBox
            // 
            this.genreBox.Enabled = false;
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(129, 123);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(121, 24);
            this.genreBox.TabIndex = 17;
            // 
            // durationBox
            // 
            this.durationBox.Enabled = false;
            this.durationBox.FormattingEnabled = true;
            this.durationBox.Location = new System.Drawing.Point(129, 153);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(121, 24);
            this.durationBox.TabIndex = 18;
            // 
            // likesBox
            // 
            this.likesBox.Enabled = false;
            this.likesBox.FormattingEnabled = true;
            this.likesBox.Location = new System.Drawing.Point(129, 183);
            this.likesBox.Name = "likesBox";
            this.likesBox.Size = new System.Drawing.Size(121, 24);
            this.likesBox.TabIndex = 19;
            // 
            // playsBox
            // 
            this.playsBox.Enabled = false;
            this.playsBox.FormattingEnabled = true;
            this.playsBox.Location = new System.Drawing.Point(129, 213);
            this.playsBox.Name = "playsBox";
            this.playsBox.Size = new System.Drawing.Size(121, 24);
            this.playsBox.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playsBox);
            this.Controls.Add(this.likesBox);
            this.Controls.Add(this.durationBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.artistBox);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.toHTMLButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.outputRich);
            this.Controls.Add(this.playsCheckBox);
            this.Controls.Add(this.likesCheckBox);
            this.Controls.Add(this.durationCheckBox);
            this.Controls.Add(this.genreCheckBox);
            this.Controls.Add(this.yearCheckBox);
            this.Controls.Add(this.albumCheckBox);
            this.Controls.Add(this.artistCheckBox);
            this.Controls.Add(this.radioButtonDom);
            this.Controls.Add(this.radioButtonSax);
            this.Controls.Add(this.radioButtonLinq);
            this.Name = "MainForm";
            this.Text = "Lab2 - Audio Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonLinq;
        private System.Windows.Forms.RadioButton radioButtonSax;
        private System.Windows.Forms.RadioButton radioButtonDom;
        private System.Windows.Forms.CheckBox artistCheckBox;
        private System.Windows.Forms.CheckBox albumCheckBox;
        private System.Windows.Forms.CheckBox yearCheckBox;
        private System.Windows.Forms.CheckBox genreCheckBox;
        private System.Windows.Forms.CheckBox durationCheckBox;
        private System.Windows.Forms.CheckBox likesCheckBox;
        private System.Windows.Forms.CheckBox playsCheckBox;
        private System.Windows.Forms.RichTextBox outputRich;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button toHTMLButton;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ComboBox artistBox;
        private System.Windows.Forms.ComboBox albumBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.ComboBox durationBox;
        private System.Windows.Forms.ComboBox likesBox;
        private System.Windows.Forms.ComboBox playsBox;
    }
}

