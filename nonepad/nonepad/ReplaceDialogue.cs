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
            if (targetTextBox.SelectionLength > 0)
            {
                targetTextBox.SelectedText = replaceBox.Text;
                //findNext();
            }
        }
    }
}
