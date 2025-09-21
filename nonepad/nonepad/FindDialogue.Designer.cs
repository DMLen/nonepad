namespace nonepad
{
    partial class FindDialogue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindDialogue));
            searchBox = new TextBox();
            matchCaseBox = new CheckBox();
            HighlightBox = new CheckBox();
            wholeWordsBox = new CheckBox();
            nextButton = new Button();
            previousButton = new Button();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(12, 12);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(286, 27);
            searchBox.TabIndex = 0;
            searchBox.WordWrap = false;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // matchCaseBox
            // 
            matchCaseBox.AutoSize = true;
            matchCaseBox.Location = new Point(425, 15);
            matchCaseBox.Name = "matchCaseBox";
            matchCaseBox.Size = new Size(107, 24);
            matchCaseBox.TabIndex = 1;
            matchCaseBox.Text = "Match Case";
            matchCaseBox.UseVisualStyleBackColor = true;
            matchCaseBox.CheckedChanged += matchCaseBox_CheckedChanged;
            // 
            // HighlightBox
            // 
            HighlightBox.AutoSize = true;
            HighlightBox.Location = new Point(304, 14);
            HighlightBox.Name = "HighlightBox";
            HighlightBox.Size = new Size(115, 24);
            HighlightBox.TabIndex = 3;
            HighlightBox.Text = "Highlight All";
            HighlightBox.UseVisualStyleBackColor = true;
            HighlightBox.CheckedChanged += HighlightBox_CheckedChanged;
            // 
            // wholeWordsBox
            // 
            wholeWordsBox.AutoSize = true;
            wholeWordsBox.Location = new Point(538, 15);
            wholeWordsBox.Name = "wholeWordsBox";
            wholeWordsBox.Size = new Size(120, 24);
            wholeWordsBox.TabIndex = 4;
            wholeWordsBox.Text = "Whole Words";
            wholeWordsBox.UseVisualStyleBackColor = true;
            wholeWordsBox.CheckedChanged += wholeWordsBox_CheckedChanged;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(12, 45);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 29);
            nextButton.TabIndex = 5;
            nextButton.Text = "Next...";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // previousButton
            // 
            previousButton.Location = new Point(204, 45);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(94, 29);
            previousButton.TabIndex = 6;
            previousButton.Text = "Previous...";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // FindDialogue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 87);
            Controls.Add(previousButton);
            Controls.Add(nextButton);
            Controls.Add(wholeWordsBox);
            Controls.Add(HighlightBox);
            Controls.Add(matchCaseBox);
            Controls.Add(searchBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FindDialogue";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Find...";
            TopMost = true;
            Load += FindDialogue_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private CheckBox matchCaseBox;
        private CheckBox HighlightBox;
        private CheckBox wholeWordsBox;
        private Button nextButton;
        private Button previousButton;
    }
}