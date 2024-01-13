using TrainGame.TrainParts;
using static TrainGame.Switch;

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

            train = new Train(pictureBox1, 200, 325);
            wagon = new Wagon(pictureBox1, 100, 325);


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
            switch1.SwitchState = SwichStates.Right;

            DrawInteractiveObjects();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch1.SwitchState = SwichStates.Left;

            DrawInteractiveObjects();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch2.SwitchState = SwichStates.Left;

            DrawInteractiveObjects();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch2.SwitchState = SwichStates.Right;

            DrawInteractiveObjects();
        }

        public void SwitchEngineState()
        {
            if (train.IsActive == false)
            {
                train.IsActive = true;

            }
            else
            {
                train.IsActive = false;
            }
        }

        public void DrawInteractiveObjects()
        {
            switch1.DrawObject(train._pictureBox, 315, 319);
            switch2.DrawObject(train._pictureBox, 462, 162);

            train.DrawObject(train.CurrentObjectImage);
            wagon.DrawObject(wagon.CurrentObjectImage);
        }

        public void PerformAnimation()
        {
            while (game.GameState)
            {

                Thread.Sleep(50);
                train.HideDrawingBackground();

                DrawInteractiveObjects();

                train.LookForCheckpoints(switch1, switch2, wagon, game);

                if (wagon.IsActive)
                {
                    wagon.LookForCheckpoints(switch1, switch2, train, game);
                }

                if (train.IsActive)
                {
                    train.pathHandler.Invoke(2);

                    if (wagon.IsActive)
                    {
                        wagon.pathHandler.Invoke(2);
                    }
                }
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            if (game.GameState && !game.IsStarted)
            {
                game.IsStarted = true;
                await Task.Run(() => PerformAnimation());
            }
        }
    }
}