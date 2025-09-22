using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nonepad
{
    //inherit functions from FindDialogue
    public partial class ReplaceDialogue : FindDialogue
    {
        //protected List<int> resultIndexes; //indexes from latest search -- returned by KMP_Find
        //protected int idxPos = 0; //current position in result indexes -- to cycle through search results
        public ReplaceDialogue()
        {
            InitializeComponent();
        }

        private void replaceBox_TextChanged(object sender, EventArgs e) //text we want to replace with
        {

        }

        private void ReplaceAll_Click(object sender, EventArgs e) //replace current selection
        {
            if (string.IsNullOrEmpty(searchBox.Text))
                return;

            //searchPos = 0;
            //findNext();

            //loop while findNext() has a match
            while (targetTextBox.SelectionLength > 0 && !string.IsNullOrEmpty(targetTextBox.SelectedText))
            {
                targetTextBox.SelectedText = replaceBox.Text;
                //searchPos = targetTextBox.SelectionStart + replaceBox.Text.Length;
                //findNext();
            }
        }

        private void ReplaceInstance_Click(object sender, EventArgs e) //replace all instances
        {
            if (targetTextBox.SelectionLength > 0 && resultIndexes != null && idxPos < resultIndexes.Count)
            {
                int currentIndex = resultIndexes[idxPos];
                string searchText = searchBox.Text;
                string replaceText = replaceBox.Text;
                int lengthDifference = replaceText.Length - searchText.Length; //calculate difference in length so we can adjust indexes (maintain accuracy of results without needing to re-search)
                
                targetTextBox.SelectedText = replaceText;
                resultIndexes.RemoveAt(idxPos);

                if (lengthDifference != 0)
                {
                    for (int i = 0; i < resultIndexes.Count; i++)
                    {
                        if (resultIndexes[i] > currentIndex)
                        {
                            resultIndexes[i] += lengthDifference;
                        }
                    }
                }
                
                //keep idxpos in bounds
                if (idxPos >= resultIndexes.Count && resultIndexes.Count > 0)
                {
                    idxPos = resultIndexes.Count - 1;
                }
                
                if (resultIndexes.Count > 0 && idxPos < resultIndexes.Count)
                {
                    selectWord(idxPos);
                }
            }
        }
    }
}
