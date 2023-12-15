using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassSystemManager
{
    public partial class Form1 : Form
    {
        private bool _display=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 215, 210);
            toolStrip1.BackColor = Color.FromArgb(206, 171, 159);
            panel2.BackColor = Color.FromArgb(174, 201, 222);
            button1.BackColor= Color.FromArgb(224, 224, 224);
            button2.BackColor = Color.FromArgb(224, 224, 224);

        }


    }
}
