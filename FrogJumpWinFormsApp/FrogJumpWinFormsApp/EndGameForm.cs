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
    public partial class EndGameForm : Form
    {
        private int minimumMoveCount;
        private int userMoveCount;
        private FrogMainForm form;
        public EndGameForm(FrogMainForm form)
        {
            InitializeComponent();
            this.form = form;
            minimumMoveCount = form.minimumMoveCount;
            userMoveCount = form.userMoveCount;
        }

        private void EndGameForm_Load(object sender, EventArgs e)
        {
            if(minimumMoveCount == userMoveCount)
            {
                winScoreLabel.Text = "Поздравляем, вам удалось завершить игру за минимальное количество шагов";
            }
            else
            {
                winScoreLabel.Text = $"Вы завершили игру за {userMoveCount} шага(-ов)";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
            form.Close();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Close();
            form.Close();
            form = new();
            form.Show();
        }
    }
}
