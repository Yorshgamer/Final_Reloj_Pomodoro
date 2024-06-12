namespace Reloj
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
            components = new System.ComponentModel.Container();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnTemporizador = new Button();
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
            btnTemporizador.Location = new Point(57, 272);
            btnTemporizador.Name = "btnTemporizador";
            btnTemporizador.Size = new Size(173, 99);
            btnTemporizador.TabIndex = 1;
            btnTemporizador.Text = "Temporizador";
            btnTemporizador.UseVisualStyleBackColor = false;
            btnTemporizador.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTemporizador);
            Controls.Add(lblHora);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Button btnTemporizador;
    }
}
