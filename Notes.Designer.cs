namespace ToDoStudy
{
    partial class Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.label1 = new System.Windows.Forms.Label();
            this.noteBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.wordCount_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.charCount_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.deleteNote = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openNote = new System.Windows.Forms.ToolStripButton();
            this.saveNote = new System.Windows.Forms.ToolStripButton();
            this.saveAsNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutNote = new System.Windows.Forms.ToolStripButton();
            this.copyNote = new System.Windows.Forms.ToolStripButton();
            this.pasteNote = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.deleteFormattingNote = new System.Windows.Forms.ToolStripButton();
            this.boldNote = new System.Windows.Forms.ToolStripButton();
            this.italicNote = new System.Windows.Forms.ToolStripButton();
            this.underlineNote = new System.Windows.Forms.ToolStripButton();
            this.strikethroughNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.undoNote = new System.Windows.Forms.ToolStripButton();
            this.redoNote = new System.Windows.Forms.ToolStripButton();
            this.textStyle_comboBox = new System.Windows.Forms.ComboBox();
            this.list_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.blueNote = new System.Windows.Forms.PictureBox();
            this.greenNote = new System.Windows.Forms.PictureBox();
            this.yellowNote = new System.Windows.Forms.PictureBox();
            this.redNote = new System.Windows.Forms.PictureBox();
            this.purpleNote = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DK Business As Usual", 53.24999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Notes:";
            // 
            // noteBox
            // 
            this.noteBox.BackColor = System.Drawing.Color.LightYellow;
            this.noteBox.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.noteBox.Location = new System.Drawing.Point(24, 159);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(400, 318);
            this.noteBox.TabIndex = 2;
            this.noteBox.Text = "";
            this.noteBox.TextChanged += new System.EventHandler(this.noteBox_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordCount_Label,
            this.charCount_Label});
            this.statusStrip1.Location = new System.Drawing.Point(24, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(175, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // wordCount_Label
            // 
            this.wordCount_Label.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wordCount_Label.Name = "wordCount_Label";
            this.wordCount_Label.Size = new System.Drawing.Size(65, 17);
            this.wordCount_Label.Text = "~0 words~";
            // 
            // charCount_Label
            // 
            this.charCount_Label.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.charCount_Label.Name = "charCount_Label";
            this.charCount_Label.Size = new System.Drawing.Size(93, 17);
            this.charCount_Label.Text = "~0 characters~";
            // 
            // deleteNote
            // 
            this.deleteNote.BackColor = System.Drawing.Color.Transparent;
            this.deleteNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteNote.BackgroundImage")));
            this.deleteNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNote.ForeColor = System.Drawing.Color.Transparent;
            this.deleteNote.Location = new System.Drawing.Point(24, 91);
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(31, 30);
            this.deleteNote.TabIndex = 12;
            this.deleteNote.Text = "&DeleteAll";
            this.deleteNote.UseVisualStyleBackColor = false;
            this.deleteNote.Click += new System.EventHandler(this.deleteNote_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNote,
            this.saveNote,
            this.saveAsNote,
            this.toolStripSeparator,
            this.cutNote,
            this.copyNote,
            this.pasteNote});
            this.toolStrip1.Location = new System.Drawing.Point(67, 96);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(147, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openNote
            // 
            this.openNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openNote.Image = ((System.Drawing.Image)(resources.GetObject("openNote.Image")));
            this.openNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openNote.Name = "openNote";
            this.openNote.Size = new System.Drawing.Size(23, 22);
            this.openNote.Text = "&Open";
            this.openNote.Click += new System.EventHandler(this.openNote_Click);
            // 
            // saveNote
            // 
            this.saveNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveNote.Image = ((System.Drawing.Image)(resources.GetObject("saveNote.Image")));
            this.saveNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveNote.Name = "saveNote";
            this.saveNote.Size = new System.Drawing.Size(23, 22);
            this.saveNote.Text = "&Save";
            this.saveNote.Click += new System.EventHandler(this.saveNote_Click);
            // 
            // saveAsNote
            // 
            this.saveAsNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsNote.Image = ((System.Drawing.Image)(resources.GetObject("saveAsNote.Image")));
            this.saveAsNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsNote.Name = "saveAsNote";
            this.saveAsNote.Size = new System.Drawing.Size(23, 22);
            this.saveAsNote.Text = "&SaveAs";
            this.saveAsNote.Click += new System.EventHandler(this.saveAsNote_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutNote
            // 
            this.cutNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutNote.Image = ((System.Drawing.Image)(resources.GetObject("cutNote.Image")));
            this.cutNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutNote.Name = "cutNote";
            this.cutNote.Size = new System.Drawing.Size(23, 22);
            this.cutNote.Text = "C&ut";
            this.cutNote.Click += new System.EventHandler(this.cutNote_Click);
            // 
            // copyNote
            // 
            this.copyNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyNote.Image = ((System.Drawing.Image)(resources.GetObject("copyNote.Image")));
            this.copyNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyNote.Name = "copyNote";
            this.copyNote.Size = new System.Drawing.Size(23, 22);
            this.copyNote.Text = "&Copy";
            this.copyNote.Click += new System.EventHandler(this.copyNote_Click);
            // 
            // pasteNote
            // 
            this.pasteNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteNote.Image = ((System.Drawing.Image)(resources.GetObject("pasteNote.Image")));
            this.pasteNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteNote.Name = "pasteNote";
            this.pasteNote.Size = new System.Drawing.Size(23, 22);
            this.pasteNote.Text = "&Paste";
            this.pasteNote.Click += new System.EventHandler(this.pasteNote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(50, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(217, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "|";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip2.BackgroundImage")));
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFormattingNote,
            this.boldNote,
            this.italicNote,
            this.underlineNote,
            this.strikethroughNote,
            this.toolStripSeparator1,
            this.undoNote,
            this.redoNote});
            this.toolStrip2.Location = new System.Drawing.Point(235, 95);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(170, 25);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // deleteFormattingNote
            // 
            this.deleteFormattingNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteFormattingNote.Image = ((System.Drawing.Image)(resources.GetObject("deleteFormattingNote.Image")));
            this.deleteFormattingNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteFormattingNote.Name = "deleteFormattingNote";
            this.deleteFormattingNote.Size = new System.Drawing.Size(23, 22);
            this.deleteFormattingNote.Text = "toolStripButton1";
            this.deleteFormattingNote.Click += new System.EventHandler(this.deleteFormattingNote_Click);
            // 
            // boldNote
            // 
            this.boldNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldNote.Image = ((System.Drawing.Image)(resources.GetObject("boldNote.Image")));
            this.boldNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldNote.Name = "boldNote";
            this.boldNote.Size = new System.Drawing.Size(23, 22);
            this.boldNote.Text = "toolStripButton2";
            this.boldNote.Click += new System.EventHandler(this.boldNote_Click);
            // 
            // italicNote
            // 
            this.italicNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicNote.Image = ((System.Drawing.Image)(resources.GetObject("italicNote.Image")));
            this.italicNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicNote.Name = "italicNote";
            this.italicNote.Size = new System.Drawing.Size(23, 22);
            this.italicNote.Text = "toolStripButton3";
            this.italicNote.Click += new System.EventHandler(this.italicNote_Click);
            // 
            // underlineNote
            // 
            this.underlineNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineNote.Image = ((System.Drawing.Image)(resources.GetObject("underlineNote.Image")));
            this.underlineNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineNote.Name = "underlineNote";
            this.underlineNote.Size = new System.Drawing.Size(23, 22);
            this.underlineNote.Text = "toolStripButton4";
            this.underlineNote.Click += new System.EventHandler(this.underlineNote_Click);
            // 
            // strikethroughNote
            // 
            this.strikethroughNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.strikethroughNote.Image = ((System.Drawing.Image)(resources.GetObject("strikethroughNote.Image")));
            this.strikethroughNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strikethroughNote.Name = "strikethroughNote";
            this.strikethroughNote.Size = new System.Drawing.Size(23, 22);
            this.strikethroughNote.Text = "toolStripButton5";
            this.strikethroughNote.Click += new System.EventHandler(this.strikethroughNote_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // undoNote
            // 
            this.undoNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoNote.Image = ((System.Drawing.Image)(resources.GetObject("undoNote.Image")));
            this.undoNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoNote.Name = "undoNote";
            this.undoNote.Size = new System.Drawing.Size(23, 22);
            this.undoNote.Text = "toolStripButton6";
            this.undoNote.Click += new System.EventHandler(this.undoNote_Click);
            // 
            // redoNote
            // 
            this.redoNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoNote.Image = ((System.Drawing.Image)(resources.GetObject("redoNote.Image")));
            this.redoNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoNote.Name = "redoNote";
            this.redoNote.Size = new System.Drawing.Size(23, 22);
            this.redoNote.Text = "toolStripButton7";
            this.redoNote.Click += new System.EventHandler(this.redoNote_Click);
            // 
            // textStyle_comboBox
            // 
            this.textStyle_comboBox.FormattingEnabled = true;
            this.textStyle_comboBox.Items.AddRange(new object[] {
            "Title",
            "Header",
            "Subtitle",
            "Body",
            "Monospaced"});
            this.textStyle_comboBox.Location = new System.Drawing.Point(24, 128);
            this.textStyle_comboBox.Name = "textStyle_comboBox";
            this.textStyle_comboBox.Size = new System.Drawing.Size(121, 26);
            this.textStyle_comboBox.TabIndex = 17;
            this.textStyle_comboBox.Text = "Text Style";
            this.textStyle_comboBox.SelectedIndexChanged += new System.EventHandler(this.textStyle_comboBox_SelectedIndexChanged);
            // 
            // list_comboBox
            // 
            this.list_comboBox.FormattingEnabled = true;
            this.list_comboBox.Items.AddRange(new object[] {
            "●",
            "○",
            "■",
            "☐",
            "★",
            "❥",
            "➽",
            "▶",
            "▷"});
            this.list_comboBox.Location = new System.Drawing.Point(154, 128);
            this.list_comboBox.Name = "list_comboBox";
            this.list_comboBox.Size = new System.Drawing.Size(60, 26);
            this.list_comboBox.TabIndex = 18;
            this.list_comboBox.Text = "List";
            this.list_comboBox.SelectedIndexChanged += new System.EventHandler(this.list_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(142, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(211, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "|";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(223, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // blueNote
            // 
            this.blueNote.BackColor = System.Drawing.Color.Transparent;
            this.blueNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blueNote.BackgroundImage")));
            this.blueNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueNote.Location = new System.Drawing.Point(254, 129);
            this.blueNote.Name = "blueNote";
            this.blueNote.Size = new System.Drawing.Size(25, 25);
            this.blueNote.TabIndex = 22;
            this.blueNote.TabStop = false;
            this.blueNote.Click += new System.EventHandler(this.blueNote_Click);
            // 
            // greenNote
            // 
            this.greenNote.BackColor = System.Drawing.Color.Transparent;
            this.greenNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("greenNote.BackgroundImage")));
            this.greenNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenNote.Location = new System.Drawing.Point(285, 129);
            this.greenNote.Name = "greenNote";
            this.greenNote.Size = new System.Drawing.Size(25, 25);
            this.greenNote.TabIndex = 23;
            this.greenNote.TabStop = false;
            this.greenNote.Click += new System.EventHandler(this.greenNote_Click);
            // 
            // yellowNote
            // 
            this.yellowNote.BackColor = System.Drawing.Color.Transparent;
            this.yellowNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yellowNote.BackgroundImage")));
            this.yellowNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowNote.Location = new System.Drawing.Point(316, 129);
            this.yellowNote.Name = "yellowNote";
            this.yellowNote.Size = new System.Drawing.Size(25, 25);
            this.yellowNote.TabIndex = 24;
            this.yellowNote.TabStop = false;
            this.yellowNote.Click += new System.EventHandler(this.yellowNote_Click);
            // 
            // redNote
            // 
            this.redNote.BackColor = System.Drawing.Color.Transparent;
            this.redNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redNote.BackgroundImage")));
            this.redNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redNote.Location = new System.Drawing.Point(347, 129);
            this.redNote.Name = "redNote";
            this.redNote.Size = new System.Drawing.Size(25, 25);
            this.redNote.TabIndex = 25;
            this.redNote.TabStop = false;
            this.redNote.Click += new System.EventHandler(this.redNote_Click);
            // 
            // purpleNote
            // 
            this.purpleNote.BackColor = System.Drawing.Color.Transparent;
            this.purpleNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("purpleNote.BackgroundImage")));
            this.purpleNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purpleNote.Location = new System.Drawing.Point(378, 129);
            this.purpleNote.Name = "purpleNote";
            this.purpleNote.Size = new System.Drawing.Size(25, 25);
            this.purpleNote.TabIndex = 26;
            this.purpleNote.TabStop = false;
            this.purpleNote.Click += new System.EventHandler(this.purpleNote_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(313, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 36);
            this.label6.TabIndex = 27;
            this.label6.Text = "~Open/Edit any \r\n.rtf or .txt file~";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(278, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 43);
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(408, 79);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(34, 39);
            this.pictureBox8.TabIndex = 29;
            this.pictureBox8.TabStop = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.BackColor = System.Drawing.Color.Transparent;
            this.locationLabel.ForeColor = System.Drawing.Color.DimGray;
            this.locationLabel.Location = new System.Drawing.Point(30, 503);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(0, 18);
            this.locationLabel.TabIndex = 30;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.purpleNote);
            this.Controls.Add(this.redNote);
            this.Controls.Add(this.yellowNote);
            this.Controls.Add(this.greenNote);
            this.Controls.Add(this.blueNote);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.list_comboBox);
            this.Controls.Add(this.textStyle_comboBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteNote);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notes";
            this.Size = new System.Drawing.Size(445, 527);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox noteBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel wordCount_Label;
        private System.Windows.Forms.ToolStripStatusLabel charCount_Label;
        private System.Windows.Forms.Button deleteNote;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openNote;
        private System.Windows.Forms.ToolStripButton saveNote;
        private System.Windows.Forms.ToolStripButton saveAsNote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutNote;
        private System.Windows.Forms.ToolStripButton copyNote;
        private System.Windows.Forms.ToolStripButton pasteNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton deleteFormattingNote;
        private System.Windows.Forms.ToolStripButton boldNote;
        private System.Windows.Forms.ToolStripButton italicNote;
        private System.Windows.Forms.ToolStripButton underlineNote;
        private System.Windows.Forms.ToolStripButton strikethroughNote;
        private System.Windows.Forms.ComboBox textStyle_comboBox;
        private System.Windows.Forms.ComboBox list_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox blueNote;
        private System.Windows.Forms.PictureBox greenNote;
        private System.Windows.Forms.PictureBox yellowNote;
        private System.Windows.Forms.PictureBox redNote;
        private System.Windows.Forms.PictureBox purpleNote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton undoNote;
        private System.Windows.Forms.ToolStripButton redoNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label locationLabel;
    }
}
