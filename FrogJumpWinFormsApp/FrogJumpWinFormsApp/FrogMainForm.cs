using System.Linq;

namespace FrogJumpWinFormsApp
{
    public partial class FrogMainForm : Form
    {
        public int minimumMoveCount = 24;
        public int userMoveCount;
        protected List<PictureBox> pictureBoxesContainer;
        protected int centerPictureBoxLocation;
        public FrogMainForm()
        {
            InitializeComponent();
            centerPictureBoxLocation = emptyPictureBox.Location.X;
        }
        private void FrogMainForm_Load(object sender, EventArgs e)
        {
            pictureBoxesContainer = new List<PictureBox>
            {
                leftPictureBox1,
                leftPictureBox2,
                leftPictureBox3,
                leftPictureBox4,
                emptyPictureBox,
                rightPictureBox1,
                rightPictureBox2,
                rightPictureBox3,
                rightPictureBox4
            };
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
            moveCountLabel.Text = (Convert.ToInt32(moveCountLabel.Text) + 1).ToString();
            userMoveCount = Convert.ToInt32(moveCountLabel.Text) + 1;

        }
        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;
            if (distance > 2)
            {
                MessageBox.Show("Прыгать можно максимум через 1 лягушку!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var location = clickedPicture.Location;
                clickedPicture.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;
                
                if (IsAllFrogsSwaped())
                { 
                    Enabled= false;
                    var endGame = new EndGameForm(this);
                    endGame.Show();
                }
            }
        }
        private bool IsAllFrogsSwaped()
        {
            for (int i = 0; i < pictureBoxesContainer.Count; i++)
            {
                if(pictureBoxesContainer[i] == emptyPictureBox && pictureBoxesContainer[i].Location.X != centerPictureBoxLocation)
                {
                    return false;
                }
                if(pictureBoxesContainer[i].Location.X < centerPictureBoxLocation && i < pictureBoxesContainer.Count / 2)
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}