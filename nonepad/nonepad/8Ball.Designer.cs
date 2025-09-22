namespace nonepad
{
    partial class _8Ball
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_8Ball));
            questionBox = new TextBox();
            askButton = new Button();
            progressBar1 = new ProgressBar();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // questionBox
            // 
            questionBox.Location = new Point(12, 12);
            questionBox.Name = "questionBox";
            questionBox.PlaceholderText = "Ask your question here...";
            questionBox.Size = new Size(297, 27);
            questionBox.TabIndex = 0;
            questionBox.TextChanged += questionBox_TextChanged;
            // 
            // askButton
            // 
            askButton.Location = new Point(315, 12);
            askButton.Name = "askButton";
            askButton.Size = new Size(94, 29);
            askButton.TabIndex = 1;
            askButton.Text = "Ask";
            askButton.UseVisualStyleBackColor = true;
            askButton.Click += askButton_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 45);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(397, 29);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.No;
            textBox1.Location = new Point(12, 80);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(397, 27);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // _8Ball
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 121);
            Controls.Add(textBox1);
            Controls.Add(progressBar1);
            Controls.Add(askButton);
            Controls.Add(questionBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "_8Ball";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Magic 8 Ball";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox questionBox;
        private Button askButton;
        private ProgressBar progressBar1;
        private TextBox textBox1;
    }
}