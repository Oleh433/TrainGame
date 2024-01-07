namespace TrainGame
{
    public partial class Form1 : Form
    {
        internal Train train;
        public Switch switch1;
        public Switch switch2;

        public Form1()
        {
            InitializeComponent();
            train = new Train(pictureBox1);
            train.HideDrawingBackground();
            train.DrawBlack();

            switch1 = new Switch(300, 325);
            switch2 = new Switch(460, 165);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            train.SwitchEngineState(switch1, switch2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            train.ChangeMovingDirection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch1.SwitchState = "right";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch1.SwitchState = "left";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch2.SwitchState = "left";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch2.SwitchState = "right";
        }
    }
}