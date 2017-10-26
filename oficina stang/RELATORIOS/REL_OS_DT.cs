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
    public partial class REL_OS_DT : Form
    {
        public REL_OS_DT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (checkBox1.Checked)
                {
                    if (radioButton1.Checked)
                    {
                        try
                        {
                            string Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
                            SqlConnection conn = new SqlConnection(Strconn);

                            string pesquisa = "SELECT * FROM View_os WHERE id_orden = @p1 and data_entrada between @p2 and @p3 order by id_orden";
                            SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                            DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", textBox1.Text));
                            DA.SelectCommand.Parameters.Add(new SqlParameter("@p2", maskedTextBox1.Text));
                            DA.SelectCommand.Parameters.Add(new SqlParameter("@p3", maskedTextBox2.Text));


                            BANCO bl = new BANCO();
                            DA.Fill(bl, "View_os");
                            //BindingSource bs;
                            //bs = new BindingSource(bl, "View_os");
                            //View_osDataGridView.DataSource = bs;
                            RELATORIOS.REL_OS_DATA CR = new RELATORIOS.REL_OS_DATA();
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

                            string pesquisa = "SELECT * FROM View_os WHERE id_orden >= @p1 and id_orden <= @p4 and data_entrada between @p2 and @p3 order by id_orden";
                            SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                            DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", textBox1.Text));
                            DA.SelectCommand.Parameters.Add(new SqlParameter("@p2", maskedTextBox1.Text));
                            DA.SelectCommand.Parameters.Add(new SqlParameter("@p3", maskedTextBox2.Text));
                            DA.SelectCommand.Parameters.Add(new SqlParameter("@p4", textBox2.Text));


                            BANCO bl = new BANCO();
                            DA.Fill(bl, "View_os");
                            BindingSource bs;
                            bs = new BindingSource(bl, "View_os");
                            //View_osDataGridView.DataSource = bs;
                            RELATORIOS.REL_OS_DATA CR = new RELATORIOS.REL_OS_DATA();
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

                            string pesquisa = "SELECT * FROM View_os WHERE id_orden = @p1 order by id_orden";
                            SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                            DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", textBox1.Text));
                            //textBox1.Text = id_ordenComboBox.Text;


                            BANCO bl = new BANCO();
                            DA.Fill(bl, "View_os");
                            BindingSource bs;
                            bs = new BindingSource(bl, "View_os");
                            //View_osDataGridView.DataSource = bs;
                            RELATORIOS.REL_OS_DATA CR = new RELATORIOS.REL_OS_DATA();
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

                            string pesquisa = "SELECT * FROM View_os WHERE id_orden >= @p1 and id_orden <= @p2 order by id_orden";
                            SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                            DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", textBox1.Text));
                            DA.SelectCommand.Parameters.Add(new SqlParameter("@p2", textBox2.Text));


                            BANCO bl = new BANCO();
                            DA.Fill(bl, "View_os");
                            BindingSource bs;
                            bs = new BindingSource(bl, "View_os");
                            //View_osDataGridView.DataSource = bs;
                            RELATORIOS.REL_OS_DATA CR = new RELATORIOS.REL_OS_DATA();
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
            else
            {
                if (checkBox1.Checked)
                {
                    try
                    {
                        string Strconn = @"Data Source=localhost\SQLExpress;Initial Catalog=oficina;Integrated Security=True";
                        SqlConnection conn = new SqlConnection(Strconn);

                        string pesquisa = "SELECT * FROM View_os WHERE data_entrada between @p2 and @p3 order by id_orden";
                        SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p2", maskedTextBox1.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p3", maskedTextBox2.Text));


                        BANCO bl = new BANCO();
                        DA.Fill(bl, "View_os");
                        //BindingSource bs;
                        //bs = new BindingSource(bl, "View_os");
                        //View_osDataGridView.DataSource = bs;
                        RELATORIOS.REL_OS_DATA CR = new RELATORIOS.REL_OS_DATA();
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
                else
                {
                    MessageBox.Show("Favor selecionar uma opção", "Erro ao visualisar relatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void REL_OS_DT_Load(object sender, EventArgs e)
        {

        }
    }
}
