namespace TrainGame
{
    public partial class Form1 : Form
    {
        Train train;
        Switch switch1 = new Switch();
        Switch switch2 = new Switch();

        public Form1()
        {
            InitializeComponent();
            train = new Train(pictureBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PerformAnimation(Train tr)
        {
            for (int i = 0; i < 1000; i++)
            {
                tr.DrawBlack();
                if (train.x > 300 && train.y <= 325)
                {
                    tr.MoveRightNUp(2);
                }
                else
                {
                    tr.MoveRight(2);
                }
                Thread.Sleep(100);
                tr.HideDrawingBackground();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerformAnimation(train);
        }
    }
}