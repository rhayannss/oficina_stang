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
    public partial class CAD_FAZENDA : Form
    {
        public CAD_FAZENDA()
        {
            InitializeComponent();
        }

        private void fazendasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fazendasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        public int id;
        private void CAD_FAZENDA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.fazendas'. Você pode movê-la ou removê-la conforme necessário.
            this.fazendasTableAdapter.Fill(this.bANCO.fazendas);
            fazendasBindingSource.AddNew();
            id_clienteTextBox.Text = id.ToString();

        }
        int A = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            fazendasBindingSource.EndEdit();
            fazendasTableAdapter.Update(bANCO);
            if (MessageBox.Show("DESEJA ADICIONAR OUTRA FAZENDA?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                A = 1;
                fazendasBindingSource.AddNew();
                id_clienteTextBox.Text = id.ToString();
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

        private void CAD_FAZENDA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (A == 1)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
