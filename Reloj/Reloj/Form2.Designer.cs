namespace Reloj
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            lblTimer = new Label();
            btnStart = new Button();
            btnStop = new Button();
            txtTime = new TextBox();
            btnSetTime = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(168, 105);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(63, 20);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "00:00:00";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(56, 237);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Iniciar";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(253, 237);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 2;
            btnStop.Text = "Detener";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(146, 155);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(125, 27);
            txtTime.TabIndex = 3;
            // 
            // btnSetTime
            // 
            btnSetTime.Location = new Point(157, 188);
            btnSetTime.Name = "btnSetTime";
            btnSetTime.Size = new Size(94, 29);
            btnSetTime.TabIndex = 4;
            btnSetTime.Text = "Set";
            btnSetTime.UseVisualStyleBackColor = true;
            btnSetTime.Click += btnSetTime_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSetTime);
            Controls.Add(txtTime);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblTimer);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private Button btnStart;
        private Button btnStop;
        private TextBox txtTime;
        private Button btnSetTime;
        private System.Windows.Forms.Timer timer2;
    }
}