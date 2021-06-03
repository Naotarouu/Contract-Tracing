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

namespace Contract_Tracing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            StreamReader outputFile = new StreamReader(Application.StartupPath + "\\forms\\" + "output.txt");
            richTextBox1.Text = outputFile.ReadToEnd();

            outputFile.Close();
        }
    }
}
