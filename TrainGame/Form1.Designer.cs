namespace TrainGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            EngineControlButton = new Button();
            ChangeDirectionButton = new Button();
            Switch1TurnRightButton = new Button();
            Switch1TurnLeftButton = new Button();
            Switch2TurnLeftButton = new Button();
            Switch2TurnRightButton = new Button();
            StartGameButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(952, 434);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // EngineControlButton
            // 
            EngineControlButton.Location = new Point(205, 452);
            EngineControlButton.Name = "EngineControlButton";
            EngineControlButton.Size = new Size(164, 56);
            EngineControlButton.TabIndex = 1;
            EngineControlButton.Text = "Engine on/of";
            EngineControlButton.UseVisualStyleBackColor = true;
            EngineControlButton.Click += EngineControlButton_Click;
            // 
            // ChangeDirectionButton
            // 
            ChangeDirectionButton.Location = new Point(402, 452);
            ChangeDirectionButton.Name = "ChangeDirectionButton";
            ChangeDirectionButton.Size = new Size(164, 56);
            ChangeDirectionButton.TabIndex = 2;
            ChangeDirectionButton.Text = "Change direction";
            ChangeDirectionButton.UseVisualStyleBackColor = true;
            ChangeDirectionButton.Click += ChangeDirectionButton_Click;
            // 
            // Switch1TurnRightButton
            // 
            Switch1TurnRightButton.BackgroundImage = (Image)resources.GetObject("Switch1TurnRightButton.BackgroundImage");
            Switch1TurnRightButton.Image = (Image)resources.GetObject("Switch1TurnRightButton.Image");
            Switch1TurnRightButton.Location = new Point(331, 373);
            Switch1TurnRightButton.Name = "Switch1TurnRightButton";
            Switch1TurnRightButton.Size = new Size(38, 38);
            Switch1TurnRightButton.TabIndex = 3;
            Switch1TurnRightButton.UseVisualStyleBackColor = true;
            Switch1TurnRightButton.Click += Switch1TurnRightButton_Click;
            // 
            // Switch1TurnLeftButton
            // 
            Switch1TurnLeftButton.Image = (Image)resources.GetObject("Switch1TurnLeftButton.Image");
            Switch1TurnLeftButton.Location = new Point(310, 276);
            Switch1TurnLeftButton.Name = "Switch1TurnLeftButton";
            Switch1TurnLeftButton.Size = new Size(38, 38);
            Switch1TurnLeftButton.TabIndex = 4;
            Switch1TurnLeftButton.UseVisualStyleBackColor = true;
            Switch1TurnLeftButton.Click += Switch1TurnLeftButton_Click;
            // 
            // Switch2TurnLeftButton
            // 
            Switch2TurnLeftButton.Image = (Image)resources.GetObject("Switch2TurnLeftButton.Image");
            Switch2TurnLeftButton.Location = new Point(504, 217);
            Switch2TurnLeftButton.Name = "Switch2TurnLeftButton";
            Switch2TurnLeftButton.Size = new Size(38, 38);
            Switch2TurnLeftButton.TabIndex = 5;
            Switch2TurnLeftButton.UseVisualStyleBackColor = true;
            Switch2TurnLeftButton.Click += Switch2TurnLeftButton_Click;
            // 
            // Switch2TurnRightButton
            // 
            Switch2TurnRightButton.Image = (Image)resources.GetObject("Switch2TurnRightButton.Image");
            Switch2TurnRightButton.Location = new Point(467, 120);
            Switch2TurnRightButton.Name = "Switch2TurnRightButton";
            Switch2TurnRightButton.Size = new Size(38, 38);
            Switch2TurnRightButton.TabIndex = 6;
            Switch2TurnRightButton.UseVisualStyleBackColor = true;
            Switch2TurnRightButton.Click += Switch2TurnRightButton_Click;
            // 
            // StartGameButton
            // 
            StartGameButton.Location = new Point(12, 452);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(164, 56);
            StartGameButton.TabIndex = 7;
            StartGameButton.Text = "Start game";
            StartGameButton.UseVisualStyleBackColor = true;
            StartGameButton.Click += StartGameButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(StartGameButton);
            Controls.Add(Switch2TurnRightButton);
            Controls.Add(Switch2TurnLeftButton);
            Controls.Add(Switch1TurnLeftButton);
            Controls.Add(Switch1TurnRightButton);
            Controls.Add(ChangeDirectionButton);
            Controls.Add(EngineControlButton);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button EngineControlButton;
        private Button ChangeDirectionButton;
        private Button Switch1TurnRightButton;
        private Button Switch1TurnLeftButton;
        private Button Switch2TurnLeftButton;
        private Button Switch2TurnRightButton;
        private Button StartGameButton;
    }
}