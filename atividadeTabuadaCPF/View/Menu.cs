using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atividadeTabuadaCPF.View.Tabuada;
using atividadeTabuadaCPF.View.CPF;

namespace atividadeTabuadaCPF.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            Tabuada.TelaTabuada tabuada = new Tabuada.TelaTabuada();
            tabuada.ShowDialog();
        }

        private void btnCPF_Click(object sender, EventArgs e)
        {
            CPF.TelaCPF cpf = new CPF.TelaCPF();
            cpf.ShowDialog();
        }
    }
}
