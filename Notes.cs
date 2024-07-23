using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDoStudy
{
    public partial class Notes : UserControl
    {
        public Notes()
        {
            InitializeComponent();
        }
        bool saved;
        Color highlighter_Blue = Color.FromArgb(106, 208, 202);
        Color highlighter_Green = Color.FromArgb(107, 213, 154);
        Color highlighter_Yellow = Color.FromArgb(223, 202, 69);
        Color highlighter_Red = Color.FromArgb(222, 136, 141);
        Color highlighter_Purple = Color.FromArgb(176, 121, 171);
        private void deleteNote_Click(object sender, EventArgs e)
        {
            noteBox.Text = "";
        }

        private void openNote_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text Files|*.txt|Rich Text Files|*.rtf";
            if(op.ShowDialog() == DialogResult.OK)
            {
                locationLabel.Text = op.FileName;
                try
                {
                    noteBox.LoadFile(op.FileName);
                }
                catch
                {
                    StreamReader sr = new StreamReader(op.FileName);
                    noteBox.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        private void saveNote_Click(object sender, EventArgs e)
        {
            if(saved == false)
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Rich Text Files|*.rtf";
                sv.AddExtension = true;
                if(sv.ShowDialog() == DialogResult.OK)
                {
                    locationLabel.Text = sv.FileName;
                    noteBox.SaveFile(sv.FileName);
                    saved = true;
                }
            }
            else
            {
                noteBox.SaveFile(locationLabel.Text);
            }
        }

        private void saveAsNote_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Rich Text Files|*.rtf";
            sv.AddExtension = true;
            if (sv.ShowDialog() == DialogResult.OK)
            {
                locationLabel.Text = sv.FileName;
                noteBox.SaveFile(sv.FileName);
                saved = true;
            }
        }

        private void cutNote_Click(object sender, EventArgs e)
        {
            noteBox.Cut();
        }

        private void copyNote_Click(object sender, EventArgs e)
        {
            noteBox.Copy();
        }

        private void pasteNote_Click(object sender, EventArgs e)
        {
            noteBox.Paste();
        }

        private void deleteFormattingNote_Click(object sender, EventArgs e)
        {
            noteBox.SelectionFont = new Font("Comic Sans MS", 10, FontStyle.Regular);
        }

        private void boldNote_Click(object sender, EventArgs e)
        {
            noteBox.SelectionFont = new Font("Comic Sans MS", 10, FontStyle.Bold);
        }

        private void italicNote_Click(object sender, EventArgs e)
        {
            noteBox.SelectionFont = new Font("Comic Sans MS", 10, FontStyle.Italic);
        }

        private void underlineNote_Click(object sender, EventArgs e)
        {
            noteBox.SelectionFont = new Font("Comic Sans MS", 10, FontStyle.Underline);
        }

        private void strikethroughNote_Click(object sender, EventArgs e)
        {
            noteBox.SelectionFont = new Font("Comic Sans MS", 10, FontStyle.Strikeout);
        }

        private void undoNote_Click(object sender, EventArgs e)
        {
            noteBox.Undo();
        }

        private void redoNote_Click(object sender, EventArgs e)
        {
            noteBox.Redo();
        }

        private void textStyle_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textStyle_comboBox.SelectedIndex == 0)
                noteBox.SelectionFont = new Font("Comic Sans MS", 32, FontStyle.Bold);
            if (textStyle_comboBox.SelectedIndex == 1)
                noteBox.SelectionFont = new Font("Comic Sans MS", 17, FontStyle.Bold);
            if (textStyle_comboBox.SelectedIndex == 2)
                noteBox.SelectionFont = new Font("Comic Sans MS", 12, FontStyle.Bold);
            if (textStyle_comboBox.SelectedIndex == 3)
                noteBox.SelectionFont = new Font("Comic Sans MS", 10, FontStyle.Regular);
            if (textStyle_comboBox.SelectedIndex == 4)
                noteBox.SelectionFont = new Font("Lucida Console", 11, FontStyle.Regular);
        }

        private void list_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_comboBox.SelectedIndex == 0)
            {
                noteBox.SelectionLength = 0;
                noteBox.SelectedText = System.Environment.NewLine + "● ";
            }
            if (list_comboBox.SelectedIndex == 1)
            {
                noteBox.SelectionLength = 0;
                noteBox.SelectedText = System.Environment.NewLine + "○ ";
            }
            if (list_comboBox.SelectedIndex == 2)
            {
                noteBox.SelectionLength = 0;
                noteBox.SelectedText = System.Environment.NewLine + "■ ";
            }
            if (list_comboBox.SelectedIndex == 3)
            {
                noteBox.SelectionLength = 0;
                noteBox.SelectedText = System.Environment.NewLine + "☐ ";
            }
            if (list_comboBox.SelectedIndex == 4)
            {
                noteBox.SelectionLength = 0;
                noteBox.SelectedText = System.Environment.NewLine + "★ ";
            }
            if (list_comboBox.SelectedIndex == 5)
            {
                noteBox.SelectionLength = 0;
                noteBox.SelectedText = System.Environment.NewLine + "❥ ";
            }
            if (list_comboBox.SelectedIndex == 6)
            {
                noteBox.SelectionLength = 0;
                noteBox.SelectedText = System.Environment.NewLine + "➽ ";
            }
            if (list_comboBox.SelectedIndex == 7)
            {
                noteBox.SelectionLength = 0;
                noteBox.SelectedText = System.Environment.NewLine + "▶ ";
            }
            if (list_comboBox.SelectedIndex == 8)
            {
                noteBox.SelectionLength = 0;
                noteBox.SelectedText = System.Environment.NewLine + "▷ ";
            }
        }

        private void blueNote_Click(object sender, EventArgs e)
        {
            noteBox.SelectionBackColor = highlighter_Blue;
        }

        private void greenNote_Click(object sender, EventArgs e)
        {
            noteBox.SelectionBackColor = highlighter_Green;
        }

        private void yellowNote_Click(object sender, EventArgs e)
        {
            noteBox.SelectionBackColor = highlighter_Yellow;
        }

        private void redNote_Click(object sender, EventArgs e)
        {
            noteBox.SelectionBackColor = highlighter_Red;
        }

        private void purpleNote_Click(object sender, EventArgs e)
        {
            noteBox.SelectionBackColor = highlighter_Purple;
        }

        private void noteBox_TextChanged(object sender, EventArgs e)
        {
            charCount_Label.Text = "~" + noteBox.Text.Length.ToString() + " characters~";

            int i = 0, k = 0;
            while(i < noteBox.Text.Length)
            {
                if (noteBox.Text[i] == ' ' || noteBox.Text[i] == '\n' || noteBox.Text[i] == '\t')
                    k++;
                i++;
            }
            wordCount_Label.Text ="~" + k.ToString() + " words~";
        }
    }
}
