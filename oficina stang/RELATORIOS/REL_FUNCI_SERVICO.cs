using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace oficina_stang.RELATORIOS
{
    public partial class REL_FUNCI_SERVICO : Form
    {
        public REL_FUNCI_SERVICO()
        {
            InitializeComponent();
        }

        private void REL_FUNCI_SERVICO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.horas_servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.horas_servicosTableAdapter.Fill(this.bANCO.horas_servicos);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bANCO.funcionarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = id_funcionarioComboBox.SelectedValue.ToString();
                DataRow linha = bANCO.horas_servicos.NewRow();
                linha["id_funcionario"] = int.Parse(a);
                linha["data_inicial"] = maskedTextBox1.Text;
                linha["data_final"] = maskedTextBox2.Text;
                bANCO.horas_servicos.Rows.Add(linha);
                this.tableAdapterManager.UpdateAll(this.bANCO);
                try
                {
                    string s, Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(Strconn);

                    string pesquisa = "SELECT * FROM View_fun_servico WHERE nome = @p1 and data_entrada BETWEEN @p2 AND @p3";
                    SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                    DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", id_funcionarioComboBox.Text));
                    DA.SelectCommand.Parameters.Add(new SqlParameter("@p2", maskedTextBox1.Text));
                    DA.SelectCommand.Parameters.Add(new SqlParameter("@p3", maskedTextBox2.Text));
                    s = id_funcionarioComboBox.Text;
                    BANCO bl = new BANCO();
                    DA.Fill(bl, "View_fun_servico");
                    //BindingSource bs;
                    //bs = new BindingSource(bl, "View_fun_servico");
                    //View_fun_servicoDataGridView.DataSource = bs;
                    RELATORIOS.REL_FUNCIONARIO_SERVICO CR = new RELATORIOS.REL_FUNCIONARIO_SERVICO();
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
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
