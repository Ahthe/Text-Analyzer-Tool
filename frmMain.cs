/**
 * Ahthesham Ali Syed 
 * 02/09/2023
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalyzerTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnNumberOfCharacters_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            int numOfChars = input.Length;
            txtOutput.Text = "Number of Characters: " + numOfChars;
        }

        private void btnNumberOfWords_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            int numOfwords = input.Split(' ').Length;
            txtOutput.Text = "Number of Words: " + numOfwords;
        }

        private void btnFileNameAndExtension_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            int indexOfPeriod = input.IndexOf(".");
            if (indexOfPeriod == -1)
            {
                txtOutput.Text = "No periods were found.";
                return;
            }

            string fileName = input.Substring(0, indexOfPeriod);
            string fileExtension = input.Substring(indexOfPeriod + 1);
            txtOutput.Text = "File Name: " + fileName + Environment.NewLine + "File Extension: " + fileExtension;
        }

        private void btnWhatever_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            int numOfVowels = 0;
            for(int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || 
                   c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    numOfVowels++;
                }
            }
            txtOutput.Text = "Number of vowels: " + numOfVowels;
        
        }

        private void btnDownshift_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            txtOutput.Text = input.ToLower();
        }

        private void btnUpshift_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            txtOutput.Text = input.ToUpper();
        }

        private void btnLastCharacter_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            char lastChar = input[input.Length - 1];
            txtOutput.Text = "Last Character: " + lastChar;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
