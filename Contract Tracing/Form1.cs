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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            StreamWriter output = new StreamWriter(Application.StartupPath + "\\forms\\" + "output.txt");
            output.WriteLine(name.Text + ":" + " " + first_name.Text + last_name.Text);
            output.WriteLine();
            output.WriteLine(ageLabel.Text + ":" + " " + age.Text);
            output.WriteLine();
            output.WriteLine(emailLabel.Text + ":" + " " + email.Text);
            output.WriteLine();
            output.WriteLine(addressLabel.Text + ":" + " " + address.Text);
            output.WriteLine();
            output.WriteLine(contactLabel.Text + ":" + " " + contact_number.Text);
            output.WriteLine();
            output.WriteLine(dateLabel.Text + ":" + " " + date.Text);
            output.WriteLine();
            output.WriteLine(timeLabel.Text + ":" + " " + time.Text);
            output.WriteLine();
            output.WriteLine(bodytempLabel.Text + ":" + " " + body_temp.Text);

            output.Close();
            this.Hide();

            Form2 form2 = new Form2();
            form2.ShowDialog();





        }
    }
}
