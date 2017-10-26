using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace oficina_stang.CADASTRAR
{
    public partial class CAD_ITEM_ORDEM : Form
    {
        public CAD_ITEM_ORDEM()
        {
            InitializeComponent();
        }

        private void itens_ordemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itens_ordemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        private void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            //id_ordenTextBox.Clear();
            id_produtoTextBox.Clear();
            comboBox2.Text="";
            kg_metroTextBox.Clear();
            valor_totTextBox.Clear();
            id_medidaComboBox.Text = "";
            valor_totTextBox.Clear();
            comboBox1.Text = "";
            preco_vendaTextBox.Clear();
            comboBox2.Focus();
        }
        public int asdf;
        private void CAD_ITEM_ORDEM_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.medidas'. Você pode movê-la ou removê-la conforme necessário.
            this.medidasTableAdapter.Fill(this.bANCO.medidas);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.itens_ordem'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_ordemTableAdapter.Fill(this.bANCO.itens_ordem);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.ordem_servico'. Você pode movê-la ou removê-la conforme necessário.
            this.ordem_servicoTableAdapter.Fill(this.bANCO.ordem_servico);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.itens_ordem'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_ordemTableAdapter.Fill(this.bANCO.itens_ordem);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.bANCO.produtos);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.itens_ordem'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_ordemTableAdapter.Fill(this.bANCO.itens_ordem);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.ordem_servico'. Você pode movê-la ou removê-la conforme necessário.
            this.ordem_servicoTableAdapter.Fill(this.bANCO.ordem_servico);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bANCO.funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.bANCO.produtos);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.itens_ordem'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_ordemTableAdapter.Fill(this.bANCO.itens_ordem);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.itens_ordem'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_ordemTableAdapter.Fill(this.bANCO.itens_ordem);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.itens_ordem'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_ordemTableAdapter.Fill(this.bANCO.itens_ordem);
            
            int pos = ordem_servicoBindingSource.Find("id_orden",asdf );
            ordem_servicoBindingSource.Position = pos;
            clear();
        }

        private void itens_ordemBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.itens_ordemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }

        private void itens_ordemBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.itens_ordemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            itens_ordemDataGridView.DataSource = null;
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

        private void button1_Click(object sender, EventArgs e)
        {
            /*DataRow linha = bANCO.itens_ordem.NewRow();
            linha["id_ordem"] = int.Parse(id_ordenTextBox.Text);
            linha["id_funcionario"] = int.Parse(comboBox1.ValueMember);
            linha["id_produto"] = int.Parse(id_produtoTextBox.Text);
            linha["valor_unit"] = int.Parse(preco_vendaTextBox.Text);
            linha["quant"] = int.Parse(textBox1.Text);
            linha["unidade"] = int.Parse(unidadeTextBox.Text);
            bANCO.itens_ordem.Rows.Add(linha);
            itens_ordemTableAdapter.Update(bANCO);
            int id = (int)linha["id_ordem"];
            ordem_servicoTableAdapter.Fill(bANCO.ordem_servico);
            itens_ordemTableAdapter.Fill(bANCO.itens_ordem);
            int pos = ordem_servicoBindingSource.Find("id_ordem", id);
            //orcamentosBindingSource.MoveLast();
            ordem_servicoBindingSource.Position = pos;*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void preco_vendaTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            produtosTableAdapter.Fill(bANCO.produtos);
            TABELAS.TAB_PRODUTO_V ALT = new TABELAS.TAB_PRODUTO_V();
            ALT.ShowDialog();
            //produtosBindingSource.MoveLast();
            if (ALT.produtosDataGridView.SelectedRows.Count > 0)
            {
                int id = (int)ALT.produtosDataGridView
                    .SelectedRows[0].Cells[0].Value;
                int linha = produtosBindingSource
                    .Find("id_produto", id);
                produtosBindingSource.Position = linha;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string a = comboBox1.SelectedValue.ToString();
                DataRow linha = bANCO.itens_ordem.NewRow();
                linha["id_ordem"] = int.Parse(id_ordenTextBox.Text);
                linha["id_produto"] = int.Parse(id_produtoTextBox.Text);
                linha["id_funcionario"] = int.Parse(a);
                linha["unidade"] = id_medidaComboBox.Text.ToString();
                linha["valor_unit"] = decimal.Parse(preco_vendaTextBox.Text);
                linha["quant"] = decimal.Parse(textBox1.Text);
                linha["desconto"] = decimal.Parse(descontoTextBox.Text);
                bANCO.itens_ordem.Rows.Add(linha);
                //itens_orcamentoBindingSource.EndEdit();
                itens_ordemTableAdapter.Update(bANCO);
                //int id = (int)linha["id_ordem"];


                ordem_servicoTableAdapter.Fill(bANCO.ordem_servico);
                itens_ordemTableAdapter.Fill(bANCO.itens_ordem);
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
                DataRow linha = bANCO.itens_ordem.NewRow();
                linha["id_ordem"] = int.Parse(id_ordenTextBox.Text);
                if (MessageBox.Show("DESEJA RALMENTE REMOVER ESTE ITEM?", "ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    itens_ordemBindingSource.RemoveCurrent();
                itens_ordemBindingSource.EndEdit();
                itens_ordemTableAdapter.Update(bANCO.itens_ordem);
                //int id = (int)linha["id_orden"];
                ordem_servicoTableAdapter.Fill(bANCO.ordem_servico);
                itens_ordemTableAdapter.Fill(bANCO.itens_ordem);
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && kg_metroTextBox.Text != "")
            {
                float a, b, d;
                a = float.Parse(textBox1.Text);

                b = float.Parse(kg_metroTextBox.Text);

                d = b * a;

                textBox2.Text = d.ToString();
            }
            if (textBox1.Text != "" && preco_vendaTextBox.Text != "")
            {
                float a, c, d;
                a = float.Parse(textBox1.Text);

                c = float.Parse(preco_vendaTextBox.Text);

                d = a * c;

                vlor_sem_descontoTextBox.Text = d.ToString();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && kg_metroTextBox.Text != "")
            {
                float a, b, d;
                a = float.Parse(textBox2.Text);

                b = float.Parse(kg_metroTextBox.Text);

                d = a / b;

                textBox1.Text = d.ToString();
            }
            if (textBox1.Text != "" && preco_vendaTextBox.Text != "")
            {
                float a, c, d;
                a = float.Parse(textBox1.Text);

                c = float.Parse(preco_vendaTextBox.Text);

                d = a * c;

                vlor_sem_descontoTextBox.Text = d.ToString();
            }
        }

        private void vlor_sem_descontoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (vlor_sem_descontoTextBox.Text != "")
            {
                if (descontoTextBox.Text == "")
                {
                    descontoTextBox.Text = "0";
                }
                decimal desconto = decimal.Parse(descontoTextBox.Text);
                decimal vlor_sem_desconto = decimal.Parse(vlor_sem_descontoTextBox.Text);
                decimal c;
                c = (100 - desconto) * vlor_sem_desconto / 100;
                valor_totTextBox.Text = c.ToString();
            }
        }

        private void descontoTextBox_Leave(object sender, EventArgs e)
        {
            if (vlor_sem_descontoTextBox.Text != "")
            {
                if (descontoTextBox.Text == "")
                {
                    descontoTextBox.Text = "0";
                }
                float desconto = float.Parse(descontoTextBox.Text);
                float vlor_sem_desconto = float.Parse(vlor_sem_descontoTextBox.Text);
                float c;
                c = (100 - desconto) * vlor_sem_desconto / 100;
                valor_totTextBox.Text = c.ToString();
            }
        }

        private void preco_vendaTextBox_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && preco_vendaTextBox.Text != "")
            {
                float a, b, d;
                a = float.Parse(textBox1.Text);

                b = float.Parse(preco_vendaTextBox.Text);

                d = a * b;

                valor_totTextBox.Text = d.ToString();
            }
        }

        private void CAD_ITEM_ORDEM_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void CAD_ITEM_ORDEM_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }
    }
}
