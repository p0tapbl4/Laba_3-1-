using System;
using System.Windows.Forms;

namespace Laba_3_1_
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void question1_Click(object sender, EventArgs e)
        {
            Form quest = new qustion1Form();
            this.Hide();
            quest.ShowDialog();
            this.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form quest = new qustion2Form();
            this.Hide();
            quest.ShowDialog();
            this.Show();
        }
    }
}