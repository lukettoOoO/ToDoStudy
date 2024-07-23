namespace ToDoStudy
{
    partial class WikipediaSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WikipediaSearch));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wiki_searchButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchbox_errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Look it up...";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // wiki_searchButton
            // 
            this.wiki_searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wiki_searchButton.BackgroundImage")));
            this.wiki_searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wiki_searchButton.FlatAppearance.BorderSize = 0;
            this.wiki_searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wiki_searchButton.Location = new System.Drawing.Point(322, 278);
            this.wiki_searchButton.Name = "wiki_searchButton";
            this.wiki_searchButton.Size = new System.Drawing.Size(33, 32);
            this.wiki_searchButton.TabIndex = 2;
            this.wiki_searchButton.UseVisualStyleBackColor = true;
            this.wiki_searchButton.Click += new System.EventHandler(this.wiki_searchButton_Click);
            this.wiki_searchButton.MouseEnter += new System.EventHandler(this.wiki_searchButton_MouseEnter);
            this.wiki_searchButton.MouseLeave += new System.EventHandler(this.wiki_searchButton_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 352);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(445, 224);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // searchbox_errorLabel
            // 
            this.searchbox_errorLabel.AutoSize = true;
            this.searchbox_errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchbox_errorLabel.Location = new System.Drawing.Point(104, 249);
            this.searchbox_errorLabel.Name = "searchbox_errorLabel";
            this.searchbox_errorLabel.Size = new System.Drawing.Size(0, 18);
            this.searchbox_errorLabel.TabIndex = 4;
            // 
            // WikipediaSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.searchbox_errorLabel);
            this.Controls.Add(this.wiki_searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WikipediaSearch";
            this.Size = new System.Drawing.Size(444, 559);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button wiki_searchButton;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label searchbox_errorLabel;
    }
}
