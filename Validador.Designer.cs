
namespace ValidadorFE
{
    partial class Validador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_xml = new System.Windows.Forms.TextBox();
            this.bt_validador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_xml
            // 
            this.txt_xml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xml.Location = new System.Drawing.Point(13, 12);
            this.txt_xml.MaxLength = 1000000;
            this.txt_xml.Multiline = true;
            this.txt_xml.Name = "txt_xml";
            this.txt_xml.Size = new System.Drawing.Size(775, 304);
            this.txt_xml.TabIndex = 0;
            // 
            // bt_validador
            // 
            this.bt_validador.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_validador.Location = new System.Drawing.Point(360, 331);
            this.bt_validador.Name = "bt_validador";
            this.bt_validador.Size = new System.Drawing.Size(91, 29);
            this.bt_validador.TabIndex = 1;
            this.bt_validador.Text = "Validar XML";
            this.bt_validador.UseVisualStyleBackColor = true;
            this.bt_validador.Click += new System.EventHandler(this.bt_validador_Click);
            // 
            // Validador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.bt_validador);
            this.Controls.Add(this.txt_xml);
            this.Name = "Validador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validador de FE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_xml;
        private System.Windows.Forms.Button bt_validador;
    }
}

