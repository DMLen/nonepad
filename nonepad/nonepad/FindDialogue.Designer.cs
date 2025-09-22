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
            wholeWordsBox = new CheckBox();
            nextButton = new Button();
            previousButton = new Button();
            highlightAllBox = new CheckBox();
            countLabel = new Label();
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
            matchCaseBox.Location = new Point(376, 14);
            matchCaseBox.Name = "matchCaseBox";
            matchCaseBox.Size = new Size(107, 24);
            matchCaseBox.TabIndex = 1;
            matchCaseBox.Text = "Match Case";
            matchCaseBox.UseVisualStyleBackColor = true;
            matchCaseBox.CheckedChanged += matchCaseBox_CheckedChanged;
            // 
            // wholeWordsBox
            // 
            wholeWordsBox.AutoSize = true;
            wholeWordsBox.Location = new Point(489, 14);
            wholeWordsBox.Name = "wholeWordsBox";
            wholeWordsBox.Size = new Size(120, 24);
            wholeWordsBox.TabIndex = 4;
            wholeWordsBox.Text = "Whole Words";
            wholeWordsBox.UseVisualStyleBackColor = true;
            wholeWordsBox.CheckedChanged += wholeWordsBox_CheckedChanged;
            // 
            // nextButton
            // 
            nextButton.Image = Properties.Resources.Silk_arrow_right;
            nextButton.Location = new Point(340, 10);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(30, 30);
            nextButton.TabIndex = 5;
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // previousButton
            // 
            previousButton.Image = Properties.Resources.Silk_arrow_left;
            previousButton.Location = new Point(304, 10);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(30, 30);
            previousButton.TabIndex = 6;
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // highlightAllBox
            // 
            highlightAllBox.AutoSize = true;
            highlightAllBox.Location = new Point(615, 14);
            highlightAllBox.Name = "highlightAllBox";
            highlightAllBox.Size = new Size(115, 24);
            highlightAllBox.TabIndex = 7;
            highlightAllBox.Text = "Highlight All";
            highlightAllBox.UseVisualStyleBackColor = true;
            highlightAllBox.CheckedChanged += highlightAllBox_CheckedChanged;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new Point(12, 42);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(0, 20);
            countLabel.TabIndex = 8;
            countLabel.Click += countLabel_Click;
            // 
            // FindDialogue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 70);
            Controls.Add(countLabel);
            Controls.Add(highlightAllBox);
            Controls.Add(previousButton);
            Controls.Add(nextButton);
            Controls.Add(wholeWordsBox);
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

        protected TextBox searchBox;
        protected CheckBox matchCaseBox;
        protected CheckBox wholeWordsBox;
        protected Button nextButton;
        protected Button previousButton;
        private CheckBox highlightAllBox;
        protected Label countLabel;
    }
}