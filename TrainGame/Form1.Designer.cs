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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
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
            // button1
            // 
            button1.Location = new Point(22, 470);
            button1.Name = "button1";
            button1.Size = new Size(136, 56);
            button1.TabIndex = 1;
            button1.Text = "Engine on/of";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(200, 469);
            button2.Name = "button2";
            button2.Size = new Size(169, 57);
            button2.TabIndex = 2;
            button2.Text = "Change direction";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(331, 373);
            button3.Name = "button3";
            button3.Size = new Size(38, 38);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(310, 276);
            button4.Name = "button4";
            button4.Size = new Size(38, 38);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(504, 217);
            button5.Name = "button5";
            button5.Size = new Size(38, 38);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(467, 120);
            button6.Name = "button6";
            button6.Size = new Size(38, 38);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}