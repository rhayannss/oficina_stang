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
    public partial class CAD_ESTADOS : Form
    {
        public CAD_ESTADOS()
        {
            InitializeComponent();
        }

        private void estadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void CAD_ESTADOS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.estados'. Você pode movê-la ou removê-la conforme necessário.
            this.estadosTableAdapter.Fill(this.bANCO.estados);
            estadosBindingSource.AddNew();

        }
        int A = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            estadosBindingSource.EndEdit();
            estadosTableAdapter.Update(bANCO);
            DialogResult X = MessageBox.Show("DESEJA ADICIONAR OUTRO ESTADO?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (X == DialogResult.Yes)
            {
                A = 1;
                estadosBindingSource.AddNew();

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CAD_ESTADOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (A == 1)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
