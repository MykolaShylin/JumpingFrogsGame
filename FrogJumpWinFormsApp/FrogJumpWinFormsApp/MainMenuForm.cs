using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogJumpWinFormsApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            var rules = new RulesForm();
            rules.Show();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var starGame = new FrogMainForm();
            starGame.Show();
            startButton.Enabled = false;
        }
    }
}
