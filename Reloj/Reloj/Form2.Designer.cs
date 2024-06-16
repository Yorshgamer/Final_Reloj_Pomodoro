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
            btnStop = new Button();
            btnStart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboxHoras = new ComboBox();
            cboxMinutos = new ComboBox();
            cboxSegundos = new ComboBox();
            timer2 = new System.Windows.Forms.Timer(components);
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Unispace", 55F, FontStyle.Bold);
            lblTimer.Location = new Point(11, 77);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(398, 89);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "00:00:00";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(221, 178);
            btnStop.Margin = new Padding(3, 2, 3, 2);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(82, 22);
            btnStop.TabIndex = 2;
            btnStop.Text = "Detener";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(49, 178);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(82, 22);
            btnStart.TabIndex = 1;
            btnStart.Text = "Iniciar";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Horas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Minutos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 19);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Segundos";
            // 
            // cboxHoras
            // 
            cboxHoras.FormattingEnabled = true;
            cboxHoras.Location = new Point(12, 37);
            cboxHoras.Name = "cboxHoras";
            cboxHoras.Size = new Size(121, 23);
            cboxHoras.TabIndex = 6;
            // 
            // cboxMinutos
            // 
            cboxMinutos.FormattingEnabled = true;
            cboxMinutos.Location = new Point(147, 37);
            cboxMinutos.Name = "cboxMinutos";
            cboxMinutos.Size = new Size(121, 23);
            cboxMinutos.TabIndex = 7;
            // 
            // cboxSegundos
            // 
            cboxSegundos.FormattingEnabled = true;
            cboxSegundos.Location = new Point(288, 37);
            cboxSegundos.Name = "cboxSegundos";
            cboxSegundos.Size = new Size(121, 23);
            cboxSegundos.TabIndex = 8;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(11, 221);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 22);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 254);
            Controls.Add(btnVolver);
            Controls.Add(cboxSegundos);
            Controls.Add(cboxMinutos);
            Controls.Add(cboxHoras);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblTimer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "TEMPORIZADOR";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private Button btnStop;
        private Button btnStart;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboxHoras;
        private ComboBox cboxMinutos;
        private ComboBox cboxSegundos;
        private System.Windows.Forms.Timer timer2;
        private Button btnVolver;
    }
}