using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity8WordCounter
{
    public partial class WordCounter : Form
    {

        /*Author: Gustavo Marin Borges
         Title: WordCount*/

        public WordCounter()
        {
            InitializeComponent();
        }

        //Enter button.
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            
            int NoNumbers = 0;

            //CheckBox value.
            if (checkBoxNumberExclusion.Checked)
            {
                NoNumbers = DoNotCountNumbers();
            }

            //Tries for extra spaces or the absence of data.
            try
            {
                string xUpper = UpperCase();
                richTextBoxCapitalizeSentence.Text = xUpper;

                labelDisplayNumberOfWords.Text = (WordCounterMethod() + NoNumbers).ToString();

                //Verifies that the average is not negative.
                if ((AverageNumberOfLettersMethod() + NoNumbers) > 0)
                {
                    labelDisplayAvhNumberOfWords.Text = (AverageNumberOfLettersMethod() + NoNumbers).ToString();
                }
                else
                {
                    labelDisplayNumberOfWords.Text = "0";
                    labelDisplayAvhNumberOfWords.Text = "0";
                }
                
            }
            catch
            {
                //Shows error message.
                MessageBox.Show("There is an extra space in your sentence or there is nothing in it.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
         
            
            
        }

        //Method for counting words.
        private int WordCounterMethod()
        {
            string strCount = richTextBoxSentence.Text;
            int count = 0;
            int index = 1;
            char[] delim = null;
            string[] tokens = strCount.Split(delim);
            count = tokens.Length;

           

            return count;
        }

        //Method for not counting numbers.
        private int DoNotCountNumbers()
        {
            string strCount = richTextBoxSentence.Text;
            int count = 0;
            int index = 0;
            int i = 1;
            char[] delim = null;
            string[] tokens = strCount.Split(delim);

            while (index <= (tokens.Length - 1))
            {
                if (tokens[index].StartsWith("0") || tokens[index].EndsWith("0"))
                {
                    count--;
                }
                else if (tokens[index].StartsWith("1") || tokens[index].EndsWith("1"))
                {
                    count--;
                }
                else if (tokens[index].StartsWith("2") || tokens[index].EndsWith("2"))
                {
                    count--;
                }
                else if (tokens[index].StartsWith("3") || tokens[index].EndsWith("3"))
                {
                    count--;
                }
                else if (tokens[index].StartsWith("4") || tokens[index].EndsWith("4"))
                {
                    count--;
                }
                else if (tokens[index].StartsWith("5") || tokens[index].EndsWith("5"))
                {
                    count--;
                }
                else if (tokens[index].StartsWith("6") || tokens[index].EndsWith("6"))
                {
                    count--;
                }
                else if (tokens[index].StartsWith("7") || tokens[index].EndsWith("7"))
                {
                    count--;
                }
                else if (tokens[index].StartsWith("8") || tokens[index].EndsWith("8"))
                {
                    count--;
                }
                else if (tokens[index].StartsWith("9") || tokens[index].EndsWith("9"))
                {
                    count--;
                }
                index++;
            }
            return count;
        }

        //Method that calculates average number of words.
        private double AverageNumberOfLettersMethod()
        {
            string strCount = richTextBoxSentence.Text;
            double Avg = 0;
            int Sum = 0;
            int denominator = 1;

            char[] delim = null;
            string[] tokens = strCount.Split(delim);

            for (int i = 0; i <= tokens.Length -1 ; i++)
            {              
               Sum = Sum + tokens[i].Length;
               denominator++;
            }

            double Sum2 = Convert.ToDouble(Sum);
            Avg = Sum2/ denominator;
            return Avg;
        }

        //Method that turns sentence into first upper letter of each word.
        private string UpperCase()
        {
            string Sum = "";
            
                string strCount = richTextBoxSentence.Text;                
                char[] delim = null;
                string[] tokens = strCount.Split(delim);

                for (int i = 0; i <= tokens.Length - 1; i++)
                {
                    Sum = Sum + tokens[i].Substring(0, 1).ToUpper() + tokens[i].Substring(1) + " ";
                }
                                                      
            return Sum;
        }

        //Exit button.
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clear button.
        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxSentence.Text = "";
            labelDisplayNumberOfWords.Text = "";
            labelDisplayAvhNumberOfWords.Text = "";
            richTextBoxCapitalizeSentence.Text = "";
            checkBoxNumberExclusion.Checked = false;
        }
    }
}
