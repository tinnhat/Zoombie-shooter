
namespace zombie_shooter
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
            this.components = new System.ComponentModel.Container();
            this.labelAmmo = new System.Windows.Forms.Label();
            this.labelKill = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarHeal = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.Game_menu = new System.Windows.Forms.GroupBox();
            this.labelQuit = new System.Windows.Forms.Label();
            this.labelRestart = new System.Windows.Forms.Label();
            this.labelGame = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.Game_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAmmo
            // 
            this.labelAmmo.AutoSize = true;
            this.labelAmmo.ForeColor = System.Drawing.Color.White;
            this.labelAmmo.Location = new System.Drawing.Point(28, 22);
            this.labelAmmo.Name = "labelAmmo";
            this.labelAmmo.Size = new System.Drawing.Size(57, 20);
            this.labelAmmo.TabIndex = 0;
            this.labelAmmo.Text = "Ammo:";
            // 
            // labelKill
            // 
            this.labelKill.AutoSize = true;
            this.labelKill.ForeColor = System.Drawing.Color.White;
            this.labelKill.Location = new System.Drawing.Point(315, 22);
            this.labelKill.Name = "labelKill";
            this.labelKill.Size = new System.Drawing.Size(33, 20);
            this.labelKill.TabIndex = 0;
            this.labelKill.Text = "Kill:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(653, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Health";
            // 
            // progressBarHeal
            // 
            this.progressBarHeal.Location = new System.Drawing.Point(726, 22);
            this.progressBarHeal.Name = "progressBarHeal";
            this.progressBarHeal.Size = new System.Drawing.Size(182, 20);
            this.progressBarHeal.TabIndex = 1;
            this.progressBarHeal.Value = 100;
            // 
            // player
            // 
            this.player.Image = global::zombie_shooter.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(124, 316);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Game_menu
            // 
            this.Game_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Game_menu.Controls.Add(this.labelQuit);
            this.Game_menu.Controls.Add(this.labelRestart);
            this.Game_menu.Controls.Add(this.labelGame);
            this.Game_menu.Controls.Add(this.labelGameOver);
            this.Game_menu.Controls.Add(this.labelStart);
            this.Game_menu.ForeColor = System.Drawing.Color.White;
            this.Game_menu.Location = new System.Drawing.Point(315, 207);
            this.Game_menu.Name = "Game_menu";
            this.Game_menu.Size = new System.Drawing.Size(271, 156);
            this.Game_menu.TabIndex = 3;
            this.Game_menu.TabStop = false;
            this.Game_menu.Text = "Menu";
            // 
            // labelQuit
            // 
            this.labelQuit.AutoSize = true;
            this.labelQuit.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuit.ForeColor = System.Drawing.Color.White;
            this.labelQuit.Location = new System.Drawing.Point(108, 109);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(45, 22);
            this.labelQuit.TabIndex = 0;
            this.labelQuit.Text = "Quit";
            this.labelQuit.Click += new System.EventHandler(this.labelQuit_Click);
            // 
            // labelRestart
            // 
            this.labelRestart.AutoSize = true;
            this.labelRestart.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRestart.ForeColor = System.Drawing.Color.White;
            this.labelRestart.Location = new System.Drawing.Point(94, 71);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(73, 22);
            this.labelRestart.TabIndex = 0;
            this.labelRestart.Text = "Restart";
            this.labelRestart.Click += new System.EventHandler(this.labelRestart_Click);
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGame.ForeColor = System.Drawing.Color.Red;
            this.labelGame.Location = new System.Drawing.Point(25, 23);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(212, 32);
            this.labelGame.TabIndex = 0;
            this.labelGame.Text = "Zombie Shooter";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGameOver.ForeColor = System.Drawing.Color.Red;
            this.labelGameOver.Location = new System.Drawing.Point(59, 23);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(151, 32);
            this.labelGameOver.TabIndex = 0;
            this.labelGameOver.Text = "Game Over";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStart.Location = new System.Drawing.Point(108, 71);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(53, 22);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Start";
            this.labelStart.Click += new System.EventHandler(this.labelStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(921, 706);
            this.Controls.Add(this.player);
            this.Controls.Add(this.Game_menu);
            this.Controls.Add(this.progressBarHeal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelKill);
            this.Controls.Add(this.labelAmmo);
            this.Name = "Form1";
            this.Text = "Zombie Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.Game_menu.ResumeLayout(false);
            this.Game_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelAmmo;
        public System.Windows.Forms.Label labelKill;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ProgressBar progressBarHeal;
        public System.Windows.Forms.PictureBox player;
        public System.Windows.Forms.Timer timerGame;
        public System.Windows.Forms.GroupBox Game_menu;
        public System.Windows.Forms.Label labelQuit;
        public System.Windows.Forms.Label labelRestart;
        public System.Windows.Forms.Label labelStart;
        public System.Windows.Forms.Label labelGameOver;
        public System.Windows.Forms.Label labelGame;
    }
}

