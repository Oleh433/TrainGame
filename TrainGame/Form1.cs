using TrainGame.TrainParts;

namespace TrainGame
{
    public partial class Form1 : Form
    {
        public Game game;
        internal Train train;
        internal Wagon wagon;
        public Switch switch1;
        public Switch switch2;

        public Form1()
        {
            InitializeComponent();

            game = new Game();

            train = new Train(pictureBox1);
            wagon = new Wagon(pictureBox1);
            train.HideDrawingBackground();
            wagon.HideDrawingBackground();

            train.DrawBlack(train.CurrentObjectImage);

            switch1 = new Switch(300, 325, Image.FromFile("C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\Switch1Right.png"), Image.FromFile("C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\Switch1Left.png"));
            switch2 = new Switch(460, 165, Image.FromFile("C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\Switch2Right.png"), Image.FromFile("C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\Switch2Left.png"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchEngineState();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            train.ChangeMovingDirection();

            if (wagon.IsActive)
            {
                wagon.ChangeMovingDirection();
            }
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

        async public void SwitchEngineState()
        {
            if (train.IsActive == false)
            {
                train.IsActive = true;
                await Task.Run(() => PerformAnimation());
            }
            else
            {
                train.IsActive = false;
            }
        }

        public void PerformAnimation()
        {
            while (train.IsActive && game.GameState)
            {
                switch1.DrawBlack(train._pictureBox, 315, 319);
                switch2.DrawBlack(train._pictureBox, 462, 162); 

                train.DrawBlack(train.CurrentObjectImage);
                wagon.DrawBlack(wagon.CurrentObjectImage);

                train.pathHandler.Invoke(2);

                if (wagon.IsActive)
                {
                    wagon.pathHandler?.Invoke(2);
                }

                Thread.Sleep(50);
                train.HideDrawingBackground();

                train.LookForCheckpoints(switch1, switch2, wagon, game);
                wagon.LookForCheckpoints(switch1, switch2, wagon, game);

                if (train.X == 152 && train.Y == 165)
                {
                    wagon.IsActive = true;
                }

            }

            switch1.DrawBlack(train._pictureBox, 315, 319);
            switch2.DrawBlack(train._pictureBox, 462, 162);

            train.DrawBlack(train.CurrentObjectImage);
            wagon.DrawBlack(wagon.CurrentObjectImage);
        }
    }
}