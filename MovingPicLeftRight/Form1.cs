using System.Windows.Forms;

namespace MovingPicLeftRight
{
    public partial class Form1 : Form
    {
        public int x;
        public int y = 106;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MoveTimerY(object sender, EventArgs e)
        {
            if (x > 850)
            {
                x = -410;
            }
            x = x + 5;

            pictureBox1.Location = new Point(x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            timer1.Start();
        }
    }
}