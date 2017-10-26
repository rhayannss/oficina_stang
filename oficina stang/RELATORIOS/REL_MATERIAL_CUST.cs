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
    public partial class REL_MATERIAL_CUST : Form
    {
        public REL_MATERIAL_CUST()
        {
            InitializeComponent();
        }

        private void REL_MATERIAL_CUST_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANCO.View_material_vendido_custo' table. You can move, or remove it, as needed.
            this.view_material_vendido_custoTableAdapter.Fill(this.bANCO.View_material_vendido_custo);
            // TODO: This line of code loads data into the 'bANCO.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.bANCO.produtos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (radioButton1.Checked)
                {
                    try
                    {
                        string Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
                        SqlConnection conn = new SqlConnection(Strconn);

                        string pesquisa = "SELECT * FROM View_material_vendido_custo WHERE descricao = @p1 and data_entrada between @p2 and @p3 order by descricao";
                        SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", comboBox1.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p2", maskedTextBox1.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p3", maskedTextBox2.Text));


                        BANCO bl = new BANCO();
                        DA.Fill(bl, "View_material_vendido_custo");
                        //BindingSource bs;
                        //bs = new BindingSource(bl, "View_material_vendido_custo");
                        //View_material_vendidoDataGridView.DataSource = bs;
                        RELATORIOS.REL_MATERIAIS_CUSTO CR = new RELATORIOS.REL_MATERIAIS_CUSTO();
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
                else if (radioButton2.Checked)
                {
                    try
                    {
                        string Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
                        SqlConnection conn = new SqlConnection(Strconn);

                        string pesquisa = "SELECT * FROM View_material_vendido_custo WHERE descricao >= @p1 and descricao <= @p4 and data_entrada between @p2 and @p3 order by descricao";
                        SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", comboBox1.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p2", maskedTextBox1.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p3", maskedTextBox2.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p4", comboBox2.Text));


                        BANCO bl = new BANCO();
                        DA.Fill(bl, "View_material_vendido_custo");
                        BindingSource bs;
                        bs = new BindingSource(bl, "View_material_vendido_custo");
                        //View_material_vendidoDataGridView.DataSource = bs;
                        RELATORIOS.REL_MATERIAIS_CUSTO CR = new RELATORIOS.REL_MATERIAIS_CUSTO();
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
            else
            {
                if (radioButton1.Checked)
                {
                    try
                    {
                        string Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
                        SqlConnection conn = new SqlConnection(Strconn);

                        string pesquisa = "SELECT * FROM View_material_vendido_custo WHERE descricao = @p1 order by descricao";
                        SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", comboBox1.Text));
                        //textBox1.Text = descricaoComboBox.Text;


                        BANCO bl = new BANCO();
                        DA.Fill(bl, "View_material_vendido_custo");
                        BindingSource bs;
                        bs = new BindingSource(bl, "View_material_vendido_custo");
                        //view_material_vendido_custoDataGridView.DataSource = bs;
                        RELATORIOS.REL_MATERIAIS_CUSTO CR = new RELATORIOS.REL_MATERIAIS_CUSTO();
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
                else if (radioButton2.Checked)
                {
                    try
                    {
                        string Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
                        SqlConnection conn = new SqlConnection(Strconn);

                        string pesquisa = "SELECT * FROM View_material_vendido_custo WHERE descricao >= @p1 and descricao <= @p2 order by descricao";
                        SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", comboBox1.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p2", comboBox2.Text));


                        BANCO bl = new BANCO();
                        DA.Fill(bl, "View_material_vendido_custo");
                        BindingSource bs;
                        bs = new BindingSource(bl, "View_material_vendido_custo");
                        //View_material_vendidoDataGridView.DataSource = bs;
                        RELATORIOS.REL_MATERIAIS_CUSTO CR = new RELATORIOS.REL_MATERIAIS_CUSTO();
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

        private void SetDataSource(BANCO bl)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
