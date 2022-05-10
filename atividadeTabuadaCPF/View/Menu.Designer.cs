
namespace atividadeTabuadaCPF.View
{
    partial class Menu
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
            this.btnTabuada = new System.Windows.Forms.Button();
            this.btnCPF = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTabuada
            // 
            this.btnTabuada.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTabuada.Location = new System.Drawing.Point(76, 119);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(316, 50);
            this.btnTabuada.TabIndex = 0;
            this.btnTabuada.Text = "Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // btnCPF
            // 
            this.btnCPF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCPF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCPF.Location = new System.Drawing.Point(76, 201);
            this.btnCPF.Name = "btnCPF";
            this.btnCPF.Size = new System.Drawing.Size(316, 50);
            this.btnCPF.TabIndex = 1;
            this.btnCPF.Text = "Validar CPF";
            this.btnCPF.UseVisualStyleBackColor = true;
            this.btnCPF.Click += new System.EventHandler(this.btnCPF_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(76, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(316, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Atividades Tabuada e CPF";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCPF);
            this.Controls.Add(this.btnTabuada);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.Button btnCPF;
        private System.Windows.Forms.Label lblTitulo;
    }
}