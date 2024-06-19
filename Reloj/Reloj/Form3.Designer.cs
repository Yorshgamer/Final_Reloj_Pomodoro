namespace Reloj
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            btnVolver = new Button();
            timer3 = new System.Windows.Forms.Timer(components);
            lblCronometro = new Label();
            pbPlay = new PictureBox();
            pbReset = new PictureBox();
            pbStop = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPlay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStop).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(66, 461);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // lblCronometro
            // 
            lblCronometro.AutoSize = true;
            lblCronometro.Font = new Font("Unispace", 55F, FontStyle.Bold);
            lblCronometro.Location = new Point(66, 63);
            lblCronometro.Name = "lblCronometro";
            lblCronometro.Size = new Size(663, 110);
            lblCronometro.TabIndex = 12;
            lblCronometro.Text = "00:00:00:00";
            // 
            // pbPlay
            // 
            pbPlay.Image = (Image)resources.GetObject("pbPlay.Image");
            pbPlay.Location = new Point(119, 249);
            pbPlay.Margin = new Padding(3, 4, 3, 4);
            pbPlay.Name = "pbPlay";
            pbPlay.Size = new Size(94, 103);
            pbPlay.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlay.TabIndex = 13;
            pbPlay.TabStop = false;
            pbPlay.Click += pbPlay_Click;
            // 
            // pbReset
            // 
            pbReset.Image = (Image)resources.GetObject("pbReset.Image");
            pbReset.Location = new Point(530, 249);
            pbReset.Margin = new Padding(3, 4, 3, 4);
            pbReset.Name = "pbReset";
            pbReset.Size = new Size(94, 103);
            pbReset.SizeMode = PictureBoxSizeMode.StretchImage;
            pbReset.TabIndex = 14;
            pbReset.TabStop = false;
            pbReset.Click += pbReset_Click;
            // 
            // pbStop
            // 
            pbStop.Image = (Image)resources.GetObject("pbStop.Image");
            pbStop.Location = new Point(326, 249);
            pbStop.Margin = new Padding(3, 4, 3, 4);
            pbStop.Name = "pbStop";
            pbStop.Size = new Size(94, 103);
            pbStop.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStop.TabIndex = 15;
            pbStop.TabStop = false;
            pbStop.Click += pbStop_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 521);
            Controls.Add(pbStop);
            Controls.Add(pbReset);
            Controls.Add(pbPlay);
            Controls.Add(lblCronometro);
            Controls.Add(btnVolver);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "CRONOMETRO";
            ((System.ComponentModel.ISupportInitialize)pbPlay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private System.Windows.Forms.Timer timer3;
        private Label lblCronometro;
        private PictureBox pbPlay;
        private PictureBox pbReset;
        private PictureBox pbStop;
    }
}