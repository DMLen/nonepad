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

        }

        protected void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchPos = 0;
            findNext();
        }

        protected void nextButton_Click(object sender, EventArgs e)
        {
            findNext();
        }

        protected void findNext()
        {
            if (searchBox.Text == "")
            {
                targetTextBox.Select(0, 0);
                return;
            }

            string searchText = searchBox.Text;
            string targetText = targetTextBox.Text;

            int searchIndex;

            if (matchCaseBox.Checked)
            {
                searchIndex = targetText.IndexOf(searchText, searchPos);
            }
            else
            {
                searchIndex = targetText.IndexOf(searchText, searchPos, StringComparison.OrdinalIgnoreCase);
            }

            if (searchIndex >= 0)
            {
                if (wholeWordsBox.Checked && !isWholeWord(targetText, searchIndex, searchText.Length))
                {
                    //not a whole word, skip this occurrence
                    searchPos = searchIndex + 1;
                    findNext();
                    return;
                }
                targetTextBox.Select(searchIndex, searchText.Length);
                targetTextBox.ScrollToCaret();
                searchPos = searchIndex + 1;
            }
            else
            {
                //not found from current pos, wrap around to start
                if (matchCaseBox.Checked)
                {
                    searchIndex = targetText.IndexOf(searchText, 0);
                }
                else
                {
                    searchIndex = targetText.IndexOf(searchText, 0, StringComparison.OrdinalIgnoreCase);
                }

                if (searchIndex >= 0)
                {
                    if (wholeWordsBox.Checked && !isWholeWord(targetText, searchIndex, searchText.Length))
                    {
                        //not a whole word, continue searching from this position
                        searchPos = searchIndex + 1;
                        findNext();
                        return;
                    }
                    targetTextBox.Select(searchIndex, searchText.Length);
                    targetTextBox.ScrollToCaret();
                    searchPos = searchIndex + 1;
                }
                else
                {
                    targetTextBox.Select(0, 0); //not occurring in document at all
                }
            }
        }

        protected void previousButton_Click(object sender, EventArgs e)
        {
            findPrevious();
        }

        protected void findPrevious()
        {
            if (searchBox.Text == "")
            {
                targetTextBox.Select(0, 0);
                return;
            }

            string searchText = searchBox.Text;
            string targetText = targetTextBox.Text;

            int searchStart = Math.Max(0, searchPos - searchText.Length - 1);
            int searchIndex;

            if (matchCaseBox.Checked)  //searching backwards with lastindexof
            {
                searchIndex = targetText.LastIndexOf(searchText, searchStart);
            }
            else
            {
                searchIndex = targetText.LastIndexOf(searchText, searchStart, StringComparison.OrdinalIgnoreCase);
            }

            if (searchIndex >= 0)
            {
                if (wholeWordsBox.Checked && !isWholeWord(targetText, searchIndex, searchText.Length))
                {
                    //not a whole word, continue searching backwards from this position
                    searchPos = searchIndex;
                    findPrevious();
                    return;
                }
                targetTextBox.Select(searchIndex, searchText.Length);
                targetTextBox.ScrollToCaret();
                searchPos = searchIndex;
            }
            else
            {
                //not found before current pos, wrap around to end
                int documentLength = targetText.Length;
                if (matchCaseBox.Checked)
                {
                    searchIndex = targetText.LastIndexOf(searchText, documentLength);
                }
                else
                {
                    searchIndex = targetText.LastIndexOf(searchText, documentLength, StringComparison.OrdinalIgnoreCase);
                }

                if (searchIndex >= 0)
                {
                    if (wholeWordsBox.Checked && !isWholeWord(targetText, searchIndex, searchText.Length))
                    {
                        //not a whole word, continue searching backwards from this position
                        searchPos = searchIndex;
                        findPrevious();
                        return;
                    }
                    targetTextBox.Select(searchIndex, searchText.Length);
                    targetTextBox.ScrollToCaret();
                    searchPos = searchIndex;
                }
                else
                {
                    targetTextBox.Select(0, 0); //not occurring in document at all
                }
            }
        }

        protected void wholeWordsBox_CheckedChanged(object sender, EventArgs e)
        {

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
