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
        // FileNumber speichert Aktennummer und macht sie für Form1 abrufbar
        public long FileNumber { get; set; }

        public Form2(long x)
        {
            InitializeComponent();
            // x wird von Form 1 übergeben
            FileNumber = x;
            // Textbox zeigt aktuelle Zahl an
            textBoxNumber1.Text = FileNumber.ToString();
            // Textbox erhält Fokus zum direkten Schreiben
            this.ActiveControl = textBoxNumber1;
            
        }


        private void Label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forged in the fires of Mount Doom." + System.Environment.NewLine + "They are bringing the hobbits to Isengard!", "GANDALF!!!!!");
        }


        //Prüfe ob die Nutzereingabe eine Zhal ist, die nach Long umgewandelt werden kann
        private long Check()
        {
            // Schnapp dir den Text aus der Textbox
            String speicher = textBoxNumber1.Text;

            try
            {   // wenn es ein long ist, wandel es um und gib die Zahl zurück
                long checker = (long)Convert.ToDouble(speicher);
                return checker;
            }
            catch
            {
                // So nicht Freundchen!
                MessageBox.Show("Bitte erfassen Sie eine Zahl.", "Fehler");
                return FileNumber;

            }
        }


        private void ButtonSet2_Click(object sender, EventArgs e)
        {
            // ersatze FileNumber mit Wert der Nutzereingabe
            FileNumber = Check();
            // Mach das Ding zu
            this.Close();
        }

        private void ButtonAbort2_Click(object sender, EventArgs e)
        {
            // Mach das Ding zu
            this.Close();
        }
    }
}
