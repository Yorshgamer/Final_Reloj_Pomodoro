namespace Reloj
{
    partial class FormAlarma
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
            btnApagar = new Button();
            SuspendLayout();
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(71, 72);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(204, 91);
            btnApagar.TabIndex = 0;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // FormAlarma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 234);
            Controls.Add(btnApagar);
            Name = "FormAlarma";
            Text = "FormAlarma";
            ResumeLayout(false);
        }

        #endregion

        private Button btnApagar;
    }
}