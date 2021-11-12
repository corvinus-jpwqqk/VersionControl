
namespace week08
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonCar = new System.Windows.Forms.Button();
            this.buttonBall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBallColor = new System.Windows.Forms.Button();
            this.buttonPresent = new System.Windows.Forms.Button();
            this.buttonPresentColor1 = new System.Windows.Forms.Button();
            this.buttonPresentColor2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 259);
            this.panel1.TabIndex = 0;
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
            this.buttonCar.Location = new System.Drawing.Point(13, 278);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Size = new System.Drawing.Size(130, 50);
            this.buttonCar.TabIndex = 1;
            this.buttonCar.Text = "CAR";
            this.buttonCar.UseVisualStyleBackColor = true;
            this.buttonCar.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // buttonBall
            // 
            this.buttonBall.Location = new System.Drawing.Point(13, 334);
            this.buttonBall.Name = "buttonBall";
            this.buttonBall.Size = new System.Drawing.Size(130, 50);
            this.buttonBall.TabIndex = 2;
            this.buttonBall.Text = "BALL";
            this.buttonBall.UseVisualStyleBackColor = true;
            this.buttonBall.Click += new System.EventHandler(this.buttonBall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // buttonBallColor
            // 
            this.buttonBallColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBallColor.Location = new System.Drawing.Point(149, 334);
            this.buttonBallColor.Name = "buttonBallColor";
            this.buttonBallColor.Size = new System.Drawing.Size(130, 50);
            this.buttonBallColor.TabIndex = 4;
            this.buttonBallColor.UseVisualStyleBackColor = false;
            this.buttonBallColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonPresent
            // 
            this.buttonPresent.Location = new System.Drawing.Point(13, 388);
            this.buttonPresent.Name = "buttonPresent";
            this.buttonPresent.Size = new System.Drawing.Size(130, 50);
            this.buttonPresent.TabIndex = 5;
            this.buttonPresent.Text = "PRESENT";
            this.buttonPresent.UseVisualStyleBackColor = true;
            this.buttonPresent.Click += new System.EventHandler(this.buttonPresent_Click);
            // 
            // buttonPresentColor1
            // 
            this.buttonPresentColor1.BackColor = System.Drawing.Color.Maroon;
            this.buttonPresentColor1.Location = new System.Drawing.Point(149, 388);
            this.buttonPresentColor1.Name = "buttonPresentColor1";
            this.buttonPresentColor1.Size = new System.Drawing.Size(130, 50);
            this.buttonPresentColor1.TabIndex = 6;
            this.buttonPresentColor1.UseVisualStyleBackColor = false;
            this.buttonPresentColor1.Click += new System.EventHandler(this.buttonPresentColor1_Click);
            // 
            // buttonPresentColor2
            // 
            this.buttonPresentColor2.BackColor = System.Drawing.Color.Yellow;
            this.buttonPresentColor2.Location = new System.Drawing.Point(285, 388);
            this.buttonPresentColor2.Name = "buttonPresentColor2";
            this.buttonPresentColor2.Size = new System.Drawing.Size(130, 50);
            this.buttonPresentColor2.TabIndex = 7;
            this.buttonPresentColor2.UseVisualStyleBackColor = false;
            this.buttonPresentColor2.Click += new System.EventHandler(this.buttonPresentColor2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 450);
            this.Controls.Add(this.buttonPresentColor2);
            this.Controls.Add(this.buttonPresentColor1);
            this.Controls.Add(this.buttonPresent);
            this.Controls.Add(this.buttonBallColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBall);
            this.Controls.Add(this.buttonCar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button buttonCar;
        private System.Windows.Forms.Button buttonBall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBallColor;
        private System.Windows.Forms.Button buttonPresent;
        private System.Windows.Forms.Button buttonPresentColor1;
        private System.Windows.Forms.Button buttonPresentColor2;
    }
}

