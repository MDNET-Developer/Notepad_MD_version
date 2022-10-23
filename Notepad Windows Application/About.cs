using System;
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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            
            label5.Text = "Notepad is a simple text editor for Microsoft Windows and a basic\r\n" +
                " text-editing program which enables computer users\r\n" +
                " to create documents. It was first released as a mouse-based MS-DOS program in 1983, and has been included in all\r\n" +
                " versions of Microsoft Windows since Windows 1.0 in 1985.";


            label6.Text = "Murad Aliyev. He is a c# programer. He has made different windows application and game.";


            label7.Text = "1.0.0.0.1";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 ok = new Form1();
            ok.Show();
            this.Hide();

        }
    }
}
