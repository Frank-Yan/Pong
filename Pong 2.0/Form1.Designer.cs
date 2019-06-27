namespace PongV2
{
    partial class PongForm
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
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.msOptions = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblWins1 = new System.Windows.Forms.Label();
            this.lblWins2 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            this.msOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGame
            // 
            this.pbGame.BackColor = System.Drawing.Color.Black;
            this.pbGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGame.Location = new System.Drawing.Point(16, 33);
            this.pbGame.Margin = new System.Windows.Forms.Padding(4);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(883, 492);
            this.pbGame.TabIndex = 0;
            this.pbGame.TabStop = false;
            this.pbGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGame_Paint);
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.BackColor = System.Drawing.Color.Transparent;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScore1.Location = new System.Drawing.Point(296, 529);
            this.lblScore1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(39, 42);
            this.lblScore1.TabIndex = 1;
            this.lblScore1.Text = "0";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.Transparent;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScore2.Location = new System.Drawing.Point(577, 529);
            this.lblScore2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(39, 42);
            this.lblScore2.TabIndex = 2;
            this.lblScore2.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(360, 533);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 31);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(469, 533);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(88, 31);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // msOptions
            // 
            this.msOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.msOptions.Location = new System.Drawing.Point(0, 0);
            this.msOptions.Name = "msOptions";
            this.msOptions.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msOptions.Size = new System.Drawing.Size(912, 28);
            this.msOptions.TabIndex = 5;
            this.msOptions.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.saveGameToolStripMenuItem.Text = "Save Scores";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.loadGameToolStripMenuItem.Text = "Load Score";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblWins1
            // 
            this.lblWins1.AutoSize = true;
            this.lblWins1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWins1.Location = new System.Drawing.Point(16, 554);
            this.lblWins1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWins1.Name = "lblWins1";
            this.lblWins1.Size = new System.Drawing.Size(47, 17);
            this.lblWins1.TabIndex = 6;
            this.lblWins1.Text = "Wins: ";
            // 
            // lblWins2
            // 
            this.lblWins2.AutoSize = true;
            this.lblWins2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWins2.Location = new System.Drawing.Point(836, 554);
            this.lblWins2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWins2.Name = "lblWins2";
            this.lblWins2.Size = new System.Drawing.Size(43, 17);
            this.lblWins2.TabIndex = 7;
            this.lblWins2.Text = "Wins:";
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblP1.Location = new System.Drawing.Point(16, 529);
            this.lblP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(60, 17);
            this.lblP1.TabIndex = 8;
            this.lblP1.Text = "Player 1";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblP2.Location = new System.Drawing.Point(836, 533);
            this.lblP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(60, 17);
            this.lblP2.TabIndex = 9;
            this.lblP2.Text = "Player 2";
            // 
            // PongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(912, 578);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.lblWins2);
            this.Controls.Add(this.lblWins1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.msOptions);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.pbGame);
            this.KeyPreview = true;
            this.MainMenuStrip = this.msOptions;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PongForm";
            this.Text = " Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            this.msOptions.ResumeLayout(false);
            this.msOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.MenuStrip msOptions;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblWins1;
        private System.Windows.Forms.Label lblWins2;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
    }
}

