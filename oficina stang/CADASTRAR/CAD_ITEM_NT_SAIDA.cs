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

namespace oficina_stang.CADASTRAR
{
    public partial class CAD_ITEM_NT_SAIDA : Form
    {
        public CAD_ITEM_NT_SAIDA()
        {
            InitializeComponent();
        }

        private void itens_saidaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itens_saidaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        public int asdf;
        public int fdsa;
        private void CAD_ITEM_NT_SAIDA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.notas_saida'. Você pode movê-la ou removê-la conforme necessário.
            this.notas_saidaTableAdapter.Fill(this.bANCO.notas_saida);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.ordem_servico'. Você pode movê-la ou removê-la conforme necessário.
            this.ordem_servicoTableAdapter.Fill(this.bANCO.ordem_servico);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.itens_saida'. Você pode movê-la ou removê-la conforme necessário.
            this.itens_saidaTableAdapter.Fill(this.bANCO.itens_saida);
            int pos = clientesBindingSource.Find("id_cliente", fdsa);
            int pos1 = notas_saidaBindingSource.Find("id_nota", asdf);
            clientesBindingSource.Position = pos;
            notas_saidaBindingSource.Position = pos1;
            bas();

        }
        private void bas()
        {

            string Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
            SqlConnection conn = new SqlConnection(Strconn);

            string pesquisa = "SELECT * FROM ordem_servico WHERE id_cliente = @p1 and nf_feita is null or nf_feita = 0";
            SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
            DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", id_clienteTextBox.Text));

            BANCO bl = new BANCO();
            DA.Fill(bl, "ordem_servico");

            ordem_servicoBindingSource1 = new BindingSource(bl, "ordem_servico");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
            SqlConnection conn = new SqlConnection(Strconn);

            string pesquisa = "SELECT * FROM ordem_servico WHERE id_cliente = @p1 and nf_feita is null or nf_feita = 0";
            SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
            DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", id_clienteTextBox.Text));

            BANCO bl = new BANCO();
            DA.Fill(bl, "ordem_servico");
            BindingSource bs;
            bs = new BindingSource(bl, "ordem_servico");
            TABELAS.TAB_OS_V tov = new TABELAS.TAB_OS_V();
            tov.ordem_servicoDataGridView.DataSource = bs;
            tov.ShowDialog();
            if (tov.ordem_servicoDataGridView.SelectedRows.Count > 0)
            {
                int id = (int)tov.ordem_servicoDataGridView
                    .SelectedRows[0].Cells[0].Value;
                int linha = ordem_servicoBindingSource1
                    .Find("id_orden", id);
                ordem_servicoBindingSource1.Position = linha;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string a = id_ordenComboBox.SelectedValue.ToString();
                DataRow linha = bANCO.itens_saida.NewRow();
                linha["id_ordem"] = int.Parse(a);
                linha["valor"] = decimal.Parse(totalTextBox.Text);
                linha["id_saida"] = decimal.Parse(id_notaTextBox.Text);
                bANCO.itens_saida.Rows.Add(linha);
                //itens_orcamentoBindingSource.EndEdit();
                itens_saidaTableAdapter.Update(bANCO);
                //int id = (int)linha["id_ordem"];


                bas();
                itens_saidaTableAdapter.Fill(bANCO.itens_saida);
                //int pos = ordem_servicoBindingSource.Find("id_orden", asdf);
                //orcamentosBindingSource.MoveLast();
                //ordem_servicoBindingSource.Position = pos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao adicionar O.S.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
