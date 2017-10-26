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
    public partial class TAB_CIDADE_ESTADO : Form
    {
        public TAB_CIDADE_ESTADO()
        {
            InitializeComponent();
        }

        private void estadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void TAB_CIDADE_ESTADO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.estados'. Você pode movê-la ou removê-la conforme necessário.
            this.estadosTableAdapter.Fill(this.bANCO.estados);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            estadosBindingSource.Filter = "nome like '" + textBox1.Text + "%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cidadesBindingSource.Filter = "nome like '" + textBox2.Text + "%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_ESTADOS CE = new CADASTRAR.CAD_ESTADOS();
            CE.Show();
            estadosTableAdapter.Fill(bANCO.estados);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_CIDADE CE = new CADASTRAR.CAD_CIDADE();
            CE.Show();
            cidadesTableAdapter.Fill(bANCO.cidades);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
