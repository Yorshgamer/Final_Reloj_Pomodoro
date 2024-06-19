namespace Reloj
{
    partial class Form5
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
            btnVolver = new Button();
            numHoras = new NumericUpDown();
            numMinutos = new NumericUpDown();
            chkLunes = new CheckBox();
            chkMartes = new CheckBox();
            chkMiercoles = new CheckBox();
            chkJueves = new CheckBox();
            chkViernes = new CheckBox();
            chkSabado = new CheckBox();
            chkDomingo = new CheckBox();
            btnGuardarAlarma = new Button();
            lstAlarmas = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numHoras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinutos).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(47, 382);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // numHoras
            // 
            numHoras.Location = new Point(36, 48);
            numHoras.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numHoras.Name = "numHoras";
            numHoras.Size = new Size(150, 27);
            numHoras.TabIndex = 1;
            // 
            // numMinutos
            // 
            numMinutos.Location = new Point(206, 48);
            numMinutos.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numMinutos.Name = "numMinutos";
            numMinutos.Size = new Size(150, 27);
            numMinutos.TabIndex = 2;
            // 
            // chkLunes
            // 
            chkLunes.AutoSize = true;
            chkLunes.Location = new Point(379, 48);
            chkLunes.Name = "chkLunes";
            chkLunes.Size = new Size(68, 24);
            chkLunes.TabIndex = 3;
            chkLunes.Text = "Lunes";
            chkLunes.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            chkMartes.AutoSize = true;
            chkMartes.Location = new Point(379, 78);
            chkMartes.Name = "chkMartes";
            chkMartes.Size = new Size(76, 24);
            chkMartes.TabIndex = 4;
            chkMartes.Text = "Martes";
            chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            chkMiercoles.AutoSize = true;
            chkMiercoles.Location = new Point(379, 108);
            chkMiercoles.Name = "chkMiercoles";
            chkMiercoles.Size = new Size(95, 24);
            chkMiercoles.TabIndex = 5;
            chkMiercoles.Text = "Miercoles";
            chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            chkJueves.AutoSize = true;
            chkJueves.Location = new Point(379, 138);
            chkJueves.Name = "chkJueves";
            chkJueves.Size = new Size(73, 24);
            chkJueves.TabIndex = 6;
            chkJueves.Text = "Jueves";
            chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            chkViernes.AutoSize = true;
            chkViernes.Location = new Point(379, 168);
            chkViernes.Name = "chkViernes";
            chkViernes.Size = new Size(79, 24);
            chkViernes.TabIndex = 7;
            chkViernes.Text = "Viernes";
            chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            chkSabado.AutoSize = true;
            chkSabado.Location = new Point(379, 198);
            chkSabado.Name = "chkSabado";
            chkSabado.Size = new Size(82, 24);
            chkSabado.TabIndex = 8;
            chkSabado.Text = "Sabado";
            chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkDomingo
            // 
            chkDomingo.AutoSize = true;
            chkDomingo.Location = new Point(379, 228);
            chkDomingo.Name = "chkDomingo";
            chkDomingo.Size = new Size(94, 24);
            chkDomingo.TabIndex = 9;
            chkDomingo.Text = "Domingo";
            chkDomingo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarAlarma
            // 
            btnGuardarAlarma.Location = new Point(121, 103);
            btnGuardarAlarma.Name = "btnGuardarAlarma";
            btnGuardarAlarma.Size = new Size(143, 29);
            btnGuardarAlarma.TabIndex = 10;
            btnGuardarAlarma.Text = "Guardar Alarma";
            btnGuardarAlarma.UseVisualStyleBackColor = true;
            // 
            // lstAlarmas
            // 
            lstAlarmas.FormattingEnabled = true;
            lstAlarmas.Location = new Point(36, 168);
            lstAlarmas.Name = "lstAlarmas";
            lstAlarmas.Size = new Size(320, 184);
            lstAlarmas.TabIndex = 11;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstAlarmas);
            Controls.Add(btnGuardarAlarma);
            Controls.Add(chkDomingo);
            Controls.Add(chkSabado);
            Controls.Add(chkViernes);
            Controls.Add(chkJueves);
            Controls.Add(chkMiercoles);
            Controls.Add(chkMartes);
            Controls.Add(chkLunes);
            Controls.Add(numMinutos);
            Controls.Add(numHoras);
            Controls.Add(btnVolver);
            Name = "Form5";
            Text = "ALARMA";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)numHoras).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private NumericUpDown numHoras;
        private NumericUpDown numMinutos;
        private CheckBox chkLunes;
        private CheckBox chkMartes;
        private CheckBox chkMiercoles;
        private CheckBox chkJueves;
        private CheckBox chkViernes;
        private CheckBox chkSabado;
        private CheckBox chkDomingo;
        private Button btnGuardarAlarma;
        private ListBox lstAlarmas;
    }
}