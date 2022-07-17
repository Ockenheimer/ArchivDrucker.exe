using Microsoft.VisualBasic;
namespace WinFormsApp1
{

    public class NumberStore
    {


        private long number;

        public NumberStore(long number)
        {

            this.number = number;
        }

        public long GetNumber()
        {
            return number;
        }

        public void SetNumber(long value)
        {
            number = value;
        }

        public void addieren()
        {
            number++;
        }

        public void subtrahieren()
        {
            number--;
        }
    }
}