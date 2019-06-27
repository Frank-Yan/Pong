namespace PongV2
{
    partial class SettingsForm
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
            this.lblBallSpeed = new System.Windows.Forms.Label();
            this.lblPaddleSpeed = new System.Windows.Forms.Label();
            this.lblBallSize = new System.Windows.Forms.Label();
            this.lblPaddleSize = new System.Windows.Forms.Label();
            this.numBallSize = new System.Windows.Forms.NumericUpDown();
            this.numPaddleSize = new System.Windows.Forms.NumericUpDown();
            this.clrDialog = new System.Windows.Forms.ColorDialog();
            this.btnSelectColour = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbBallSpeed = new System.Windows.Forms.ComboBox();
            this.cmbPaddleSpeed = new System.Windows.Forms.ComboBox();
            this.numSetBalls = new System.Windows.Forms.NumericUpDown();
            this.lblNumBall = new System.Windows.Forms.Label();
            this.cBoxNormal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBallSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaddleSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetBalls)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBallSpeed
            // 
            this.lblBallSpeed.AutoSize = true;
            this.lblBallSpeed.Location = new System.Drawing.Point(44, 26);
            this.lblBallSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBallSpeed.Name = "lblBallSpeed";
            this.lblBallSpeed.Size = new System.Drawing.Size(76, 17);
            this.lblBallSpeed.TabIndex = 0;
            this.lblBallSpeed.Text = "Ball Speed";
            // 
            // lblPaddleSpeed
            // 
            this.lblPaddleSpeed.AutoSize = true;
            this.lblPaddleSpeed.Location = new System.Drawing.Point(43, 90);
            this.lblPaddleSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaddleSpeed.Name = "lblPaddleSpeed";
            this.lblPaddleSpeed.Size = new System.Drawing.Size(97, 17);
            this.lblPaddleSpeed.TabIndex = 1;
            this.lblPaddleSpeed.Text = "Paddle Speed";
            // 
            // lblBallSize
            // 
            this.lblBallSize.AutoSize = true;
            this.lblBallSize.Location = new System.Drawing.Point(44, 58);
            this.lblBallSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBallSize.Name = "lblBallSize";
            this.lblBallSize.Size = new System.Drawing.Size(62, 17);
            this.lblBallSize.TabIndex = 2;
            this.lblBallSize.Text = "Ball Size";
            // 
            // lblPaddleSize
            // 
            this.lblPaddleSize.AutoSize = true;
            this.lblPaddleSize.Location = new System.Drawing.Point(44, 122);
            this.lblPaddleSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaddleSize.Name = "lblPaddleSize";
            this.lblPaddleSize.Size = new System.Drawing.Size(83, 17);
            this.lblPaddleSize.TabIndex = 3;
            this.lblPaddleSize.Text = "Paddle Size";
            // 
            // numBallSize
            // 
            this.numBallSize.Location = new System.Drawing.Point(149, 55);
            this.numBallSize.Margin = new System.Windows.Forms.Padding(4);
            this.numBallSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBallSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBallSize.Name = "numBallSize";
            this.numBallSize.Size = new System.Drawing.Size(160, 22);
            this.numBallSize.TabIndex = 5;
            this.numBallSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPaddleSize
            // 
            this.numPaddleSize.Location = new System.Drawing.Point(149, 119);
            this.numPaddleSize.Margin = new System.Windows.Forms.Padding(4);
            this.numPaddleSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPaddleSize.Name = "numPaddleSize";
            this.numPaddleSize.Size = new System.Drawing.Size(160, 22);
            this.numPaddleSize.TabIndex = 7;
            this.numPaddleSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnSelectColour
            // 
            this.btnSelectColour.Location = new System.Drawing.Point(46, 222);
            this.btnSelectColour.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectColour.Name = "btnSelectColour";
            this.btnSelectColour.Size = new System.Drawing.Size(155, 28);
            this.btnSelectColour.TabIndex = 10;
            this.btnSelectColour.Text = "Select Game Color";
            this.btnSelectColour.UseVisualStyleBackColor = true;
            this.btnSelectColour.Click += new System.EventHandler(this.btnSelectColour_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(209, 222);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbBallSpeed
            // 
            this.cmbBallSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBallSpeed.FormattingEnabled = true;
            this.cmbBallSpeed.Items.AddRange(new object[] {
            "Fast",
            "Medium",
            "Slow"});
            this.cmbBallSpeed.Location = new System.Drawing.Point(147, 22);
            this.cmbBallSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBallSpeed.Name = "cmbBallSpeed";
            this.cmbBallSpeed.Size = new System.Drawing.Size(160, 24);
            this.cmbBallSpeed.TabIndex = 13;
            this.cmbBallSpeed.TabStop = false;
            // 
            // cmbPaddleSpeed
            // 
            this.cmbPaddleSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaddleSpeed.FormattingEnabled = true;
            this.cmbPaddleSpeed.Items.AddRange(new object[] {
            "Fast",
            "Medium",
            "Slow"});
            this.cmbPaddleSpeed.Location = new System.Drawing.Point(147, 86);
            this.cmbPaddleSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPaddleSpeed.Name = "cmbPaddleSpeed";
            this.cmbPaddleSpeed.Size = new System.Drawing.Size(160, 24);
            this.cmbPaddleSpeed.TabIndex = 14;
            // 
            // numSetBalls
            // 
            this.numSetBalls.Location = new System.Drawing.Point(149, 148);
            this.numSetBalls.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSetBalls.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSetBalls.Name = "numSetBalls";
            this.numSetBalls.Size = new System.Drawing.Size(160, 22);
            this.numSetBalls.TabIndex = 20;
            this.numSetBalls.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumBall
            // 
            this.lblNumBall.AutoSize = true;
            this.lblNumBall.Location = new System.Drawing.Point(44, 153);
            this.lblNumBall.Name = "lblNumBall";
            this.lblNumBall.Size = new System.Drawing.Size(85, 17);
            this.lblNumBall.TabIndex = 21;
            this.lblNumBall.Text = "Ball Number";
            // 
            // cBoxNormal
            // 
            this.cBoxNormal.AutoSize = true;
            this.cBoxNormal.Location = new System.Drawing.Point(46, 194);
            this.cBoxNormal.Name = "cBoxNormal";
            this.cBoxNormal.Size = new System.Drawing.Size(118, 21);
            this.cBoxNormal.TabIndex = 22;
            this.cBoxNormal.Text = "Normal Mode ";
            this.cBoxNormal.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 268);
            this.Controls.Add(this.cBoxNormal);
            this.Controls.Add(this.lblNumBall);
            this.Controls.Add(this.numSetBalls);
            this.Controls.Add(this.cmbPaddleSpeed);
            this.Controls.Add(this.cmbBallSpeed);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectColour);
            this.Controls.Add(this.numPaddleSize);
            this.Controls.Add(this.numBallSize);
            this.Controls.Add(this.lblPaddleSize);
            this.Controls.Add(this.lblBallSize);
            this.Controls.Add(this.lblPaddleSpeed);
            this.Controls.Add(this.lblBallSpeed);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.Text = "Pong Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numBallSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaddleSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetBalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBallSpeed;
        private System.Windows.Forms.Label lblPaddleSpeed;
        private System.Windows.Forms.Label lblBallSize;
        private System.Windows.Forms.Label lblPaddleSize;
        private System.Windows.Forms.NumericUpDown numBallSize;
        private System.Windows.Forms.NumericUpDown numPaddleSize;
        private System.Windows.Forms.ColorDialog clrDialog;
        private System.Windows.Forms.Button btnSelectColour;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbBallSpeed;
        private System.Windows.Forms.ComboBox cmbPaddleSpeed;
        private System.Windows.Forms.NumericUpDown numSetBalls;
        private System.Windows.Forms.Label lblNumBall;
        private System.Windows.Forms.CheckBox cBoxNormal;
    }
}