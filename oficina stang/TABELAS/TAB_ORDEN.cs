using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficina_stang.TABELAS
{
    public partial class TAB_ORDEN : Form
    {
        public TAB_ORDEN()
        {
            InitializeComponent();
        }

        private void TAB_ORDEN_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.fazendas'. Você pode movê-la ou removê-la conforme necessário.
            this.fazendasTableAdapter.Fill(this.bANCO.fazendas);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.ordem_servico'. Você pode movê-la ou removê-la conforme necessário.
            this.ordem_servicoTableAdapter.Fill(this.bANCO.ordem_servico);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.encarregados'. Você pode movê-la ou removê-la conforme necessário.
            //this.encarregadosTableAdapter.Fill(this.bANCO.encarregados);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.bANCO.produtos);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.itens_ordem'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_ordemTableAdapter.Fill(this.bANCO.itens_ordem);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.View_ordem'. Você pode movê-la ou removê-la conforme necessário.
            this.view_ordemTableAdapter.Fill(this.bANCO.View_ordem);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text != "")
                {
                    //descobrir como fazer filtragem de chaves primarias e estrangeira
                    view_ordemBindingSource.Filter = "id_orden = " + int.Parse(textBox1.Text);
                }
                else
                {
                    view_ordemBindingSource.Filter = "";
                    view_ordemTableAdapter.Fill(this.bANCO.View_ordem);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Focus();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                try
                {
                    DateTime d = DateTime.Parse(maskedTextBox1.Text);
                    view_ordemBindingSource.Filter = " data_entrada = '" + maskedTextBox1.Text + "'";
                }
                catch (Exception ex)
                {
                    view_ordemBindingSource.Filter = "";
                    ex.ToString();
                }
            }
            else if (radioButton4.Checked)
            {
                try
                {
                    DateTime d = DateTime.Parse(maskedTextBox1.Text);
                    view_ordemBindingSource.Filter = " data_saida = '" + maskedTextBox1.Text + "'";
                }
                catch (Exception ex)
                {
                    view_ordemBindingSource.Filter = "";
                    ex.ToString();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_ORDEM CO = new CADASTRAR.CAD_ORDEM();
            CO.Show();
            ordem_servicoTableAdapter.Fill(bANCO.ordem_servico);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_ORDEM DC = new ALTERAR.ALT_ORDEM();
            DC.ASD = int.Parse(id_ordenTextBox.Text);
            DC.Show();
            ordem_servicoTableAdapter.Fill(bANCO.ordem_servico);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEJA REALMENTE EXCLUIR?", " ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ordem_servicoBindingSource.RemoveCurrent();
                    ordem_servicoTableAdapter.Update(bANCO);
                }
            }
            catch
            {
                MessageBox.Show("EXCLUA PRIMEIRO OS ITENS DA O.S.", " ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ordem_servicoTableAdapter.Fill(bANCO.ordem_servico);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TAB_ORDEN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer sair?\r", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
                SqlConnection conn = new SqlConnection(Strconn);

                string pesquisa = "SELECT * FROM View_ordem WHERE id_orden = @p1";
                SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", id_ordenTextBox.Text));


                BANCO bl = new BANCO();
                DA.Fill(bl, "View_ordem");

                RELATORIOS.REL_OS CR = new RELATORIOS.REL_OS();
                CR.SetDataSource(bl);

                RELATORIOS.VISUALIZADOR_RELATORIO V = new RELATORIOS.VISUALIZADOR_RELATORIO();
                V.crystalReportViewer1.ReportSource = CR;
                V.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao visualisar relatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
