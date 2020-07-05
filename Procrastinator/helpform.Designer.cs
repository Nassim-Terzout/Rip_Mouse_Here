namespace Procrastinator
{
    partial class helpform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpform));
            this.exit = new System.Windows.Forms.Button();
            this.LoadingText = new System.Windows.Forms.Label();
            this.LoadingTextTimer = new System.Windows.Forms.Timer(this.components);
            this.LoadingPicTimer = new System.Windows.Forms.Timer(this.components);
            this.helptxt = new System.Windows.Forms.Label();
            this.Fortnite = new System.Windows.Forms.PictureBox();
            this.Loadingpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Fortnite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loadingpic)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(578, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(55, 57);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // LoadingText
            // 
            this.LoadingText.BackColor = System.Drawing.Color.Black;
            this.LoadingText.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingText.ForeColor = System.Drawing.Color.White;
            this.LoadingText.Location = new System.Drawing.Point(0, 389);
            this.LoadingText.Name = "LoadingText";
            this.LoadingText.Size = new System.Drawing.Size(646, 72);
            this.LoadingText.TabIndex = 2;
            this.LoadingText.Text = "Loading";
            this.LoadingText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadingText.Click += new System.EventHandler(this.LoadingText_Click);
            // 
            // LoadingTextTimer
            // 
            this.LoadingTextTimer.Enabled = true;
            this.LoadingTextTimer.Tick += new System.EventHandler(this.LoadingTextTimer_Tick);
            // 
            // LoadingPicTimer
            // 
            this.LoadingPicTimer.Enabled = true;
            this.LoadingPicTimer.Tick += new System.EventHandler(this.LoadingPicTimer_Tick);
            // 
            // helptxt
            // 
            this.helptxt.BackColor = System.Drawing.Color.Red;
            this.helptxt.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helptxt.Location = new System.Drawing.Point(36, 87);
            this.helptxt.Name = "helptxt";
            this.helptxt.Size = new System.Drawing.Size(582, 362);
            this.helptxt.TabIndex = 3;
            this.helptxt.Text = resources.GetString("helptxt.Text");
            // 
            // Fortnite
            // 
            this.Fortnite.BackgroundImage = global::Procrastinator.Properties.Resources.fortnite_logo_02_ps4_us_10apr18;
            this.Fortnite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fortnite.Location = new System.Drawing.Point(88, 12);
            this.Fortnite.Name = "Fortnite";
            this.Fortnite.Size = new System.Drawing.Size(441, 70);
            this.Fortnite.TabIndex = 4;
            this.Fortnite.TabStop = false;
            // 
            // Loadingpic
            // 
            this.Loadingpic.BackColor = System.Drawing.Color.Black;
            this.Loadingpic.BackgroundImage = global::Procrastinator.Properties.Resources.Loading;
            this.Loadingpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Loadingpic.Location = new System.Drawing.Point(-7, -35);
            this.Loadingpic.Name = "Loadingpic";
            this.Loadingpic.Size = new System.Drawing.Size(698, 460);
            this.Loadingpic.TabIndex = 1;
            this.Loadingpic.TabStop = false;
            this.Loadingpic.Click += new System.EventHandler(this.Loadingpic_Click);
            // 
            // helpform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(645, 458);
            this.Controls.Add(this.LoadingText);
            this.Controls.Add(this.Loadingpic);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Fortnite);
            this.Controls.Add(this.helptxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "helpform";
            this.Text = "helpform";
            ((System.ComponentModel.ISupportInitialize)(this.Fortnite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loadingpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox Loadingpic;
        private System.Windows.Forms.Label LoadingText;
        private System.Windows.Forms.Timer LoadingTextTimer;
        private System.Windows.Forms.Timer LoadingPicTimer;
        private System.Windows.Forms.Label helptxt;
        private System.Windows.Forms.PictureBox Fortnite;
    }
}