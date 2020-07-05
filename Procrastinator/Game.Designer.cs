namespace Procrastinator
{
    partial class Game
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
            this.skeletonu = new System.Windows.Forms.Timer(this.components);
            this.Wukongu = new System.Windows.Forms.Timer(this.components);
            this.Nutcrackeru = new System.Windows.Forms.Timer(this.components);
            this.Raptoru = new System.Windows.Forms.Timer(this.components);
            this.gamepanel = new System.Windows.Forms.Panel();
            this.start = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Label();
            this.VictoryBanner = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.dummyup = new System.Windows.Forms.Button();
            this.Nutcrackerup = new System.Windows.Forms.Button();
            this.AlpineSkiup = new System.Windows.Forms.Button();
            this.raptorup = new System.Windows.Forms.Button();
            this.Wukongup = new System.Windows.Forms.Button();
            this.Skeletonup = new System.Windows.Forms.Button();
            this.Wukong = new System.Windows.Forms.PictureBox();
            this.Nutcracker = new System.Windows.Forms.PictureBox();
            this.Raptor = new System.Windows.Forms.PictureBox();
            this.AlpineSki = new System.Windows.Forms.PictureBox();
            this.Skeleton = new System.Windows.Forms.PictureBox();
            this.Upbacklabel = new System.Windows.Forms.Label();
            this.Defeat = new System.Windows.Forms.PictureBox();
            this.Alpineu = new System.Windows.Forms.Timer(this.components);
            this.Victory = new System.Windows.Forms.Timer(this.components);
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.gamepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VictoryBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wukong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nutcracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raptor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlpineSki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skeleton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Defeat)).BeginInit();
            this.SuspendLayout();
            // 
            // skeletonu
            // 
            this.skeletonu.Enabled = true;
            this.skeletonu.Interval = 10;
            this.skeletonu.Tick += new System.EventHandler(this.skeletonu_Tick);
            // 
            // Wukongu
            // 
            this.Wukongu.Enabled = true;
            this.Wukongu.Interval = 10;
            this.Wukongu.Tick += new System.EventHandler(this.Wukong_Tick);
            // 
            // Nutcrackeru
            // 
            this.Nutcrackeru.Enabled = true;
            this.Nutcrackeru.Interval = 10;
            this.Nutcrackeru.Tick += new System.EventHandler(this.Nutcracker_Tick);
            // 
            // Raptoru
            // 
            this.Raptoru.Enabled = true;
            this.Raptoru.Interval = 10;
            this.Raptoru.Tick += new System.EventHandler(this.Raptoru_Tick);
            // 
            // gamepanel
            // 
            this.gamepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gamepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamepanel.Controls.Add(this.start);
            this.gamepanel.Controls.Add(this.Timer);
            this.gamepanel.Controls.Add(this.VictoryBanner);
            this.gamepanel.Controls.Add(this.exit);
            this.gamepanel.Controls.Add(this.dummyup);
            this.gamepanel.Controls.Add(this.Nutcrackerup);
            this.gamepanel.Controls.Add(this.AlpineSkiup);
            this.gamepanel.Controls.Add(this.raptorup);
            this.gamepanel.Controls.Add(this.Wukongup);
            this.gamepanel.Controls.Add(this.Skeletonup);
            this.gamepanel.Controls.Add(this.Wukong);
            this.gamepanel.Controls.Add(this.Nutcracker);
            this.gamepanel.Controls.Add(this.Raptor);
            this.gamepanel.Controls.Add(this.AlpineSki);
            this.gamepanel.Controls.Add(this.Skeleton);
            this.gamepanel.Controls.Add(this.Upbacklabel);
            this.gamepanel.Controls.Add(this.Defeat);
            this.gamepanel.Location = new System.Drawing.Point(0, -1);
            this.gamepanel.Name = "gamepanel";
            this.gamepanel.Size = new System.Drawing.Size(731, 486);
            this.gamepanel.TabIndex = 0;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start.Location = new System.Drawing.Point(548, 437);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(152, 46);
            this.start.TabIndex = 18;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Timer
            // 
            this.Timer.BackColor = System.Drawing.Color.White;
            this.Timer.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(12, 445);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(100, 29);
            this.Timer.TabIndex = 17;
            this.Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Timer.Visible = false;
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // VictoryBanner
            // 
            this.VictoryBanner.BackgroundImage = global::Procrastinator.Properties.Resources.VictoryRoyale;
            this.VictoryBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VictoryBanner.Location = new System.Drawing.Point(-387, 66);
            this.VictoryBanner.Name = "VictoryBanner";
            this.VictoryBanner.Size = new System.Drawing.Size(1500, 278);
            this.VictoryBanner.TabIndex = 16;
            this.VictoryBanner.TabStop = false;
            this.VictoryBanner.Visible = false;
            this.VictoryBanner.Click += new System.EventHandler(this.VictoryBanner_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(659, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(55, 57);
            this.exit.TabIndex = 14;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dummyup
            // 
            this.dummyup.BackColor = System.Drawing.Color.Red;
            this.dummyup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dummyup.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dummyup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dummyup.Location = new System.Drawing.Point(268, 437);
            this.dummyup.Name = "dummyup";
            this.dummyup.Size = new System.Drawing.Size(152, 46);
            this.dummyup.TabIndex = 13;
            this.dummyup.Text = "Up";
            this.dummyup.UseVisualStyleBackColor = false;
            this.dummyup.Click += new System.EventHandler(this.dummyup_Click);
            // 
            // Nutcrackerup
            // 
            this.Nutcrackerup.BackColor = System.Drawing.Color.Red;
            this.Nutcrackerup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nutcrackerup.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nutcrackerup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nutcrackerup.Location = new System.Drawing.Point(268, 437);
            this.Nutcrackerup.Name = "Nutcrackerup";
            this.Nutcrackerup.Size = new System.Drawing.Size(152, 46);
            this.Nutcrackerup.TabIndex = 12;
            this.Nutcrackerup.Text = "Up";
            this.Nutcrackerup.UseVisualStyleBackColor = false;
            this.Nutcrackerup.Visible = false;
            this.Nutcrackerup.Click += new System.EventHandler(this.Nutcrackerup_Click);
            // 
            // AlpineSkiup
            // 
            this.AlpineSkiup.BackColor = System.Drawing.Color.Red;
            this.AlpineSkiup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlpineSkiup.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlpineSkiup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AlpineSkiup.Location = new System.Drawing.Point(268, 437);
            this.AlpineSkiup.Name = "AlpineSkiup";
            this.AlpineSkiup.Size = new System.Drawing.Size(152, 46);
            this.AlpineSkiup.TabIndex = 11;
            this.AlpineSkiup.Text = "Up";
            this.AlpineSkiup.UseVisualStyleBackColor = false;
            this.AlpineSkiup.Click += new System.EventHandler(this.AlpineSkiup_Click);
            // 
            // raptorup
            // 
            this.raptorup.BackColor = System.Drawing.Color.Red;
            this.raptorup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raptorup.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raptorup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.raptorup.Location = new System.Drawing.Point(268, 437);
            this.raptorup.Name = "raptorup";
            this.raptorup.Size = new System.Drawing.Size(152, 46);
            this.raptorup.TabIndex = 10;
            this.raptorup.Text = "Up";
            this.raptorup.UseVisualStyleBackColor = false;
            this.raptorup.Click += new System.EventHandler(this.raptorup_Click);
            // 
            // Wukongup
            // 
            this.Wukongup.BackColor = System.Drawing.Color.Red;
            this.Wukongup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wukongup.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wukongup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Wukongup.Location = new System.Drawing.Point(268, 437);
            this.Wukongup.Name = "Wukongup";
            this.Wukongup.Size = new System.Drawing.Size(152, 46);
            this.Wukongup.TabIndex = 9;
            this.Wukongup.Text = "Up";
            this.Wukongup.UseVisualStyleBackColor = false;
            this.Wukongup.Click += new System.EventHandler(this.Wukongup_Click);
            // 
            // Skeletonup
            // 
            this.Skeletonup.BackColor = System.Drawing.Color.Red;
            this.Skeletonup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skeletonup.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skeletonup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Skeletonup.Location = new System.Drawing.Point(268, 437);
            this.Skeletonup.Name = "Skeletonup";
            this.Skeletonup.Size = new System.Drawing.Size(152, 46);
            this.Skeletonup.TabIndex = 8;
            this.Skeletonup.Text = "Up";
            this.Skeletonup.UseVisualStyleBackColor = false;
            this.Skeletonup.Click += new System.EventHandler(this.Skeletonup_Click);
            // 
            // Wukong
            // 
            this.Wukong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Wukong.BackgroundImage = global::Procrastinator.Properties.Resources.T_Soldier_HID_071_Athena_Commando_M_Wukong_L;
            this.Wukong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Wukong.Location = new System.Drawing.Point(156, 326);
            this.Wukong.Name = "Wukong";
            this.Wukong.Size = new System.Drawing.Size(100, 100);
            this.Wukong.TabIndex = 4;
            this.Wukong.TabStop = false;
            this.Wukong.Click += new System.EventHandler(this.Wukong_Click);
            // 
            // Nutcracker
            // 
            this.Nutcracker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Nutcracker.BackgroundImage = global::Procrastinator.Properties.Resources.T_Soldier_HID_050_Athena_Commando_M_HolidayNutcracker_L;
            this.Nutcracker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Nutcracker.Location = new System.Drawing.Point(308, 326);
            this.Nutcracker.Name = "Nutcracker";
            this.Nutcracker.Size = new System.Drawing.Size(100, 100);
            this.Nutcracker.TabIndex = 3;
            this.Nutcracker.TabStop = false;
            this.Nutcracker.Click += new System.EventHandler(this.Nutcracker_Click);
            // 
            // Raptor
            // 
            this.Raptor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Raptor.BackgroundImage = global::Procrastinator.Properties.Resources.T_Soldier_HID_031_Athena_Commando_M_Retro_L;
            this.Raptor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Raptor.Location = new System.Drawing.Point(455, 326);
            this.Raptor.Name = "Raptor";
            this.Raptor.Size = new System.Drawing.Size(100, 100);
            this.Raptor.TabIndex = 2;
            this.Raptor.TabStop = false;
            this.Raptor.Click += new System.EventHandler(this.Raptor_Click);
            // 
            // AlpineSki
            // 
            this.AlpineSki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AlpineSki.BackgroundImage = global::Procrastinator.Properties.Resources.T_Soldier_HID_055_Athena_Commando_M_SkiDude_CAN_L;
            this.AlpineSki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlpineSki.Location = new System.Drawing.Point(600, 326);
            this.AlpineSki.Name = "AlpineSki";
            this.AlpineSki.Size = new System.Drawing.Size(100, 100);
            this.AlpineSki.TabIndex = 1;
            this.AlpineSki.TabStop = false;
            this.AlpineSki.Click += new System.EventHandler(this.AplineSki_Click);
            // 
            // Skeleton
            // 
            this.Skeleton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Skeleton.BackgroundImage = global::Procrastinator.Properties.Resources.Skull_trooper_jonesy_legendary_epic;
            this.Skeleton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skeleton.Location = new System.Drawing.Point(12, 326);
            this.Skeleton.Name = "Skeleton";
            this.Skeleton.Size = new System.Drawing.Size(100, 100);
            this.Skeleton.TabIndex = 0;
            this.Skeleton.TabStop = false;
            this.Skeleton.Click += new System.EventHandler(this.Skeleton_Click);
            // 
            // Upbacklabel
            // 
            this.Upbacklabel.BackColor = System.Drawing.Color.Black;
            this.Upbacklabel.Location = new System.Drawing.Point(0, 429);
            this.Upbacklabel.Name = "Upbacklabel";
            this.Upbacklabel.Size = new System.Drawing.Size(728, 57);
            this.Upbacklabel.TabIndex = 15;
            this.Upbacklabel.Text = "label1";
            // 
            // Defeat
            // 
            this.Defeat.BackgroundImage = global::Procrastinator.Properties.Resources.Defeat_copy1;
            this.Defeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Defeat.Location = new System.Drawing.Point(-623, 0);
            this.Defeat.Name = "Defeat";
            this.Defeat.Size = new System.Drawing.Size(2000, 500);
            this.Defeat.TabIndex = 19;
            this.Defeat.TabStop = false;
            this.Defeat.Visible = false;
            // 
            // Alpineu
            // 
            this.Alpineu.Enabled = true;
            this.Alpineu.Interval = 10;
            this.Alpineu.Tick += new System.EventHandler(this.Alpineu_Tick);
            // 
            // Victory
            // 
            this.Victory.Enabled = true;
            this.Victory.Interval = 10;
            this.Victory.Tick += new System.EventHandler(this.Victory_Tick);
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 10;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 485);
            this.Controls.Add(this.gamepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "Game";
            this.gamepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VictoryBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wukong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nutcracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raptor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlpineSki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skeleton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Defeat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamepanel;
        private System.Windows.Forms.PictureBox Skeleton;
        private System.Windows.Forms.PictureBox Wukong;
        private System.Windows.Forms.PictureBox Nutcracker;
        private System.Windows.Forms.PictureBox Raptor;
        private System.Windows.Forms.PictureBox AlpineSki;
        private System.Windows.Forms.Button Nutcrackerup;
        private System.Windows.Forms.Button AlpineSkiup;
        private System.Windows.Forms.Button raptorup;
        private System.Windows.Forms.Button Wukongup;
        private System.Windows.Forms.Button Skeletonup;
        private System.Windows.Forms.Button dummyup;
        private System.Windows.Forms.Timer skeletonu;
        private System.Windows.Forms.Timer Wukongu;
        private System.Windows.Forms.Timer Nutcrackeru;
        private System.Windows.Forms.Timer Raptoru;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer Alpineu;
        private System.Windows.Forms.Label Upbacklabel;
        private System.Windows.Forms.Timer Victory;
        private System.Windows.Forms.PictureBox VictoryBanner;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox Defeat;
        private System.Windows.Forms.Timer Clock;
    }
}