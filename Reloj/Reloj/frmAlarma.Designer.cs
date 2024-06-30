namespace Reloj
{
    partial class frmAlarma
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
            cbHoras = new ComboBox();
            cbMinutos = new ComboBox();
            clbDias = new CheckedListBox();
            btnGuardar = new Button();
            rtbAlarmas = new RichTextBox();
            SuspendLayout();
            // 
            // cbHoras
            // 
            cbHoras.FormattingEnabled = true;
            cbHoras.Location = new Point(69, 39);
            cbHoras.Name = "cbHoras";
            cbHoras.Size = new Size(151, 28);
            cbHoras.TabIndex = 0;
            // 
            // cbMinutos
            // 
            cbMinutos.FormattingEnabled = true;
            cbMinutos.Location = new Point(241, 39);
            cbMinutos.Name = "cbMinutos";
            cbMinutos.Size = new Size(151, 28);
            cbMinutos.TabIndex = 1;
            // 
            // clbDias
            // 
            clbDias.FormattingEnabled = true;
            clbDias.Location = new Point(84, 135);
            clbDias.Name = "clbDias";
            clbDias.Size = new Size(150, 114);
            clbDias.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(67, 308);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // rtbAlarmas
            // 
            rtbAlarmas.Location = new Point(448, 39);
            rtbAlarmas.Name = "rtbAlarmas";
            rtbAlarmas.Size = new Size(308, 327);
            rtbAlarmas.TabIndex = 4;
            rtbAlarmas.Text = "";
            // 
            // frmAlarma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbAlarmas);
            Controls.Add(btnGuardar);
            Controls.Add(clbDias);
            Controls.Add(cbMinutos);
            Controls.Add(cbHoras);
            Name = "frmAlarma";
            Text = "Alarma";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbHoras;
        private ComboBox cbMinutos;
        private CheckedListBox clbDias;
        private Button btnGuardar;
        private RichTextBox rtbAlarmas;
    }
}