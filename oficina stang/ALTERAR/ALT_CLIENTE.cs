using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficina_stang.ALTERAR
{
    public partial class ALT_CLIENTE : Form
    {
        public ALT_CLIENTE()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        public int ASD;
        private void ALT_CLIENTE_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);
            int pos = clientesBindingSource.Find("id_cliente", ASD);
            clientesBindingSource.Position = pos;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            //clientesBindingSource1.Clear();
            clientesTableAdapter.Update(bANCO);
            CADASTRAR.CAD_FAZENDA CF = new CADASTRAR.CAD_FAZENDA();
            CF.id = int.Parse(id_clienteTextBox.Text);
            CF.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            //clientesBindingSource1.Clear();
            clientesTableAdapter.Update(bANCO);
            CADASTRAR.CAD_ENCARREGADOS CE = new CADASTRAR.CAD_ENCARREGADOS();
            CE.id = int.Parse(id_clienteTextBox.Text);
            CE.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //clientesBindingSource1.EndEdit();
            clientesBindingSource.Clear();
            clientesTableAdapter.Update(bANCO);
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            //clientesBindingSource1.Clear();
            clientesTableAdapter.Update(bANCO);
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox1.Visible = false;
        }
    }
}
