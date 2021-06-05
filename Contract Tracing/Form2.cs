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

        private void clickShow(object sender, EventArgs e)
        {
            String[] tracing = Directory.GetFiles(".", "Tracing Form *");
            int latest = 0;
            for (int i = 0; i < tracing.Length; i++)
            {
                string tracing_name = tracing[i];
                tracing_name = tracing_name.Replace(".\\Tracing Form ", "");
                tracing_name = tracing_name.Replace(".txt", "");
                int count = int.Parse(tracing_name);

                if (count > latest)
                {
                    latest = count;
                }

            }

            latest += 1;

            StreamReader outputFile = new StreamReader(Application.StartupPath + "\\forms\\" + "Tracing Form " + latest + ".txt");
            richTextBox1.Text = outputFile.ReadToEnd();

            outputFile.Close();
        }
    }
}
