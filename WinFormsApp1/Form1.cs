using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace ArchivDrucker
{
    public partial class Form1 : Form
    {
        public NumberStore printNumber;

        public Form1()
        {
            long x = 1234;
            InitializeComponent();
            printNumber = new NumberStore(x);
            Aktualisieren();
        }

        private void Aktualisieren()
        {
            textBox1.Text = printNumber.GetNumber().ToString();
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            printNumber.subtrahieren();
            Aktualisieren();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            printNumber.addieren();
            Aktualisieren();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            using (var form = new Form2(printNumber.GetNumber()))
            {
                form.ShowDialog();
                printNumber.SetNumber((long)form.FileNumber);
                Aktualisieren();
            }


        }
    }
}
