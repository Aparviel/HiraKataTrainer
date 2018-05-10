using System;
using System.Windows.Forms;

namespace HiraKataTrainer
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }


        private void OpenTest()
        {
            FocusLabel.Focus();
            this.Hide();
            var Katakana = new Main();
            Katakana.Closed += (s, args) => this.Show();
            Katakana.Show();
        }


        private void Katakana_Button_Click(object sender, EventArgs e)
        {
            Settings.Type = 1;
            OpenTest();
        }


        private void Hiragana_Button_Click(object sender, EventArgs e)
        {
            Settings.Type = 2;
            OpenTest();
        }
    }
}
