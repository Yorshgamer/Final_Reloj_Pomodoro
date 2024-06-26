﻿namespace Reloj
{
    partial class frmReloj
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
            components = new System.ComponentModel.Container();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnTemporizador = new Button();
            lblFecha = new Label();
            btnCronometro = new Button();
            btnPomodoro = new Button();
            btnAlarma = new Button();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Unispace", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.Black;
            lblHora.Location = new Point(80, 61);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(644, 144);
            lblHora.TabIndex = 0;
            lblHora.Text = "00:00:00";
            // 
            // btnTemporizador
            // 
            btnTemporizador.BackColor = Color.FromArgb(0, 192, 192);
            btnTemporizador.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTemporizador.ForeColor = SystemColors.WindowText;
            btnTemporizador.Location = new Point(66, 291);
            btnTemporizador.Name = "btnTemporizador";
            btnTemporizador.Size = new Size(151, 48);
            btnTemporizador.TabIndex = 1;
            btnTemporizador.Text = "Temporizador";
            btnTemporizador.UseVisualStyleBackColor = false;
            btnTemporizador.Click += button1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Unispace", 20F, FontStyle.Bold);
            lblFecha.ForeColor = Color.LightSteelBlue;
            lblFecha.Location = new Point(107, 215);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(81, 41);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "...";
            // 
            // btnCronometro
            // 
            btnCronometro.BackColor = Color.FromArgb(0, 192, 192);
            btnCronometro.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCronometro.ForeColor = SystemColors.WindowText;
            btnCronometro.Location = new Point(255, 291);
            btnCronometro.Name = "btnCronometro";
            btnCronometro.Size = new Size(145, 48);
            btnCronometro.TabIndex = 3;
            btnCronometro.Text = "Cronometro";
            btnCronometro.UseVisualStyleBackColor = false;
            btnCronometro.Click += btnCronometro_Click;
            // 
            // btnPomodoro
            // 
            btnPomodoro.BackColor = Color.FromArgb(0, 192, 192);
            btnPomodoro.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPomodoro.ForeColor = SystemColors.WindowText;
            btnPomodoro.Location = new Point(440, 291);
            btnPomodoro.Name = "btnPomodoro";
            btnPomodoro.Size = new Size(119, 48);
            btnPomodoro.TabIndex = 4;
            btnPomodoro.Text = "Pomodoro";
            btnPomodoro.UseVisualStyleBackColor = false;
            btnPomodoro.Click += btnPomodoro_Click;
            // 
            // btnAlarma
            // 
            btnAlarma.BackColor = Color.FromArgb(0, 192, 192);
            btnAlarma.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlarma.ForeColor = SystemColors.WindowText;
            btnAlarma.Location = new Point(596, 291);
            btnAlarma.Name = "btnAlarma";
            btnAlarma.Size = new Size(119, 48);
            btnAlarma.TabIndex = 5;
            btnAlarma.Text = "Alarma";
            btnAlarma.UseVisualStyleBackColor = false;
            btnAlarma.Click += btnAlarma_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(790, 451);
            Controls.Add(btnAlarma);
            Controls.Add(btnPomodoro);
            Controls.Add(btnCronometro);
            Controls.Add(lblFecha);
            Controls.Add(btnTemporizador);
            Controls.Add(lblHora);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reloj";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Button btnTemporizador;
        private Label lblFecha;
        private Button btnCronometro;
        private Button btnPomodoro;
        private Button btnAlarma;
    }
}
