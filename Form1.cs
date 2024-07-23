using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ToDoStudy
{
    public partial class Form1 : Form
    {
        bool mouseDown;
        private Point offset;
        Cursor cursor_light = new Cursor("default_cursor_light.ico");
        Cursor cursor_dark = new Cursor("default_cursor_dark.ico");
        Image minimize_light = Image.FromFile("minimize.png");
        Image minimize_dark = Image.FromFile("minimize(1).png");
        Image close_light = Image.FromFile("close_light.png");
        Image close_dark = Image.FromFile("close_dark.png");
        Image search_light = Image.FromFile("search_light.png");
        Image search_dark = Image.FromFile("search_dark.png");
        Image plus_light = Image.FromFile("plus_light.png");
        Image plus_dark = Image.FromFile("plus_dark.png");
        Image pencil_light = Image.FromFile("pencil_light.png");
        Image pencil_dark = Image.FromFile("pencil_dark.png");
        Image trash_light = Image.FromFile("trash_light.png");
        Image trash_dark = Image.FromFile("trash_dark.png");
        Image home_light = Image.FromFile("home_light.png");
        Image home_dark = Image.FromFile("home_dark.png");
        Image wiki_light = Image.FromFile("wiki_light.png");
        Image wiki_dark = Image.FromFile("wiki_dark.png");
        Image todo_light = Image.FromFile("todo_light(1).png");
        Image todo_dark = Image.FromFile("todo_dark(2).png");
        Image timetable_light = Image.FromFile("timetable_light.png");
        Image timetable_dark = Image.FromFile("timetable_dark.png");
        Image calendar_light = Image.FromFile("calendar_light.png");
        Image calendar_dark = Image.FromFile("calendar_dark.png");
        Image notes_light = Image.FromFile("notes_light.png");
        Image notes_dark = Image.FromFile("notes_dark.png");
        Image tomato_light = Image.FromFile("tomato_light.png");
        Image tomato_dark = Image.FromFile("tomato_dark.png");
        Image music_light = Image.FromFile("music_light.png");
        Image music_dark = Image.FromFile("music_dark.png");
        Image calculator_light = Image.FromFile("calculator_light(1).png");
        Image calculator_dark = Image.FromFile("calculator_dark(1).png");
        Image book_light = Image.FromFile("book_light.png");
        Image book_dark = Image.FromFile("book_dark.png");
        SoundPlayer page_flip1 = new SoundPlayer("page_flip1.wav");
        SoundPlayer page_flip2 = new SoundPlayer("page_flip2.wav");
        SoundPlayer page_flip3 = new SoundPlayer("page_flip3.wav");
        SoundPlayer page_flip4 = new SoundPlayer("page_flip4.wav");
        public Form1()
        {
            InitializeComponent();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.BackgroundImage = minimize_light;
            minimizeButton.BackgroundImageLayout = ImageLayout.Stretch;
            this.Cursor = cursor_light;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackgroundImage = minimize_dark;
            minimizeButton.BackgroundImageLayout= ImageLayout.Stretch;
            this.Cursor = cursor_dark;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackgroundImage = close_light;
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            this.Cursor = cursor_light;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackgroundImage = close_dark;
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            this.Cursor = cursor_dark;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = cursor_light;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = cursor_dark;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = cursor_dark;
            timer1.Start();

            infoButton.Show();
            toDoList1.Hide();
            timetable1.Hide();
            calendar1.Hide();
            notes1.Hide();
            pomodoroTechnique1.Hide();
            calculator1.Hide();
            wikipediaSearch1.Hide();
            focusSounds1.Hide();
            gradeBook1.Hide();
        }

        private void controlBox_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = cursor_light;
        }

        private void controlBox_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = cursor_dark;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = cursor_light;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = cursor_dark;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = cursor_light;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = cursor_dark;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("T");
        }

        private void wikipedia_searchButton_Click(object sender, EventArgs e)
        {
            page_flip4.Play();

            infoButton.Hide();
            toDoList1.Hide();
            timetable1.Hide();
            calendar1.Hide();
            notes1.Hide();
            pomodoroTechnique1.Hide();

            wikipediaSearch1.Show();
            wikipediaSearch1.BringToFront();

            focusSounds1.Hide();
            gradeBook1.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            page_flip1.Play();

            infoButton.Show();
            toDoList1.Hide();
            timetable1.Hide();
            calendar1.Hide();
            notes1.Hide();
            pomodoroTechnique1.Hide();
            calculator1.Hide();
            wikipediaSearch1.Hide();
            focusSounds1.Hide();
            gradeBook1.Hide();
        }

        private void todolistButton_Click(object sender, EventArgs e)
        {
            page_flip2.Play();

            infoButton.Hide();

            toDoList1.Show();
            toDoList1.BringToFront();

            timetable1.Hide();
            calendar1.Hide();
            notes1.Hide();
            pomodoroTechnique1.Hide();
            calculator1.Hide();
            wikipediaSearch1.Hide();
            focusSounds1.Hide();
            gradeBook1.Hide();
        }

        private void homeButton_Enter(object sender, EventArgs e)
        {
            homeButton.BackgroundImage = home_dark;
            homeButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void homeButton_Leave(object sender, EventArgs e)
        {
            homeButton.BackgroundImage = home_light;
            homeButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void wikipedia_searchButton_Enter(object sender, EventArgs e)
        {
            wikipedia_searchButton.BackgroundImage = wiki_dark;
            wikipedia_searchButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void wikipedia_searchButton_Leave(object sender, EventArgs e)
        {
            wikipedia_searchButton.BackgroundImage = wiki_light;
            wikipedia_searchButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void todolistButton_Enter(object sender, EventArgs e)
        {
            todolistButton.BackgroundImage = todo_dark;
            todolistButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void todolistButton_Leave(object sender, EventArgs e)
        {
            todolistButton.BackgroundImage = todo_light;
            todolistButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void timetableButton_Enter(object sender, EventArgs e)
        {
            timetableButton.BackgroundImage = timetable_dark;
            timetableButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void timetableButton_Leave(object sender, EventArgs e)
        {
            timetableButton.BackgroundImage = timetable_light;
            timetableButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void calendarButton_Enter(object sender, EventArgs e)
        {
            calendarButton.BackgroundImage = calendar_dark;
            calendarButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void calendarButton_Leave(object sender, EventArgs e)
        {
            calendarButton.BackgroundImage = calendar_light;
            calendarButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void notesButton_Enter(object sender, EventArgs e)
        {
            notesButton.BackgroundImage = notes_dark;
            notesButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void notesButton_Leave(object sender, EventArgs e)
        {
            notesButton.BackgroundImage = notes_light;
            notesButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pomodoro_techniqueButton_Enter(object sender, EventArgs e)
        {
            pomodoro_techniqueButton.BackgroundImage = tomato_dark;
            pomodoro_techniqueButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pomodoro_techniqueButton_Leave(object sender, EventArgs e)
        {
            pomodoro_techniqueButton.BackgroundImage = tomato_light;
            pomodoro_techniqueButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void focus_soundsButton_Enter(object sender, EventArgs e)
        {
            focus_soundsButton.BackgroundImage = music_dark;
            focus_soundsButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void focus_soundsButton_Leave(object sender, EventArgs e)
        {
            focus_soundsButton.BackgroundImage = music_light;
            focus_soundsButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void calculatorButton_Enter(object sender, EventArgs e)
        {
            calculatorButton.BackgroundImage = calculator_dark;
            calculatorButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void calculatorButton_Leave(object sender, EventArgs e)
        {
            calculatorButton.BackgroundImage = calculator_light;
            calculatorButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void timetableButton_Click(object sender, EventArgs e)
        {
            page_flip3.Play();

            infoButton.Hide();
            toDoList1.Hide();

            timetable1.Show();
            timetable1.BringToFront();

            calendar1.Hide();
            notes1.Hide();
            pomodoroTechnique1.Hide();
            calculator1.Hide();
            wikipediaSearch1.Hide();
            focusSounds1.Hide();
            gradeBook1.Hide();
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            page_flip4.Play();

            infoButton.Hide();
            toDoList1.Hide();
            timetable1.Hide();

            calendar1.Show();
            calendar1.BringToFront();

            notes1.Hide();
            pomodoroTechnique1.Hide();
            calculator1.Hide();
            wikipediaSearch1.Hide();
            focusSounds1.Hide();
            gradeBook1.Hide();
        }

        private void notesButton_Click(object sender, EventArgs e)
        {
            page_flip1.Play();

            infoButton.Hide();
            toDoList1.Hide();
            timetable1.Hide();
            calendar1.Hide();

            notes1.Show();
            notes1.BringToFront();

            pomodoroTechnique1.Hide();
            calculator1.Hide();
            wikipediaSearch1.Hide();
            focusSounds1.Hide();
            gradeBook1.Hide();
        }

        private void pomodoro_techniqueButton_Click(object sender, EventArgs e)
        {
            page_flip2.Play();

            infoButton.Hide();
            toDoList1.Hide();
            timetable1.Hide();
            calendar1.Hide();
            notes1.Hide();

            pomodoroTechnique1.Show();
            pomodoroTechnique1.BringToFront();

            calculator1.Hide();
            wikipediaSearch1.Hide();
            focusSounds1.Hide();
            gradeBook1.Hide();
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            page_flip3.Play();

            infoButton.Hide();
            toDoList1.Hide();
            timetable1.Hide();
            calendar1.Hide();
            notes1.Hide();
            pomodoroTechnique1.Hide();

            calculator1.Show();
            calculator1.BringToFront();

            wikipediaSearch1.Hide();
            focusSounds1.Hide();
            gradeBook1.Hide();
        }

        private void focus_soundsButton_Click(object sender, EventArgs e)
        {
            page_flip1.Play();

            infoButton.Hide();
            toDoList1.Hide();
            timetable1.Hide();
            calendar1.Hide();
            notes1.Hide();
            pomodoroTechnique1.Hide(); 
            calculator1.Hide();
            wikipediaSearch1.Hide();

            focusSounds1.Show();
            focusSounds1.BringToFront();

            gradeBook1.Hide();
        }

        private void grade_bookButton_Enter(object sender, EventArgs e)
        {
            grade_bookButton.BackgroundImage = book_dark;
            grade_bookButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void grade_bookButton_Leave(object sender, EventArgs e)
        {
            grade_bookButton.BackgroundImage = book_light;
            grade_bookButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void grade_bookButton_Click(object sender, EventArgs e)
        {
            page_flip2.Play();

            infoButton.Hide();
            toDoList1.Hide();
            timetable1.Hide();
            calendar1.Hide();
            notes1.Hide();
            pomodoroTechnique1.Hide();
            calculator1.Hide();
            wikipediaSearch1.Hide();
            focusSounds1.Hide();

            gradeBook1.Show();
            gradeBook1.BringToFront();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Form3 infoForm = new Form3();
            infoForm.Show();
        }
    }
}
