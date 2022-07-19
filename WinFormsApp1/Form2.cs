using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArchivDrucker
{
  

    public partial class Form2 : Form
    {
        public long FileNumber { get; set; }

        public Form2(long x)
        {
            InitializeComponent();
            FileNumber = x;
            textBoxNumber1.Text = FileNumber.ToString();
            this.ActiveControl = textBoxNumber1;
            
        }


        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forged in the fires of Mount Doom." + System.Environment.NewLine + "They are bringing the hobbits to Isengard!", "GANDALF!!!!!");
        }

        private long check()
        {
            String speicher = textBoxNumber1.Text;

            try
            {
                long checker = (long)Convert.ToDouble(speicher);
                return checker;
            }
            catch
            {
                MessageBox.Show("Bitte erfassen Sie eine Zahl.", "Fehler");
                return 0;

            }
        }


        private void buttonSet2_Click(object sender, EventArgs e)
        {
            FileNumber = check();
            this.Close();
        }
    }
}
