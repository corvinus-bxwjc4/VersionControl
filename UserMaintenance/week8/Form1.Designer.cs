
namespace week8
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonCar = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.buttonBall = new System.Windows.Forms.Button();
            this.buttonBallColor = new System.Windows.Forms.Button();
            this.buttonPresent = new System.Windows.Forms.Button();
            this.buttonRibbonColor = new System.Windows.Forms.Button();
            this.buttonBoxColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 221);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // buttonCar
            // 
            this.buttonCar.Location = new System.Drawing.Point(277, 275);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Size = new System.Drawing.Size(75, 23);
            this.buttonCar.TabIndex = 1;
            this.buttonCar.Text = "CAR";
            this.buttonCar.UseVisualStyleBackColor = true;
            this.buttonCar.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(274, 250);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(62, 13);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming text";
            // 
            // buttonBall
            // 
            this.buttonBall.Location = new System.Drawing.Point(277, 304);
            this.buttonBall.Name = "buttonBall";
            this.buttonBall.Size = new System.Drawing.Size(75, 23);
            this.buttonBall.TabIndex = 3;
            this.buttonBall.Text = "BALL";
            this.buttonBall.UseVisualStyleBackColor = true;
            this.buttonBall.Click += new System.EventHandler(this.buttonBall_Click);
            // 
            // buttonBallColor
            // 
            this.buttonBallColor.BackColor = System.Drawing.Color.Maroon;
            this.buttonBallColor.Location = new System.Drawing.Point(358, 304);
            this.buttonBallColor.Name = "buttonBallColor";
            this.buttonBallColor.Size = new System.Drawing.Size(75, 23);
            this.buttonBallColor.TabIndex = 4;
            this.buttonBallColor.UseVisualStyleBackColor = false;
            this.buttonBallColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonPresent
            // 
            this.buttonPresent.Location = new System.Drawing.Point(277, 333);
            this.buttonPresent.Name = "buttonPresent";
            this.buttonPresent.Size = new System.Drawing.Size(75, 23);
            this.buttonPresent.TabIndex = 5;
            this.buttonPresent.Text = "PRESENT";
            this.buttonPresent.UseVisualStyleBackColor = true;
            // 
            // buttonRibbonColor
            // 
            this.buttonRibbonColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRibbonColor.Location = new System.Drawing.Point(358, 333);
            this.buttonRibbonColor.Name = "buttonRibbonColor";
            this.buttonRibbonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonRibbonColor.TabIndex = 6;
            this.buttonRibbonColor.UseVisualStyleBackColor = false;
            this.buttonRibbonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonBoxColor
            // 
            this.buttonBoxColor.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonBoxColor.Location = new System.Drawing.Point(439, 333);
            this.buttonBoxColor.Name = "buttonBoxColor";
            this.buttonBoxColor.Size = new System.Drawing.Size(75, 23);
            this.buttonBoxColor.TabIndex = 7;
            this.buttonBoxColor.UseVisualStyleBackColor = false;
            this.buttonBoxColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBoxColor);
            this.Controls.Add(this.buttonRibbonColor);
            this.Controls.Add(this.buttonPresent);
            this.Controls.Add(this.buttonBallColor);
            this.Controls.Add(this.buttonBall);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.buttonCar);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button buttonCar;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button buttonBall;
        private System.Windows.Forms.Button buttonBallColor;
        private System.Windows.Forms.Button buttonPresent;
        private System.Windows.Forms.Button buttonRibbonColor;
        private System.Windows.Forms.Button buttonBoxColor;
    }
}

