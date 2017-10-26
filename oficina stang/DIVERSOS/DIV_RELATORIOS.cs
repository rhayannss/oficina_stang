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

namespace oficina_stang.DIVERSOS
{
    public partial class DIV_RELATORIOS : Form
    {
        public DIV_RELATORIOS()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RELATORIOS.REL_CLIENTE_DT RL = new RELATORIOS.REL_CLIENTE_DT();
            RL.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RELATORIOS.REL_OS_DT ROT = new RELATORIOS.REL_OS_DT();
            ROT.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RELATORIOS.REL_MATERIAL_DT RMD = new RELATORIOS.REL_MATERIAL_DT();
            RMD.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RELATORIOS.REL_SERVICO_DT RS = new RELATORIOS.REL_SERVICO_DT();
            RS.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RELATORIOS.REL_FUNCI_SERVICO RF = new RELATORIOS.REL_FUNCI_SERVICO();
            RF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DIV_RELATORIOS_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            RELATORIOS.REL_FUNCI_MATERIAL RF = new RELATORIOS.REL_FUNCI_MATERIAL();
            RF.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string  Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
                SqlConnection conn = new SqlConnection(Strconn);

                string pesquisa = "SELECT * FROM View_produto";
                SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                BANCO bl = new BANCO();
                DA.Fill(bl, "View_produto");
                //BindingSource bs;
                //bs = new BindingSource(bl, "View_fun_servico");
                //View_fun_servicoDataGridView.DataSource = bs;
                RELATORIOS.REL_PRECO_MATERIAL CR = new RELATORIOS.REL_PRECO_MATERIAL();
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

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
                SqlConnection conn = new SqlConnection(Strconn);

                string pesquisa = "SELECT * FROM View_produto";
                SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                BANCO bl = new BANCO();
                DA.Fill(bl, "View_produto");
                //BindingSource bs;
                //bs = new BindingSource(bl, "View_fun_servico");
                //View_fun_servicoDataGridView.DataSource = bs;
                RELATORIOS.REL_PRECO_CONV CR = new RELATORIOS.REL_PRECO_CONV();
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

        private void button11_Click(object sender, EventArgs e)
        {
            RELATORIOS.REL_MATERIAL_CUST MC = new RELATORIOS.REL_MATERIAL_CUST();
            MC.Show();
        }
    }
}
