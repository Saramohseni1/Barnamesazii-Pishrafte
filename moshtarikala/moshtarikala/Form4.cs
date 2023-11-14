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

namespace moshtarikala
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("moshtari.csv");
            for (int i=0; i<lines.Length; i++)
            {
                listBox1.Items.Add(lines[i]);
            }
        }
    }
}
