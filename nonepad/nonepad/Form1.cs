namespace nonepad
{
    public partial class MainForm : Form
    {
        //for ctrl+s save
        private string currentFilePath = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainTextBox.HideSelection = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                string extension = Path.GetExtension(path).ToLower();
                if (extension == ".rtf")
                {
                    mainTextBox.SaveFile(path, RichTextBoxStreamType.RichText);
                }
                else
                {
                    mainTextBox.SaveFile(path, RichTextBoxStreamType.PlainText); //avoid markdown embedding issues by using plaintext for non-rtf files
                }

                this.Text = Path.GetFileName(path) + " - Nonepad";
                currentFilePath = path;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                int position = path.LastIndexOf("\\");
                string substring = path.Substring(position + 1);
                this.Text = substring + " - Nonepad";
                mainTextBox.LoadFile(path, RichTextBoxStreamType.RichText);
                currentFilePath = path;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Clear();

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text.Length > 0)
            {
                mainTextBox.Undo();
                undoToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = true;
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Redo();
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Enabled = mainTextBox.Text.Length > 0;

        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            if (mainTextBox.Text.Length > 0)
            {
                undoToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                findToolStripMenuItem.Enabled = true;
            }
            else
            {
                undoToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                selectAllToolStripMenuItem.Enabled = false;
                findToolStripMenuItem.Enabled = false;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Cut();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectAll();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += DateTime.Now;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectionFont = new Font(mainTextBox.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectionFont = new Font(mainTextBox.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectionFont = new Font(mainTextBox.Font, FontStyle.Underline);
        }

        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectionFont = new Font(mainTextBox.Font, FontStyle.Strikeout);
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectionFont = new Font(mainTextBox.Font, FontStyle.Regular);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                string extension = Path.GetExtension(currentFilePath).ToLower();
                if (extension == ".rtf")
                {
                    mainTextBox.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    mainTextBox.SaveFile(currentFilePath, RichTextBoxStreamType.PlainText);
                }
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void fontDialogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (mainTextBox.SelectionLength > 0)
                {
                    mainTextBox.SelectionFont = fontDialog1.Font;
                }
                else
                {
                    mainTextBox.Font = fontDialog1.Font;
                }
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (mainTextBox.SelectionLength > 0)
                {
                    mainTextBox.SelectionColor = colorDialog1.Color;
                }
                else
                {
                    mainTextBox.ForeColor = colorDialog1.Color;
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindDialogue findDialog = new FindDialogue();
            findDialog.SetTargetTextBox(mainTextBox); // Pass reference to the main text box
            findDialog.Show(); // Use Show() instead of ShowDialog() to allow non-modal operation
        }
    }
}
