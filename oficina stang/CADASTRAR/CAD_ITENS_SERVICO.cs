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
    public partial class CAD_ITENS_SERVICO : Form
    {
        public CAD_ITENS_SERVICO()
        {
            InitializeComponent();
        }
        public int asdf;
        private void ordem_servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordem_servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        private void clear()
        {
            //textBox1.Clear();
            textBox2.Clear();
            //id_ordenTextBox.Clear();
            id_servicoTextBox.Clear();
            textBox1.Clear();
            //descricaoTextBox.Clear();
            comboBox1.Text = "";
            id_funcionarioComboBox.Text = "";
            valorTextBox.Clear();
            horasMaskedTextBox.Clear();
            comboBox1.Focus();
        }
        private void CAD_ITENS_SERVICO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.itens_servico'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_servicoTableAdapter.Fill(this.bANCO.itens_servico);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bANCO.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bANCO.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.bANCO.servico);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.itens_servico'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_servicoTableAdapter.Fill(this.bANCO.itens_servico);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.ordem_servico'. Você pode movê-la ou removê-la conforme necessário.
            this.ordem_servicoTableAdapter.Fill(this.bANCO.ordem_servico);
            int pos = ordem_servicoBindingSource.Find("id_orden", asdf);
            ordem_servicoBindingSource.Position = pos;
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //servicoBindingSource.MoveLast();
            TABELAS.TAB_SERVICOS_V ALT = new TABELAS.TAB_SERVICOS_V();
            servicoTableAdapter.Fill(bANCO.servico);
            ALT.ShowDialog();
            //produtosBindingSource.MoveFirst();
            if (ALT.servicoDataGridView.SelectedRows.Count > 0)
            {
                int id = (int)ALT.servicoDataGridView
                    .SelectedRows[0].Cells[0].Value;
                int linha = servicoBindingSource
                    .Find("id_servico", id);
                servicoBindingSource.Position = linha;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string a = id_funcionarioComboBox.SelectedValue.ToString();
                DataRow linha = bANCO.itens_servico.NewRow();
                linha["id_orden"] = int.Parse(id_ordenTextBox.Text);
                linha["id_servico"] = int.Parse(id_servicoTextBox.Text);
                linha["id_funcionario"] = int.Parse(a);
                linha["valor"] = decimal.Parse(valorTextBox.Text);
                linha["valor_tot"] = decimal.Parse(textBox2.Text);
                //linha["quant"] = decimal.Parse(textBox1.Text);
                linha["horas"] = horasMaskedTextBox.Text;
                bANCO.itens_servico.Rows.Add(linha);
                //itens_orcamentoBindingSource.EndEdit();
                itens_servicoTableAdapter.Update(bANCO);
                //int id = (int)linha["id_ordem"];


                ordem_servicoTableAdapter.Fill(bANCO.ordem_servico);
                itens_servicoTableAdapter.Fill(bANCO.itens_servico);
                int pos = ordem_servicoBindingSource.Find("id_orden", asdf);
                //orcamentosBindingSource.MoveLast();
                ordem_servicoBindingSource.Position = pos;
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao adicionar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //DataRow linha = bANCO.itens_servico.NewRow();
                //linha["id_orden"] = int.Parse(id_ordenTextBox.Text);
                if (MessageBox.Show("DESEJA RALMENTE REMOVER ESTE ITEM?", "ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    itens_servicoBindingSource.RemoveCurrent();
                }
                //itens_servicoBindingSource.EndEdit();
                itens_servicoTableAdapter.Update(bANCO.itens_servico);
                //int id = (int)linha["id_orden"];
                ordem_servicoTableAdapter.Fill(bANCO.ordem_servico);
                //itens_servicoTableAdapter.Fill(bANCO.itens_servico);
                int pos = ordem_servicoBindingSource.Find("id_orden", asdf);
                //orcamentosBindingSource.MoveLast();
                ordem_servicoBindingSource.Position = pos;
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao excluir produto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*if(horasMaskedTextBox.Text!=""&&valorTextBox.Text!="")
            {
                decimal a, b, c;
                a = decimal.Parse(textBox1.Text);
                b = decimal.Parse(valorTextBox.Text);
                c = a * b;
                textBox2.Text = c.ToString();
            }*/
        }

        private void valorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (horasMaskedTextBox.Text != "" && valorTextBox.Text != "")
                {
                    decimal a, b, c, d, f;
                    string h = horasMaskedTextBox.Text;
                    string[] h1 = h.Split(':');
                    a = int.Parse(h1[0]);
                    b = int.Parse(h1[1]);
                    c = decimal.Parse(valorTextBox.Text);
                    d = b * c / 60;
                    f = c * a;
                    f = f + d;
                    textBox2.Text = f.ToString();
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itens_servicoDataGridView.DataSource = null;
            CAD_ORDEM CO = new CAD_ORDEM();
            ALTERAR.ALT_ORDEM AO = new ALTERAR.ALT_ORDEM();
            CO.ordem_servicoTableAdapter.Fill(bANCO.ordem_servico);
            CO.ordem_servicoBindingSource.MoveLast();
            CO.ASDFG();
            AO.ordem_servicoTableAdapter.Fill(bANCO.ordem_servico);
            AO.ordem_servicoBindingSource.MoveLast();
            AO.ASDFG();
            Close();
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void descricaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void valorTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && valorTextBox.Text != "")
                {
                    decimal a, c, d;
                    a = decimal.Parse(textBox1.Text);
                    c = decimal.Parse(valorTextBox.Text);
                    d = a * c;
                    textBox2.Text = d.ToString();
                }
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && valorTextBox.Text != "")
                {
                    decimal a, c, d;
                    a = decimal.Parse(textBox1.Text);
                    c = decimal.Parse(valorTextBox.Text);
                    d = a * c;
                    textBox2.Text = d.ToString();
                }
            }
            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
