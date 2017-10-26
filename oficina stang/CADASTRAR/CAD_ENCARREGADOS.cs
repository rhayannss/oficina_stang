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
    public partial class CAD_ENCARREGADOS : Form
    {
        public CAD_ENCARREGADOS()
        {
            InitializeComponent();
        }

        private void encarregadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.encarregadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        public int id;

        private void CAD_ENCARREGADOS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.encarregados'. Você pode movê-la ou removê-la conforme necessário.
            this.encarregadosTableAdapter.Fill(this.bANCO.encarregados);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.encarregados'. Você pode movê-la ou removê-la conforme necessário.
            this.encarregadosTableAdapter.Fill(this.bANCO.encarregados);
            encarregadosBindingSource.AddNew();
            id_clienteTextBox.Text = id.ToString();
            
        }

        private void encarregadosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.encarregadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        int A = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            encarregadosBindingSource.EndEdit();
            encarregadosTableAdapter.Update(bANCO);
            if (MessageBox.Show("DESEJA ADICIONAR OUTRO ENCARREGADO?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                A = 1;
                encarregadosBindingSource.AddNew();
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

        private void CAD_ENCARREGADOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (A == 1)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
