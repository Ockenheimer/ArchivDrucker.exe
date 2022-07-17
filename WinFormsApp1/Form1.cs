using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private NumberStore printNumber;

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
            //ShowDialog();
            
            printNumber.SetNumber((long)(Interaction.DialogBox("Was zum Fick!")));
        }
        //public void ShowMyDialogBox()
        //{
        //    Form2 testDialog = new Form2();

        //    // Show testDialog as a modal dialog and determine if DialogResult = OK.
        //    if (testDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        // Read the contents of testDialog's TextBox.
        //        this.txtResult.Text = testDialog.TextBox1.Text;
        //    }
        //    else
        //    {
        //        this.txtResult.Text = "Cancelled";
        //    }
        //    testDialog.Dispose();
        //}
    }
}
