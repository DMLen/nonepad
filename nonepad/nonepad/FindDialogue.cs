using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nonepad
{
    public partial class FindDialogue : Form
    {
        protected RichTextBox targetTextBox;
        protected int searchPos = 0;
        protected List<int> resultIndexes; //indexes from latest search -- returned by KMP_Find
        protected int idxPos = 0; //current position in result indexes -- to cycle through search results
        public FindDialogue()
        {
            InitializeComponent();
        }

        protected void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {

        }

        protected void matchCaseBox_CheckedChanged(object sender, EventArgs e)
        {
            searchBox_TextChanged(sender, e); //re-run search on case sensitivity change
        }

        protected void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchPos = 0;
            idxPos = 0;
            int[] foundIndexes = KMP_Find(0, targetTextBox.Text, searchBox.Text);
            //select first index if present
            if (foundIndexes.Length > 0)
                            {
                resultIndexes = foundIndexes.ToList();
                selectWord(idxPos);
            }
            else
            {
                resultIndexes = null;
                targetTextBox.Select(0, 0); //clear selection if nothing found
            }
        }

        protected void selectWord(int idxPos) {
            //selectWord(0) == highlight and scroll to first result from search within the editor
            if (resultIndexes != null)
            {
                int foundIndex = resultIndexes[idxPos];
                targetTextBox.Select(foundIndex, searchBox.Text.Length);
                targetTextBox.ScrollToCaret();
            }
        }

        protected void nextButton_Click(object sender, EventArgs e)
        {
            if (resultIndexes != null)
            {
                idxPos = (idxPos + 1) % resultIndexes.Count;
                selectWord(idxPos);
            }
        }

        protected int[] KMP_Find(int startPos, string searchText, string patternText) //KMP string search algorithm
        {//called like KMP_Find(0, "the") //find next instance of the word "the" starting from index 0 of target text box
            if (searchBox.Text == "")
            {
                targetTextBox.Select(0, 0);
                return new int[0]; // return empty array
            }

            List<int> foundIndexes = new List<int>(); //store indexes of pattern occurrences
            int M = patternText.Length;
            int N = searchText.Length; //searchText what we search in -- string patternText is what we search for
            int[] lps = new int[M];
            computeLPS(patternText, M, lps);

            int Pidx = 0; //pattern index, start from beginning
            int Tidx = startPos; //start from given position of text

            while (Tidx < N)
            {
                if (patternText[Pidx] == searchText[Tidx])
                {
                    Pidx++;
                    Tidx++;
                }
                if (Pidx == M)
                {
                    int foundIndex = Tidx - Pidx;
                    foundIndexes.Add(foundIndex); //add to return list
                    System.Diagnostics.Debug.WriteLine("Found pattern at index " + foundIndex);
                    Pidx = lps[Pidx - 1];
                } //look for next match
                else if (Tidx < N && patternText[Pidx] != searchText[Tidx])
                {
                    if (Pidx != 0)
                        Pidx = lps[Pidx - 1];
                    else
                        Tidx++;
                }
            }
            System.Diagnostics.Debug.WriteLine("Total occurrences of pattern found: " + foundIndexes.Count);
            System.Diagnostics.Debug.WriteLine("Occurrences at indexes: " + string.Join(", ", foundIndexes));
            return foundIndexes.ToArray();
        }

        protected void computeLPS(string pattern, int M, int[] lps)
        {
            int len = 0;
            int i = 1;
            lps[0] = 0;

            while (i<M) {
                if (pattern[i] == pattern[len]) {
                    len++;
                    lps[i] = len;
                    i++;}
                else {
                    if (len != 0) {
                        len = lps[len - 1];}
                    else {
                        lps[i] = len;
                        i++;}
                }
            }
        }

        protected void previousButton_Click(object sender, EventArgs e)
        {
            if (resultIndexes != null)
            {
                idxPos = (idxPos - 1 + resultIndexes.Count) % resultIndexes.Count;
                selectWord(idxPos);
            }
        }

        protected void wholeWordsBox_CheckedChanged(object sender, EventArgs e)
        {
            searchBox_TextChanged(sender, e); //re-run search on whole-word change
        }

        protected void HighlightBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void SetTargetTextBox(RichTextBox textBox)
        {
            targetTextBox = textBox;
        }

        protected void FindDialogue_Load(object sender, EventArgs e)
        {

        }

        protected bool isWholeWord(string text, int startIndex, int length)
        {
            //check if chars before and after are separators
            if (startIndex > 0)
            {
                char prevChar = text[startIndex - 1];
                if (char.IsLetterOrDigit(prevChar) || prevChar == '_') //if not letter/digit/underscore, probably a space
                    return false;
            }
            int endIndex = startIndex + length;
            if (endIndex < text.Length)
            {
                char nextChar = text[endIndex];
                if (char.IsLetterOrDigit(nextChar) || nextChar == '_')
                    return false;
            }

            return true;
        }
    }
}
