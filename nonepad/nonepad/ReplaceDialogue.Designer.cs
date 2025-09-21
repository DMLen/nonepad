namespace nonepad
{
    partial class ReplaceDialogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceDialogue));
            replaceBox = new TextBox();
            ReplaceAll = new Button();
            ReplaceInstance = new Button();
            SuspendLayout();
            // 
            // replaceBox
            // 
            replaceBox.Location = new Point(12, 45);
            replaceBox.Name = "replaceBox";
            replaceBox.Size = new Size(286, 27);
            replaceBox.TabIndex = 7;
            replaceBox.WordWrap = false;
            replaceBox.TextChanged += replaceBox_TextChanged;
            // 
            // ReplaceAll
            // 
            ReplaceAll.Location = new Point(404, 43);
            ReplaceAll.Name = "ReplaceAll";
            ReplaceAll.Size = new Size(94, 29);
            ReplaceAll.TabIndex = 8;
            ReplaceAll.Text = "Replace All";
            ReplaceAll.UseVisualStyleBackColor = true;
            ReplaceAll.Click += ReplaceAll_Click;
            // 
            // ReplaceInstance
            // 
            ReplaceInstance.Location = new Point(304, 43);
            ReplaceInstance.Name = "ReplaceInstance";
            ReplaceInstance.Size = new Size(94, 29);
            ReplaceInstance.TabIndex = 9;
            ReplaceInstance.Text = "Replace";
            ReplaceInstance.UseVisualStyleBackColor = true;
            ReplaceInstance.Click += ReplaceInstance_Click;
            // 
            // ReplaceDialogue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 85);
            Controls.Add(ReplaceInstance);
            Controls.Add(ReplaceAll);
            Controls.Add(replaceBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReplaceDialogue";
            Text = "Replace...";
            Load += FindDialogue_Load;
            Controls.SetChildIndex(replaceBox, 0);
            Controls.SetChildIndex(ReplaceAll, 0);
            Controls.SetChildIndex(ReplaceInstance, 0);
            Controls.SetChildIndex(searchBox, 0);
            Controls.SetChildIndex(matchCaseBox, 0);
            Controls.SetChildIndex(wholeWordsBox, 0);
            Controls.SetChildIndex(nextButton, 0);
            Controls.SetChildIndex(previousButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox replaceBox;
        private Button ReplaceAll;
        private Button ReplaceInstance;
    }
}