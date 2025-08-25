namespace GUI_YT_DLP
{
    partial class StartPage
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
            btnDescargar = new Button();
            label1 = new Label();
            txtUrl = new TextBox();
            btnAbrirCarpetas = new Button();
            txtRutaDeDescarga = new TextBox();
            SuspendLayout();
            // 
            // btnDescargar
            // 
            btnDescargar.Location = new Point(142, 186);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(75, 23);
            btnDescargar.TabIndex = 0;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 120);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Prueba de descarga";
            // 
            // txtUrl
            // 
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUrl.Location = new Point(223, 187);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(565, 23);
            txtUrl.TabIndex = 2;
            // 
            // btnAbrirCarpetas
            // 
            btnAbrirCarpetas.Location = new Point(90, 260);
            btnAbrirCarpetas.Name = "btnAbrirCarpetas";
            btnAbrirCarpetas.Size = new Size(127, 30);
            btnAbrirCarpetas.TabIndex = 3;
            btnAbrirCarpetas.Text = "Seleccionar Destino";
            btnAbrirCarpetas.UseVisualStyleBackColor = true;
            btnAbrirCarpetas.Click += btnAbrirCarpetas_Click;
            // 
            // txtRutaDeDescarga
            // 
            txtRutaDeDescarga.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtRutaDeDescarga.Location = new Point(223, 265);
            txtRutaDeDescarga.Name = "txtRutaDeDescarga";
            txtRutaDeDescarga.Size = new Size(565, 23);
            txtRutaDeDescarga.TabIndex = 4;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRutaDeDescarga);
            Controls.Add(btnAbrirCarpetas);
            Controls.Add(txtUrl);
            Controls.Add(label1);
            Controls.Add(btnDescargar);
            Name = "StartPage";
            Text = "StartPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDescargar;
        private Label label1;
        private TextBox txtUrl;
        private Button btnAbrirCarpetas;
        private TextBox txtRutaDeDescarga;
    }
}
