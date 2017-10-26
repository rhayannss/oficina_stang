using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficina_stang.TABELAS
{
    public partial class TAB_MEDIDAS : Form
    {
        public TAB_MEDIDAS()
        {
            InitializeComponent();
        }

        private void medidasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medidasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void TAB_MEDIDAS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcoes'. Você pode movê-la ou removê-la conforme necessário.
            this.funcoesTableAdapter.Fill(this.bANCO.funcoes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.medidas'. Você pode movê-la ou removê-la conforme necessário.
            this.medidasTableAdapter.Fill(this.bANCO.medidas);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            medidasBindingSource.Filter = "unidade like '" + textBox1.Text + "'%";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_MEDIDAS CC = new CADASTRAR.CAD_MEDIDAS();
            CC.Show();
            medidasTableAdapter.Fill(bANCO.medidas);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEJA REALMENTE EXCLUIR?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    medidasBindingSource.RemoveCurrent();
                    medidasTableAdapter.Update(bANCO);
                }
            }
            catch
            {
                medidasTableAdapter.Fill(bANCO.medidas);
                MessageBox.Show("NÃO FOI POSSIVEL EXCLUIR POIS A UNIDADE DE MEDIDA ESTA SENDO USADA!", " ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            medidasTableAdapter.Fill(bANCO.medidas);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_MEDIDA DC = new ALTERAR.ALT_MEDIDA();
            DC.ASD = int.Parse(id_medidaTextBox.Text);
            DC.Show();
            medidasTableAdapter.Fill(bANCO.medidas);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TAB_MEDIDAS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer sair?\r", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
