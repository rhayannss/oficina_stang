using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficina_stang.CADASTRAR
{
    public partial class CAD_CARGO : Form
    {
        public CAD_CARGO()
        {
            InitializeComponent();
        }

        private void funcoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void CAD_CARGO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcoes'. Você pode movê-la ou removê-la conforme necessário.
            this.funcoesTableAdapter.Fill(this.bANCO.funcoes);
            funcoesBindingSource.AddNew();

        }
        int A = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            funcoesBindingSource.EndEdit();
            funcoesTableAdapter.Update(bANCO); 
            DialogResult X = MessageBox.Show("DESEJA ADICIONAR OUTRO CARGO?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (X == DialogResult.Yes)
            {
                A = 1;
                funcoesBindingSource.AddNew();

            }
            else
            {
                A = 0;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A = 0;
            Close();
        }

        private void CAD_CARGO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (A == 1)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                TABELAS.TAB_CARGO TC = new TABELAS.TAB_CARGO();
                TC.A = 0;
            }
        }
    }
}
