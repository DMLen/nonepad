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
    public partial class _8Ball : Form
    {
        List<string> answers = new List<string>()
        {
            "It is certain.",
            "It is decidedly so.",
            "Without a doubt.",
            "Yes, definitely.",
            "You may rely on it.",
            "As I see it, yes.",
            "Most likely.",
            "Outlook good.",
            "Yes.",
            "Signs point to yes.",
            "Reply hazy, try again.",
            "Ask again later.",
            "Better not tell you now.",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don't count on it.",
            "My reply is no.",
            "My sources say no.",
            "Outlook not so good.",
            "Very doubtful."
        };

        private bool hasFreezedBefore = false;
        private System.Windows.Forms.Timer progressTimer;

        public _8Ball()
        {
            InitializeComponent();
            progressTimer = new System.Windows.Forms.Timer();
            progressTimer.Interval = 50; // Update every 50ms
            progressTimer.Tick += ProgressTimer_Tick;
        }

        private void questionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private async void askButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(questionBox.Text))
            {
                return;
            }
            askButton.Enabled = false;
            textBox1.Text = "";
            progressBar1.Value = 0;

            progressTimer.Start();

            await FakeLoading();

            Random rand = new Random();
            int index = rand.Next(answers.Count);
            textBox1.Text = answers[index];

            hasFreezedBefore = false;
            askButton.Enabled = true;
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 2;
            }
            else
            {
                progressTimer.Stop();
            }
        }

        private async Task FakeLoading()
        {
            Random rand = new Random();
            int freezePoint = rand.Next(20, 80);

            while (progressBar1.Value < freezePoint)
            {
                await Task.Delay(25);
            }

            if (!hasFreezedBefore)
            {
                progressTimer.Stop();
                await Task.Delay(new Random().Next(1500, 10000));
                hasFreezedBefore = true;
                progressTimer.Start();
            }

            while (progressBar1.Value < 100)
            {
                await Task.Delay(25);
            }

            await Task.Delay(1000);
        }

        private void eightballIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
