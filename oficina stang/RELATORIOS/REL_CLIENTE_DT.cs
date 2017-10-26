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
    public partial class REL_CLIENTE_DT : Form
    {
        public REL_CLIENTE_DT()
        {
            InitializeComponent();
        }

        private void REL_CLIENTE_DT_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.View_os_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.view_os_clienteTableAdapter.Fill(this.bANCO.View_os_cliente);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.bANCO.clientes);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.View_os_cliente'. Você pode movê-la ou removê-la conforme necessário.
            //this.view_os_clienteTableAdapter.Fill(this.bANCO.View_os_cliente);

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

                        string pesquisa = "SELECT * FROM View_os_cliente WHERE cliente = @p1 and data_entrada between @p2 and @p3 order by cliente";
                        SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", clienteComboBox.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p2", maskedTextBox1.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p3", maskedTextBox2.Text));


                        BANCO bl = new BANCO();
                        DA.Fill(bl, "View_os_cliente");
                        BindingSource bs;
                        bs = new BindingSource(bl, "View_os_cliente");
                        //view_os_clienteDataGridView.DataSource = bs;
                        RELATORIOS.REL_CLIENTE_DATA CR = new RELATORIOS.REL_CLIENTE_DATA();
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

                        string pesquisa = "SELECT * FROM View_os WHERE nome >= @p1 and nome <= @p4 and data_entrada between @p2 and @p3 order by nome";
                        SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", clienteComboBox.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p2", maskedTextBox1.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p3", maskedTextBox2.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p4", comboBox1.Text));


                        BANCO bl = new BANCO();
                        DA.Fill(bl, "View_os");
                        BindingSource bs;
                        bs = new BindingSource(bl, "View_os");
                        //view_os_clienteDataGridView.DataSource = bs;
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

                        string pesquisa = "SELECT * FROM View_os_cliente WHERE cliente = @p1 order by cliente";
                        SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", clienteComboBox.Text));
                        //textBox1.Text = clienteComboBox.Text;


                        BANCO bl = new BANCO();
                        DA.Fill(bl, "View_os_cliente");
                        BindingSource bs;
                        bs = new BindingSource(bl, "View_os_cliente");
                        //view_os_clienteDataGridView.DataSource = bs;
                        RELATORIOS.REL_CLIENTE_DATA CR = new RELATORIOS.REL_CLIENTE_DATA();
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

                        string pesquisa = "SELECT * FROM View_os WHERE nome >= @p1 and nome <= @p2 order by nome";
                        SqlDataAdapter DA = new SqlDataAdapter(pesquisa, conn);
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p1", clienteComboBox.Text));
                        DA.SelectCommand.Parameters.Add(new SqlParameter("@p2", comboBox1.Text));


                        BANCO bl = new BANCO();
                        DA.Fill(bl, "View_os");
                        BindingSource bs;
                        bs = new BindingSource(bl, "View_os");
                        //view_os_clienteDataGridView.DataSource = bs;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
