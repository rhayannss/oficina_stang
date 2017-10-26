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
    public partial class CAD_CIDADE : Form
    {
        public CAD_CIDADE()
        {
            InitializeComponent();
        }

        private void cidadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cidadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void CAD_CIDADE_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.estados'. Você pode movê-la ou removê-la conforme necessário.
            this.estadosTableAdapter.Fill(this.bANCO.estados);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            cidadesBindingSource.AddNew();

        }
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            cidadesBindingSource.EndEdit();
            cidadesTableAdapter.Update(bANCO);
            if (MessageBox.Show("DESEJA ADICIONAR OUTRA CIDADE?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                a = 1;
                cidadesBindingSource.AddNew();
            }
            else
            {
                a = 0;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = 0;
            Close();
        }

        private void CAD_CIDADE_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (a == 1)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
