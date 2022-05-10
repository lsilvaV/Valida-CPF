using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeTabuadaCPF.View.CPF
{
    public partial class TelaCPF : Form
    {
        public TelaCPF()
        {
            InitializeComponent();
        }

        public void validarCPF()
        {
            if (string.IsNullOrEmpty(tbxCPF.Text))
            {
                MessageBox.Show("CPF é obrigatório", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxCPF.Focus();
                tbxCPF.SelectAll();
                return;
            }

            string cpfInformado = tbxCPF.Text.Replace(".", "").Replace("-", "");
            // lblResultado.Text = cpfInformado;


            if (cpfInformado.Length != 11)
            {
                lblResultado.Text = "Informe um CPF com 11 dígitos.";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            string cpf = cpfInformado.Substring(0, 9);

            int soma = 0;
            int valorRef = 10;

            for (int i = 0; i <= 8; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
                //soma += cpf[0] (1o num do CPF) * 10
                //soma += cpf[1] (2o num do CPF) * 9
                //soma += cpf[2] (2o num do CPF) * 8
            }

            int dv1 = (int)soma % 11;

            if (dv1 < 2)
            {
                dv1 = 0;
            }
            else
            {
                dv1 = 11 - dv1;
            }

            if (!cpfInformado.Substring(9, 1).Equals(dv1.ToString()))
            {
                lblResultado.Text = "Informe um CPF válido";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            cpf = cpf + dv1.ToString();
            valorRef = 11;
            soma = 0;

            for (int i = 0; i <= 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
                //soma += cpf[0] (1o num do CPF) * 10
                //soma += cpf[1] (2o num do CPF) * 9
                //soma += cpf[2] (2o num do CPF) * 8
            }

            int dv2 = (int)soma % 11;

            if (dv2 < 2)
            {
                dv2 = 0;
            }
            else
            {
                dv2 = 11 - dv2;
            }

            if (!cpfInformado.Substring(10, 1).Equals(dv2.ToString()))
            {
                lblResultado.Text = "Informe um CPF válido";
                lblResultado.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblResultado.Text = "CPF Válido";
                lblResultado.ForeColor = Color.Green;
                return;
            }


        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            validarCPF();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            
        }
    }
}
