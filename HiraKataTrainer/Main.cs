using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HiraKataTrainer
{
    public partial class Main : Form
    {
        bool Waiting = false;
        int QuestionTotalCount, QuestionRightAnsweredCount, QuestionCurrent = 0;
        int[] Questions;
        string[][] CurrentDictionary;


        public Main()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            switch (Settings.Type)
            {
                case 1:
                    CurrentDictionary = Dictionary.Katakana;
                    break;
                default:
                    CurrentDictionary = Dictionary.Hiragana;
                    break;
            }

            QuestionTotalCount = CurrentDictionary.Length;
            Questions = new int[QuestionTotalCount];
            for (int i = 0; i < QuestionTotalCount; i++)
            {
                Questions[i] = i;
            }

            Random _Rand = new Random();
            Questions = Questions.OrderBy(x => _Rand.Next()).ToArray();

            MainLabel.Text = CurrentDictionary[Questions[0]][0];

            ProgressBar.Maximum = QuestionTotalCount;
        }


        private void Delay(int millisecond, Action action)
        {
            var timer = new Timer();
            timer.Tick += delegate
            {
                action.Invoke();

                timer.Stop();
                Waiting = false;

                ProgressBar.Value = QuestionCurrent;

                if (QuestionCurrent == QuestionTotalCount)
                {
                    this.Close();
                    MessageBox.Show("Right answers: " + Convert.ToInt32((100d / QuestionTotalCount) * QuestionRightAnsweredCount).ToString() + "%", "Result");
                }
                else
                {
                    MainLabel.Text = CurrentDictionary[Questions[QuestionCurrent]][0];
                }
            };

            timer.Interval = millisecond;
            timer.Start();
        }


        private void RightAnswer()
        {
            Waiting = true;
            QuestionRightAnsweredCount++;
            MainLabel.ForeColor = Color.Green;
            QuestionCurrent++;
            Delay(1000, new Action(() => { MainLabel.ForeColor = SystemColors.ControlText; }));
        }


        private void WrongAnswer()
        {
            Waiting = true;
            MainLabel.ForeColor = Color.Red;
            MainLabel.Text = CurrentDictionary[Questions[QuestionCurrent]][1];
            QuestionCurrent++;
            Delay(1000, new Action(() => { MainLabel.ForeColor = SystemColors.ControlText; }));
        }


        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Return) && (Waiting == false))
            {
                e.Handled = true;

                if (InputTextBox.Text.ToLower() == CurrentDictionary[Questions[QuestionCurrent]][1])
                {
                    InputTextBox.Clear();
                    RightAnswer();
                }
                else
                {
                    InputTextBox.Clear();
                    WrongAnswer();
                }
            }
        }
    }
}
