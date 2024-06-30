namespace Reloj
{
    partial class frmAlarmaAlerta
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
            btnAceptar = new Button();
            btnPosponer = new Button();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(73, 47);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(123, 59);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += this.btnAceptar_Click;
            // 
            // btnPosponer
            // 
            btnPosponer.Location = new Point(213, 47);
            btnPosponer.Name = "btnPosponer";
            btnPosponer.Size = new Size(118, 59);
            btnPosponer.TabIndex = 1;
            btnPosponer.Text = "Posponer";
            btnPosponer.UseVisualStyleBackColor = true;
            btnPosponer.Click += this.btnPosponer_Click;
            // 
            // frmAlarmaAlerta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 164);
            Controls.Add(btnPosponer);
            Controls.Add(btnAceptar);
            Name = "frmAlarmaAlerta";
            Text = "frmAlarmaAlerta";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private Button btnPosponer;
    }
}