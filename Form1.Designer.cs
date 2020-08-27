namespace CarRacingGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.trophy = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trophy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 634);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avoid other crs to get points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // distance
            // 
            this.distance.AutoSize = true;
            this.distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance.Location = new System.Drawing.Point(239, 497);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(38, 25);
            this.distance.TabIndex = 3;
            this.distance.Text = "00";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(134, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.trophy);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 424);
            this.panel1.TabIndex = 5;
            // 
            // roadTrack1
            // 
            this.roadTrack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roadTrack1.Image = global::CarRacingGame.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(-2, -638);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(385, 632);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::CarRacingGame.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(-3, -222);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(385, 632);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 1;
            this.roadTrack2.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.Image = global::CarRacingGame.Properties.Resources.carGrey;
            this.AI1.Location = new System.Drawing.Point(66, 19);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 2;
            this.AI1.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.Transparent;
            this.AI2.Image = global::CarRacingGame.Properties.Resources.carGreen;
            this.AI2.Location = new System.Drawing.Point(294, 85);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 101);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI2.TabIndex = 3;
            this.AI2.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.BackColor = System.Drawing.Color.Transparent;
            this.explosion.Image = global::CarRacingGame.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(153, 234);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 4;
            this.explosion.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::CarRacingGame.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(161, 286);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 101);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // trophy
            // 
            this.trophy.BackColor = System.Drawing.Color.Transparent;
            this.trophy.Image = global::CarRacingGame.Properties.Resources.bronze;
            this.trophy.Location = new System.Drawing.Point(66, 157);
            this.trophy.Name = "trophy";
            this.trophy.Size = new System.Drawing.Size(250, 100);
            this.trophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trophy.TabIndex = 6;
            this.trophy.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moveCar);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopCar);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trophy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox trophy;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
    }
}

