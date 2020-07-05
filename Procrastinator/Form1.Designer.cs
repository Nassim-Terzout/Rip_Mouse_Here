namespace Procrastinator
{
    partial class TheForm
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
            this.Border = new System.Windows.Forms.Panel();
            this.face = new System.Windows.Forms.PictureBox();
            this.topup = new System.Windows.Forms.Timer(this.components);
            this.topdown = new System.Windows.Forms.Timer(this.components);
            this.leftright = new System.Windows.Forms.Timer(this.components);
            this.leftleft = new System.Windows.Forms.Timer(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.Spinl = new System.Windows.Forms.Button();
            this.Spinr = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.Moveup = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Button();
            this.Wukong = new System.Windows.Forms.Button();
            this.AlpineAce = new System.Windows.Forms.Button();
            this.JohnWick = new System.Windows.Forms.Button();
            this.Nutcracker = new System.Windows.Forms.Button();
            this.Raptor = new System.Windows.Forms.Button();
            this.Roblox = new System.Windows.Forms.Button();
            this.Skeleton = new System.Windows.Forms.Button();
            this.Fizzface = new System.Windows.Forms.Button();
            this.SashSergeant = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Small = new System.Windows.Forms.Button();
            this.Big = new System.Windows.Forms.Button();
            this.Slow = new System.Windows.Forms.Button();
            this.Fast = new System.Windows.Forms.Button();
            this.Backcolor = new System.Windows.Forms.Timer(this.components);
            this.Border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.face)).BeginInit();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.Coral;
            this.Border.Controls.Add(this.face);
            this.Border.Location = new System.Drawing.Point(12, 68);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(434, 293);
            this.Border.TabIndex = 0;
            this.Border.Paint += new System.Windows.Forms.PaintEventHandler(this.Border_Paint);
            // 
            // face
            // 
            this.face.BackgroundImage = global::Procrastinator.Properties.Resources.Sash_Sergeant;
            this.face.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.face.Location = new System.Drawing.Point(163, 106);
            this.face.Name = "face";
            this.face.Size = new System.Drawing.Size(100, 100);
            this.face.TabIndex = 0;
            this.face.TabStop = false;
            this.face.Click += new System.EventHandler(this.face_Click);
            // 
            // topup
            // 
            this.topup.Enabled = true;
            this.topup.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // topdown
            // 
            this.topdown.Tick += new System.EventHandler(this.topdown_Tick);
            // 
            // leftright
            // 
            this.leftright.Tick += new System.EventHandler(this.leftright_Tick);
            // 
            // leftleft
            // 
            this.leftleft.Enabled = true;
            this.leftleft.Tick += new System.EventHandler(this.leftleft_Tick);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(628, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(63, 59);
            this.exit.TabIndex = 11;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Spinl
            // 
            this.Spinl.BackColor = System.Drawing.Color.Red;
            this.Spinl.BackgroundImage = global::Procrastinator.Properties.Resources.SpinLeft1;
            this.Spinl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Spinl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Spinl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spinl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Spinl.Location = new System.Drawing.Point(597, 403);
            this.Spinl.Name = "Spinl";
            this.Spinl.Size = new System.Drawing.Size(94, 30);
            this.Spinl.TabIndex = 25;
            this.Spinl.UseVisualStyleBackColor = false;
            this.Spinl.Click += new System.EventHandler(this.Spinl_Click);
            // 
            // Spinr
            // 
            this.Spinr.BackColor = System.Drawing.Color.Red;
            this.Spinr.BackgroundImage = global::Procrastinator.Properties.Resources.Spinright;
            this.Spinr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Spinr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Spinr.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spinr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Spinr.Location = new System.Drawing.Point(597, 367);
            this.Spinr.Name = "Spinr";
            this.Spinr.Size = new System.Drawing.Size(94, 30);
            this.Spinr.TabIndex = 26;
            this.Spinr.UseVisualStyleBackColor = false;
            this.Spinr.Click += new System.EventHandler(this.Spinr_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.BackColor = System.Drawing.Color.Red;
            this.MoveRight.BackgroundImage = global::Procrastinator.Properties.Resources.Go;
            this.MoveRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveRight.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveRight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoveRight.Location = new System.Drawing.Point(505, 403);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(86, 30);
            this.MoveRight.TabIndex = 25;
            this.MoveRight.UseVisualStyleBackColor = false;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // MoveLeft
            // 
            this.MoveLeft.BackColor = System.Drawing.Color.Red;
            this.MoveLeft.BackgroundImage = global::Procrastinator.Properties.Resources.goleft;
            this.MoveLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveLeft.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoveLeft.Location = new System.Drawing.Point(505, 367);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(86, 30);
            this.MoveLeft.TabIndex = 24;
            this.MoveLeft.UseVisualStyleBackColor = false;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.BackColor = System.Drawing.Color.Red;
            this.MoveDown.BackgroundImage = global::Procrastinator.Properties.Resources.Go_Down;
            this.MoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveDown.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoveDown.Location = new System.Drawing.Point(403, 403);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(94, 30);
            this.MoveDown.TabIndex = 23;
            this.MoveDown.UseVisualStyleBackColor = false;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // Moveup
            // 
            this.Moveup.BackColor = System.Drawing.Color.Red;
            this.Moveup.BackgroundImage = global::Procrastinator.Properties.Resources.Goup;
            this.Moveup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Moveup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Moveup.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moveup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Moveup.Location = new System.Drawing.Point(403, 367);
            this.Moveup.Name = "Moveup";
            this.Moveup.Size = new System.Drawing.Size(94, 30);
            this.Moveup.TabIndex = 22;
            this.Moveup.UseVisualStyleBackColor = false;
            this.Moveup.Click += new System.EventHandler(this.Moveup_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Black;
            this.Title.BackgroundImage = global::Procrastinator.Properties.Resources.yea7;
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Location = new System.Drawing.Point(12, -2);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(587, 64);
            this.Title.TabIndex = 21;
            this.Title.UseVisualStyleBackColor = false;
            // 
            // Wukong
            // 
            this.Wukong.BackColor = System.Drawing.Color.Blue;
            this.Wukong.BackgroundImage = global::Procrastinator.Properties.Resources.T_Soldier_HID_071_Athena_Commando_M_Wukong_L;
            this.Wukong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Wukong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wukong.Location = new System.Drawing.Point(617, 280);
            this.Wukong.Name = "Wukong";
            this.Wukong.Size = new System.Drawing.Size(65, 65);
            this.Wukong.TabIndex = 20;
            this.Wukong.UseVisualStyleBackColor = false;
            this.Wukong.Click += new System.EventHandler(this.Wukong_Click);
            // 
            // AlpineAce
            // 
            this.AlpineAce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AlpineAce.BackgroundImage = global::Procrastinator.Properties.Resources.T_Soldier_HID_055_Athena_Commando_M_SkiDude_CAN_L;
            this.AlpineAce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AlpineAce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlpineAce.Location = new System.Drawing.Point(534, 280);
            this.AlpineAce.Name = "AlpineAce";
            this.AlpineAce.Size = new System.Drawing.Size(65, 65);
            this.AlpineAce.TabIndex = 19;
            this.AlpineAce.UseVisualStyleBackColor = false;
            this.AlpineAce.Click += new System.EventHandler(this.AlpineAce_Click);
            // 
            // JohnWick
            // 
            this.JohnWick.BackColor = System.Drawing.Color.Lime;
            this.JohnWick.BackgroundImage = global::Procrastinator.Properties.Resources.JohnWick;
            this.JohnWick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.JohnWick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JohnWick.Location = new System.Drawing.Point(617, 209);
            this.JohnWick.Name = "JohnWick";
            this.JohnWick.Size = new System.Drawing.Size(65, 65);
            this.JohnWick.TabIndex = 18;
            this.JohnWick.UseVisualStyleBackColor = false;
            this.JohnWick.Click += new System.EventHandler(this.JohnWick_Click);
            // 
            // Nutcracker
            // 
            this.Nutcracker.BackColor = System.Drawing.Color.Yellow;
            this.Nutcracker.BackgroundImage = global::Procrastinator.Properties.Resources.T_Soldier_HID_050_Athena_Commando_M_HolidayNutcracker_L;
            this.Nutcracker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nutcracker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nutcracker.Location = new System.Drawing.Point(534, 209);
            this.Nutcracker.Name = "Nutcracker";
            this.Nutcracker.Size = new System.Drawing.Size(65, 65);
            this.Nutcracker.TabIndex = 17;
            this.Nutcracker.UseVisualStyleBackColor = false;
            this.Nutcracker.Click += new System.EventHandler(this.Nutcracker_Click);
            // 
            // Raptor
            // 
            this.Raptor.BackColor = System.Drawing.Color.Red;
            this.Raptor.BackgroundImage = global::Procrastinator.Properties.Resources.T_Soldier_HID_031_Athena_Commando_M_Retro_L;
            this.Raptor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Raptor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Raptor.Location = new System.Drawing.Point(617, 138);
            this.Raptor.Name = "Raptor";
            this.Raptor.Size = new System.Drawing.Size(65, 65);
            this.Raptor.TabIndex = 16;
            this.Raptor.UseVisualStyleBackColor = false;
            this.Raptor.Click += new System.EventHandler(this.Raptor_Click);
            // 
            // Roblox
            // 
            this.Roblox.BackColor = System.Drawing.Color.Aqua;
            this.Roblox.BackgroundImage = global::Procrastinator.Properties.Resources.roblox_face_copy;
            this.Roblox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Roblox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Roblox.Location = new System.Drawing.Point(452, 280);
            this.Roblox.Name = "Roblox";
            this.Roblox.Size = new System.Drawing.Size(65, 65);
            this.Roblox.TabIndex = 15;
            this.Roblox.UseVisualStyleBackColor = false;
            this.Roblox.Click += new System.EventHandler(this.Roblox_Click);
            // 
            // Skeleton
            // 
            this.Skeleton.BackColor = System.Drawing.Color.Fuchsia;
            this.Skeleton.BackgroundImage = global::Procrastinator.Properties.Resources.Skull_trooper_jonesy_legendary_epic;
            this.Skeleton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Skeleton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skeleton.Location = new System.Drawing.Point(534, 138);
            this.Skeleton.Name = "Skeleton";
            this.Skeleton.Size = new System.Drawing.Size(65, 65);
            this.Skeleton.TabIndex = 14;
            this.Skeleton.UseVisualStyleBackColor = false;
            this.Skeleton.Click += new System.EventHandler(this.Skeleton_Click);
            // 
            // Fizzface
            // 
            this.Fizzface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Fizzface.BackgroundImage = global::Procrastinator.Properties.Resources.Fizz;
            this.Fizzface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fizzface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fizzface.Location = new System.Drawing.Point(452, 209);
            this.Fizzface.Name = "Fizzface";
            this.Fizzface.Size = new System.Drawing.Size(65, 65);
            this.Fizzface.TabIndex = 13;
            this.Fizzface.UseVisualStyleBackColor = false;
            this.Fizzface.Click += new System.EventHandler(this.Fizzface_Click);
            // 
            // SashSergeant
            // 
            this.SashSergeant.BackColor = System.Drawing.Color.Aqua;
            this.SashSergeant.BackgroundImage = global::Procrastinator.Properties.Resources.Sash_Sergeant;
            this.SashSergeant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SashSergeant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SashSergeant.Location = new System.Drawing.Point(452, 138);
            this.SashSergeant.Name = "SashSergeant";
            this.SashSergeant.Size = new System.Drawing.Size(65, 65);
            this.SashSergeant.TabIndex = 12;
            this.SashSergeant.UseVisualStyleBackColor = false;
            this.SashSergeant.Click += new System.EventHandler(this.SashSergeant_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.help.BackgroundImage = global::Procrastinator.Properties.Resources.Help;
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.help.Location = new System.Drawing.Point(452, 68);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(230, 55);
            this.help.TabIndex = 10;
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.play.BackgroundImage = global::Procrastinator.Properties.Resources.Game;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play.Location = new System.Drawing.Point(452, 68);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(111, 55);
            this.play.TabIndex = 9;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Down
            // 
            this.Down.BackColor = System.Drawing.Color.Red;
            this.Down.BackgroundImage = global::Procrastinator.Properties.Resources.Down;
            this.Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Down.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Down.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Down.Location = new System.Drawing.Point(303, 403);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(94, 30);
            this.Down.TabIndex = 8;
            this.Down.UseVisualStyleBackColor = false;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Up
            // 
            this.Up.BackColor = System.Drawing.Color.Red;
            this.Up.BackgroundImage = global::Procrastinator.Properties.Resources.Up;
            this.Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Up.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Up.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Up.Location = new System.Drawing.Point(203, 403);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(94, 30);
            this.Up.TabIndex = 7;
            this.Up.UseVisualStyleBackColor = false;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.Red;
            this.Left.BackgroundImage = global::Procrastinator.Properties.Resources.Left;
            this.Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Left.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Left.Location = new System.Drawing.Point(103, 403);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(94, 30);
            this.Left.TabIndex = 6;
            this.Left.UseVisualStyleBackColor = false;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.Red;
            this.Right.BackgroundImage = global::Procrastinator.Properties.Resources.Right;
            this.Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Right.Location = new System.Drawing.Point(3, 403);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(94, 30);
            this.Right.TabIndex = 5;
            this.Right.UseVisualStyleBackColor = false;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Small
            // 
            this.Small.BackColor = System.Drawing.Color.Red;
            this.Small.BackgroundImage = global::Procrastinator.Properties.Resources.cooltext285364886644189;
            this.Small.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Small.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Small.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Small.Location = new System.Drawing.Point(303, 367);
            this.Small.Name = "Small";
            this.Small.Size = new System.Drawing.Size(94, 30);
            this.Small.TabIndex = 4;
            this.Small.UseVisualStyleBackColor = false;
            this.Small.Click += new System.EventHandler(this.Small_Click);
            // 
            // Big
            // 
            this.Big.BackColor = System.Drawing.Color.Red;
            this.Big.BackgroundImage = global::Procrastinator.Properties.Resources.cooltext285364874460311;
            this.Big.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Big.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Big.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Big.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Big.Location = new System.Drawing.Point(203, 367);
            this.Big.Name = "Big";
            this.Big.Size = new System.Drawing.Size(94, 30);
            this.Big.TabIndex = 3;
            this.Big.UseVisualStyleBackColor = false;
            this.Big.Click += new System.EventHandler(this.Big_Click);
            // 
            // Slow
            // 
            this.Slow.BackColor = System.Drawing.Color.Red;
            this.Slow.BackgroundImage = global::Procrastinator.Properties.Resources.Slower;
            this.Slow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Slow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slow.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Slow.Location = new System.Drawing.Point(103, 367);
            this.Slow.Name = "Slow";
            this.Slow.Size = new System.Drawing.Size(94, 30);
            this.Slow.TabIndex = 2;
            this.Slow.UseVisualStyleBackColor = false;
            this.Slow.Click += new System.EventHandler(this.Slow_Click);
            // 
            // Fast
            // 
            this.Fast.BackColor = System.Drawing.Color.Red;
            this.Fast.BackgroundImage = global::Procrastinator.Properties.Resources.Faster;
            this.Fast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fast.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fast.Location = new System.Drawing.Point(3, 367);
            this.Fast.Name = "Fast";
            this.Fast.Size = new System.Drawing.Size(94, 30);
            this.Fast.TabIndex = 1;
            this.Fast.UseVisualStyleBackColor = false;
            this.Fast.Click += new System.EventHandler(this.Fast_Click);
            // 
            // Backcolor
            // 
            this.Backcolor.Enabled = true;
            this.Backcolor.Tick += new System.EventHandler(this.Backcolor_Tick);
            // 
            // TheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(694, 443);
            this.Controls.Add(this.Spinl);
            this.Controls.Add(this.Spinr);
            this.Controls.Add(this.MoveRight);
            this.Controls.Add(this.MoveLeft);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.Moveup);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Wukong);
            this.Controls.Add(this.AlpineAce);
            this.Controls.Add(this.JohnWick);
            this.Controls.Add(this.Nutcracker);
            this.Controls.Add(this.Raptor);
            this.Controls.Add(this.Roblox);
            this.Controls.Add(this.Skeleton);
            this.Controls.Add(this.Fizzface);
            this.Controls.Add(this.SashSergeant);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.help);
            this.Controls.Add(this.play);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Small);
            this.Controls.Add(this.Big);
            this.Controls.Add(this.Slow);
            this.Controls.Add(this.Fast);
            this.Controls.Add(this.Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TheForm";
            this.Text = "TheForm";
            this.Border.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.face)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.PictureBox face;
        private System.Windows.Forms.Button Fast;
        private System.Windows.Forms.Button Slow;
        private System.Windows.Forms.Button Big;
        private System.Windows.Forms.Button Small;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Timer topup;
        private System.Windows.Forms.Timer topdown;
        private System.Windows.Forms.Timer leftright;
        private System.Windows.Forms.Timer leftleft;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button SashSergeant;
        private System.Windows.Forms.Button Fizzface;
        private System.Windows.Forms.Button Skeleton;
        private System.Windows.Forms.Button Roblox;
        private System.Windows.Forms.Button Raptor;
        private System.Windows.Forms.Button Nutcracker;
        private System.Windows.Forms.Button JohnWick;
        private System.Windows.Forms.Button AlpineAce;
        private System.Windows.Forms.Button Wukong;
        private System.Windows.Forms.Button Title;
        private System.Windows.Forms.Button Moveup;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button Spinr;
        private System.Windows.Forms.Button Spinl;
        private System.Windows.Forms.Timer Backcolor;
    }
}

