using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ArchivDrucker
{
    public partial class Form1 : Form
    {
        public NumberStore printNumber;

        public Form1()
        {
            long x = 66666;
            InitializeComponent();
            printNumber = new NumberStore(x);
            neueZahl();
            Aktualisieren();
        }

        private void Aktualisieren()
        {
            textBox1.Text = printNumber.GetNumber().ToString();
            button3.Select();
        }
        private void Button1_Click(object sender, System.EventArgs e)
        {
            printNumber.subtrahieren();
            Aktualisieren();
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            printNumber.addieren();
            Aktualisieren();
        }

        private void neueZahl()
        {
            Form2 form2 = new Form2(printNumber.GetNumber());
            using Form2 form = form2;
            form.ShowDialog();
            printNumber.SetNumber((long)form.FileNumber);
            Aktualisieren();
        }

        private void Button4_Click(object sender, System.EventArgs e)
        {
            neueZahl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Druckcode gefunden auf Stack Overflow
            //
            // https://stackoverflow.com/questions/7434938/sending-string-directly-to-printer
            //
            string s = textBox1.Text;
            string archiv = "Archiv FA Mainz";
            Font font1 = new Font("Sans Serif", 8);
            Font font2 = new Font("Sans Serif", 55);
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            PaperSize ps = new PaperSize("custom", 141, 700);
    
            PrintDocument p = new PrintDocument();
            p.DefaultPageSettings.PaperSize = ps;
            p.DocumentName = "Archivdruck";
            p.DefaultPageSettings.Landscape = true;           
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(archiv, font1, solidBrush, new RectangleF(35, 15, 350,50));
                //e1.Graphics.DrawString(archiv, font1, solidBrush, new RectangleF(400, 15, 350,50));
                e1.Graphics.DrawString(s, font2, solidBrush, new RectangleF(0, 50, 350,141));
          //      e1.Graphics.DrawString(s, font2, solidBrush, new RectangleF(376, 65, 350,141));
                //e1.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(0, 0, 700, 153));
            };
            try
            {
                p.Print();
                p.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }
    }
}
