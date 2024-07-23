namespace ToDoStudy
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlBox = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.optionBox = new System.Windows.Forms.Panel();
            this.grade_bookButton = new System.Windows.Forms.Button();
            this.calculatorButton = new System.Windows.Forms.Button();
            this.wikipedia_searchButton = new System.Windows.Forms.Button();
            this.focus_soundsButton = new System.Windows.Forms.Button();
            this.pomodoro_techniqueButton = new System.Windows.Forms.Button();
            this.notesButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.timetableButton = new System.Windows.Forms.Button();
            this.todolistButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mottoLabel = new System.Windows.Forms.Label();
            this.clockLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.wikipediaSearch1 = new ToDoStudy.WikipediaSearch();
            this.toDoList1 = new ToDoStudy.ToDoList();
            this.timetable1 = new ToDoStudy.Timetable();
            this.calendar1 = new ToDoStudy.Calendar();
            this.notes1 = new ToDoStudy.Notes();
            this.pomodoroTechnique1 = new ToDoStudy.PomodoroTechnique();
            this.calculator1 = new ToDoStudy.Calculator();
            this.focusSounds1 = new ToDoStudy.FocusSounds();
            this.gradeBook1 = new ToDoStudy.GradeBook();
            this.infoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.optionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.controlBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // controlBox
            // 
            this.controlBox.Controls.Add(this.closeButton);
            this.controlBox.Controls.Add(this.minimizeButton);
            this.controlBox.Location = new System.Drawing.Point(468, 0);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(60, 32);
            this.controlBox.TabIndex = 2;
            this.controlBox.MouseEnter += new System.EventHandler(this.controlBox_MouseEnter);
            this.controlBox.MouseLeave += new System.EventHandler(this.controlBox_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(36, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 21);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(3, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(27, 23);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.minimizeButton_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(29, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ToDoStudy";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // optionBox
            // 
            this.optionBox.BackColor = System.Drawing.Color.Transparent;
            this.optionBox.Controls.Add(this.grade_bookButton);
            this.optionBox.Controls.Add(this.calculatorButton);
            this.optionBox.Controls.Add(this.wikipedia_searchButton);
            this.optionBox.Controls.Add(this.focus_soundsButton);
            this.optionBox.Controls.Add(this.pomodoro_techniqueButton);
            this.optionBox.Controls.Add(this.notesButton);
            this.optionBox.Controls.Add(this.calendarButton);
            this.optionBox.Controls.Add(this.timetableButton);
            this.optionBox.Controls.Add(this.todolistButton);
            this.optionBox.Controls.Add(this.homeButton);
            this.optionBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionBox.Location = new System.Drawing.Point(0, 32);
            this.optionBox.Name = "optionBox";
            this.optionBox.Size = new System.Drawing.Size(79, 556);
            this.optionBox.TabIndex = 1;
            // 
            // grade_bookButton
            // 
            this.grade_bookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grade_bookButton.BackgroundImage")));
            this.grade_bookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grade_bookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grade_bookButton.ForeColor = System.Drawing.Color.Transparent;
            this.grade_bookButton.Location = new System.Drawing.Point(12, 501);
            this.grade_bookButton.Name = "grade_bookButton";
            this.grade_bookButton.Size = new System.Drawing.Size(55, 49);
            this.grade_bookButton.TabIndex = 9;
            this.grade_bookButton.UseVisualStyleBackColor = true;
            this.grade_bookButton.Click += new System.EventHandler(this.grade_bookButton_Click);
            this.grade_bookButton.Enter += new System.EventHandler(this.grade_bookButton_Enter);
            this.grade_bookButton.Leave += new System.EventHandler(this.grade_bookButton_Leave);
            // 
            // calculatorButton
            // 
            this.calculatorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calculatorButton.BackgroundImage")));
            this.calculatorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculatorButton.ForeColor = System.Drawing.Color.Transparent;
            this.calculatorButton.Location = new System.Drawing.Point(12, 336);
            this.calculatorButton.Name = "calculatorButton";
            this.calculatorButton.Size = new System.Drawing.Size(55, 49);
            this.calculatorButton.TabIndex = 8;
            this.calculatorButton.UseVisualStyleBackColor = true;
            this.calculatorButton.Click += new System.EventHandler(this.calculatorButton_Click);
            this.calculatorButton.Enter += new System.EventHandler(this.calculatorButton_Enter);
            this.calculatorButton.Leave += new System.EventHandler(this.calculatorButton_Leave);
            // 
            // wikipedia_searchButton
            // 
            this.wikipedia_searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wikipedia_searchButton.BackgroundImage")));
            this.wikipedia_searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wikipedia_searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wikipedia_searchButton.ForeColor = System.Drawing.Color.Transparent;
            this.wikipedia_searchButton.Location = new System.Drawing.Point(12, 391);
            this.wikipedia_searchButton.Name = "wikipedia_searchButton";
            this.wikipedia_searchButton.Size = new System.Drawing.Size(55, 49);
            this.wikipedia_searchButton.TabIndex = 7;
            this.wikipedia_searchButton.UseVisualStyleBackColor = true;
            this.wikipedia_searchButton.Click += new System.EventHandler(this.wikipedia_searchButton_Click);
            this.wikipedia_searchButton.Enter += new System.EventHandler(this.wikipedia_searchButton_Enter);
            this.wikipedia_searchButton.Leave += new System.EventHandler(this.wikipedia_searchButton_Leave);
            // 
            // focus_soundsButton
            // 
            this.focus_soundsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("focus_soundsButton.BackgroundImage")));
            this.focus_soundsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.focus_soundsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.focus_soundsButton.ForeColor = System.Drawing.Color.Transparent;
            this.focus_soundsButton.Location = new System.Drawing.Point(12, 446);
            this.focus_soundsButton.Name = "focus_soundsButton";
            this.focus_soundsButton.Size = new System.Drawing.Size(55, 49);
            this.focus_soundsButton.TabIndex = 6;
            this.focus_soundsButton.UseVisualStyleBackColor = true;
            this.focus_soundsButton.Click += new System.EventHandler(this.focus_soundsButton_Click);
            this.focus_soundsButton.Enter += new System.EventHandler(this.focus_soundsButton_Enter);
            this.focus_soundsButton.Leave += new System.EventHandler(this.focus_soundsButton_Leave);
            // 
            // pomodoro_techniqueButton
            // 
            this.pomodoro_techniqueButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pomodoro_techniqueButton.BackgroundImage")));
            this.pomodoro_techniqueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pomodoro_techniqueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pomodoro_techniqueButton.ForeColor = System.Drawing.Color.Transparent;
            this.pomodoro_techniqueButton.Location = new System.Drawing.Point(12, 281);
            this.pomodoro_techniqueButton.Name = "pomodoro_techniqueButton";
            this.pomodoro_techniqueButton.Size = new System.Drawing.Size(55, 49);
            this.pomodoro_techniqueButton.TabIndex = 5;
            this.pomodoro_techniqueButton.UseVisualStyleBackColor = true;
            this.pomodoro_techniqueButton.Click += new System.EventHandler(this.pomodoro_techniqueButton_Click);
            this.pomodoro_techniqueButton.Enter += new System.EventHandler(this.pomodoro_techniqueButton_Enter);
            this.pomodoro_techniqueButton.Leave += new System.EventHandler(this.pomodoro_techniqueButton_Leave);
            // 
            // notesButton
            // 
            this.notesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notesButton.BackgroundImage")));
            this.notesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notesButton.ForeColor = System.Drawing.Color.Transparent;
            this.notesButton.Location = new System.Drawing.Point(12, 226);
            this.notesButton.Name = "notesButton";
            this.notesButton.Size = new System.Drawing.Size(55, 49);
            this.notesButton.TabIndex = 4;
            this.notesButton.UseVisualStyleBackColor = true;
            this.notesButton.Click += new System.EventHandler(this.notesButton_Click);
            this.notesButton.Enter += new System.EventHandler(this.notesButton_Enter);
            this.notesButton.Leave += new System.EventHandler(this.notesButton_Leave);
            // 
            // calendarButton
            // 
            this.calendarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calendarButton.BackgroundImage")));
            this.calendarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarButton.ForeColor = System.Drawing.Color.Transparent;
            this.calendarButton.Location = new System.Drawing.Point(12, 171);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(55, 49);
            this.calendarButton.TabIndex = 3;
            this.calendarButton.UseVisualStyleBackColor = true;
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            this.calendarButton.Enter += new System.EventHandler(this.calendarButton_Enter);
            this.calendarButton.Leave += new System.EventHandler(this.calendarButton_Leave);
            // 
            // timetableButton
            // 
            this.timetableButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("timetableButton.BackgroundImage")));
            this.timetableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timetableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timetableButton.ForeColor = System.Drawing.Color.Transparent;
            this.timetableButton.Location = new System.Drawing.Point(12, 116);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(55, 49);
            this.timetableButton.TabIndex = 2;
            this.timetableButton.UseVisualStyleBackColor = true;
            this.timetableButton.Click += new System.EventHandler(this.timetableButton_Click);
            this.timetableButton.Enter += new System.EventHandler(this.timetableButton_Enter);
            this.timetableButton.Leave += new System.EventHandler(this.timetableButton_Leave);
            // 
            // todolistButton
            // 
            this.todolistButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("todolistButton.BackgroundImage")));
            this.todolistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.todolistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todolistButton.ForeColor = System.Drawing.Color.Transparent;
            this.todolistButton.Location = new System.Drawing.Point(12, 61);
            this.todolistButton.Name = "todolistButton";
            this.todolistButton.Size = new System.Drawing.Size(55, 49);
            this.todolistButton.TabIndex = 1;
            this.todolistButton.UseVisualStyleBackColor = true;
            this.todolistButton.Click += new System.EventHandler(this.todolistButton_Click);
            this.todolistButton.Enter += new System.EventHandler(this.todolistButton_Enter);
            this.todolistButton.Leave += new System.EventHandler(this.todolistButton_Leave);
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.Color.Transparent;
            this.homeButton.Location = new System.Drawing.Point(12, 6);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(55, 49);
            this.homeButton.TabIndex = 0;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.Enter += new System.EventHandler(this.homeButton_Enter);
            this.homeButton.Leave += new System.EventHandler(this.homeButton_Leave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(80, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 559);
            this.label2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(165, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 220);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // mottoLabel
            // 
            this.mottoLabel.AutoSize = true;
            this.mottoLabel.BackColor = System.Drawing.Color.Transparent;
            this.mottoLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.mottoLabel.ForeColor = System.Drawing.Color.DimGray;
            this.mottoLabel.Location = new System.Drawing.Point(184, 258);
            this.mottoLabel.Name = "mottoLabel";
            this.mottoLabel.Size = new System.Drawing.Size(239, 19);
            this.mottoLabel.TabIndex = 4;
            this.mottoLabel.Text = "~ your minimalist productivity app ~\r\n";
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.BackColor = System.Drawing.Color.Transparent;
            this.clockLabel.Font = new System.Drawing.Font("Comic Sans MS", 36.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clockLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.clockLabel.Location = new System.Drawing.Point(192, 333);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(240, 69);
            this.clockLabel.TabIndex = 5;
            this.clockLabel.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(61, 356);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(241, 203);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(370, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(155, 129);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // wikipediaSearch1
            // 
            this.wikipediaSearch1.BackColor = System.Drawing.Color.Transparent;
            this.wikipediaSearch1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.wikipediaSearch1.Location = new System.Drawing.Point(83, 35);
            this.wikipediaSearch1.Margin = new System.Windows.Forms.Padding(4);
            this.wikipediaSearch1.Name = "wikipediaSearch1";
            this.wikipediaSearch1.Size = new System.Drawing.Size(445, 553);
            this.wikipediaSearch1.TabIndex = 9;
            // 
            // toDoList1
            // 
            this.toDoList1.BackColor = System.Drawing.Color.Transparent;
            this.toDoList1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.toDoList1.Location = new System.Drawing.Point(83, 32);
            this.toDoList1.Margin = new System.Windows.Forms.Padding(4);
            this.toDoList1.Name = "toDoList1";
            this.toDoList1.Size = new System.Drawing.Size(445, 527);
            this.toDoList1.TabIndex = 10;
            // 
            // timetable1
            // 
            this.timetable1.BackColor = System.Drawing.Color.Transparent;
            this.timetable1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.timetable1.Location = new System.Drawing.Point(83, 32);
            this.timetable1.Margin = new System.Windows.Forms.Padding(4);
            this.timetable1.Name = "timetable1";
            this.timetable1.Size = new System.Drawing.Size(445, 527);
            this.timetable1.TabIndex = 11;
            // 
            // calendar1
            // 
            this.calendar1.BackColor = System.Drawing.Color.Transparent;
            this.calendar1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.calendar1.Location = new System.Drawing.Point(83, 32);
            this.calendar1.Margin = new System.Windows.Forms.Padding(4);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(445, 527);
            this.calendar1.TabIndex = 12;
            // 
            // notes1
            // 
            this.notes1.BackColor = System.Drawing.Color.Transparent;
            this.notes1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.notes1.Location = new System.Drawing.Point(83, 32);
            this.notes1.Margin = new System.Windows.Forms.Padding(4);
            this.notes1.Name = "notes1";
            this.notes1.Size = new System.Drawing.Size(445, 527);
            this.notes1.TabIndex = 13;
            // 
            // pomodoroTechnique1
            // 
            this.pomodoroTechnique1.BackColor = System.Drawing.Color.Transparent;
            this.pomodoroTechnique1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pomodoroTechnique1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.pomodoroTechnique1.Location = new System.Drawing.Point(83, 32);
            this.pomodoroTechnique1.Margin = new System.Windows.Forms.Padding(4);
            this.pomodoroTechnique1.Name = "pomodoroTechnique1";
            this.pomodoroTechnique1.Size = new System.Drawing.Size(445, 527);
            this.pomodoroTechnique1.TabIndex = 14;
            // 
            // calculator1
            // 
            this.calculator1.BackColor = System.Drawing.Color.Transparent;
            this.calculator1.Location = new System.Drawing.Point(84, 32);
            this.calculator1.Name = "calculator1";
            this.calculator1.Size = new System.Drawing.Size(445, 527);
            this.calculator1.TabIndex = 15;
            // 
            // focusSounds1
            // 
            this.focusSounds1.BackColor = System.Drawing.Color.Transparent;
            this.focusSounds1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.focusSounds1.Location = new System.Drawing.Point(84, 32);
            this.focusSounds1.Margin = new System.Windows.Forms.Padding(4);
            this.focusSounds1.Name = "focusSounds1";
            this.focusSounds1.Size = new System.Drawing.Size(445, 527);
            this.focusSounds1.TabIndex = 16;
            // 
            // gradeBook1
            // 
            this.gradeBook1.BackColor = System.Drawing.Color.Transparent;
            this.gradeBook1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gradeBook1.Location = new System.Drawing.Point(83, 32);
            this.gradeBook1.Margin = new System.Windows.Forms.Padding(4);
            this.gradeBook1.Name = "gradeBook1";
            this.gradeBook1.Size = new System.Drawing.Size(445, 577);
            this.gradeBook1.TabIndex = 17;
            // 
            // infoButton
            // 
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoButton.Location = new System.Drawing.Point(490, 539);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(35, 43);
            this.infoButton.TabIndex = 18;
            this.infoButton.Text = "?";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 588);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.mottoLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.optionBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.wikipediaSearch1);
            this.Controls.Add(this.toDoList1);
            this.Controls.Add(this.timetable1);
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.notes1);
            this.Controls.Add(this.pomodoroTechnique1);
            this.Controls.Add(this.calculator1);
            this.Controls.Add(this.focusSounds1);
            this.Controls.Add(this.gradeBook1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoStudy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.optionBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel controlBox;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel optionBox;
        private System.Windows.Forms.Button wikipedia_searchButton;
        private System.Windows.Forms.Button focus_soundsButton;
        private System.Windows.Forms.Button pomodoro_techniqueButton;
        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Button timetableButton;
        private System.Windows.Forms.Button todolistButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label mottoLabel;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private WikipediaSearch wikipediaSearch1;
        private ToDoList toDoList1;
        private System.Windows.Forms.Button calculatorButton;
        private Timetable timetable1;
        private Calendar calendar1;
        private Notes notes1;
        private PomodoroTechnique pomodoroTechnique1;
        private Calculator calculator1;
        private FocusSounds focusSounds1;
        private System.Windows.Forms.Button grade_bookButton;
        private GradeBook gradeBook1;
        private System.Windows.Forms.Button infoButton;
    }
}

