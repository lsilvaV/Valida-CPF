
namespace atividadeTabuadaCPF.View.Tabuada
{
    partial class TelaTabuada
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.lbxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(21, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(113, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Tabuada";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.Location = new System.Drawing.Point(21, 75);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(111, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Calcular Tabuada:";
            // 
            // tbxNumero
            // 
            this.tbxNumero.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNumero.Location = new System.Drawing.Point(138, 72);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(69, 21);
            this.tbxNumero.TabIndex = 2;
            // 
            // lbxResultado
            // 
            this.lbxResultado.FormattingEnabled = true;
            this.lbxResultado.ItemHeight = 15;
            this.lbxResultado.Location = new System.Drawing.Point(272, 72);
            this.lbxResultado.Name = "lbxResultado";
            this.lbxResultado.Size = new System.Drawing.Size(292, 319);
            this.lbxResultado.TabIndex = 3;
            // 
            // TelaTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lbxResultado);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTitulo);
            this.KeyPreview = true;
            this.Name = "TelaTabuada";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaTabuada_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.ListBox lbxResultado;
    }
}