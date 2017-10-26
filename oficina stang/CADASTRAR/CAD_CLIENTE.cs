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
    public partial class CAD_CLIENTE : Form
    {
        public CAD_CLIENTE()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);
            clientesBindingSource.AddNew();
            // clientesBindingSource1.AddNew();

        }

        private void CAD_CLIENTE_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.bANCO.cidades);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);
            clientesBindingSource.AddNew();

        }
        int A = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit(); 
            //clientesBindingSource1.Clear();
            clientesTableAdapter.Update(bANCO);
            DialogResult X = MessageBox.Show("DESEJA ADICIONAR OUTRO CLIENTE?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (X == DialogResult.Yes)
            {
                A = 1;
                clientesBindingSource.AddNew();

            }
            else
            {
                A = 0;
                Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //clientesBindingSource1.EndEdit();
            //clientesBindingSource.Clear();
            clientesTableAdapter.Update(bANCO);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A = 0;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            //clientesBindingSource1.Clear();
            clientesTableAdapter.Update(bANCO);
            CADASTRAR.CAD_FAZENDA CF = new CADASTRAR.CAD_FAZENDA();
            CF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            //clientesBindingSource1.Clear();
            clientesTableAdapter.Update(bANCO);
            CADASTRAR.CAD_ENCARREGADOS CE = new CADASTRAR.CAD_ENCARREGADOS();
            CE.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // clientesBindingSource1.EndEdit();
            //clientesBindingSource1.Clear();
            clientesTableAdapter.Update(bANCO);
            CADASTRAR.CAD_FAZENDA CF = new CADASTRAR.CAD_FAZENDA();
            CF.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void clientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void clientesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

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

        private void clientesBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            //clientesBindingSource1.Clear();
            clientesTableAdapter.Update(bANCO);
            clientesBindingSource.MoveLast();
            CADASTRAR.CAD_FAZENDA CF = new CADASTRAR.CAD_FAZENDA();
            CF.id = int.Parse(id_clienteTextBox.Text);
            CF.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            //clientesBindingSource1.Clear();
            clientesTableAdapter.Update(bANCO);
            clientesBindingSource.MoveLast();
            CADASTRAR.CAD_ENCARREGADOS CE = new CADASTRAR.CAD_ENCARREGADOS();
            CE.id = int.Parse(id_clienteTextBox.Text);
            CE.Show();
        }

        private void CAD_CLIENTE_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (A == 1)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
