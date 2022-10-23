using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_Windows_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Title = "Open new text";
            OPF.Filter = "Formats(*.log,*.txt)|*.txt;*.log";
            if (OPF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(OPF.FileName, Encoding.Default);
                this.Text = "New file" + OPF.FileName;
            } 

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saxla = new SaveFileDialog();
            saxla.Title = "Faylı saxla";
            saxla.Filter = "Mətn faylları(.txt)|.txt";

            if (saxla.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saxla.FileName, textBox1.Text, Encoding.Default);
                this.Text = "Saxlanılan:" + saxla.FileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saxla = new SaveFileDialog();
            saxla.Title = "Faylı saxla";
            saxla.Filter = "Mətn faylları(.txt)|.txt";
            if (saxla.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saxla.FileName, textBox1.Text, Encoding.Default);
                this.Text = "Saxlanılan:" + saxla.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program was closed");
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About haqqinda = new About();
            haqqinda.Show();
            this.Hide();
        }

        private void makeYoursaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FontDialog srift = new FontDialog();

            if (srift.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Font = srift.Font;
            }

        }

        private void backColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog reng = new ColorDialog();
            if (reng.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.BackColor = reng.Color;
            }

            if (textBox1.BackColor == Color.White)
            {
                textBox1.ForeColor = Color.Black;
            }


            if (textBox1.BackColor == Color.Black)
            {
                textBox1.ForeColor = Color.White;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void transparentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 0.70f)
            {
                this.Opacity = 1;
            }
            else
            {
                this.Opacity = 0.70f;
            }
        }

        private void nightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nightToolStripMenuItem_Click(object sender, EventArgs e)
        {

                  
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Silver;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void transparentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 0.70f)
            {
                this.Opacity = 1;
            }
            else
            {
                this.Opacity = 0.70f;
            }
        }
    }
}
