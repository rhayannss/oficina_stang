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
    public partial class CAD_FUNCIONARIO : Form
    {
        public CAD_FUNCIONARIO()
        {
            InitializeComponent();
        }

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void CAD_FUNCIONARIO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcoes'. Você pode movê-la ou removê-la conforme necessário.
            this.funcoesTableAdapter.Fill(this.bANCO.funcoes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bANCO.funcionarios);
            funcionariosBindingSource.AddNew();

        }
        int A = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            funcionariosBindingSource.EndEdit();
            funcionariosTableAdapter.Update(bANCO); DialogResult X = MessageBox.Show("DESEJA ADICIONAR OUTRO FUNCIONARIO?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (X == DialogResult.Yes)
            {
                A = 1;
                funcionariosBindingSource.AddNew();

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

        private void CAD_FUNCIONARIO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (A == 1)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
