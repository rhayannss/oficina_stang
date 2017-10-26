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

namespace oficina_stang.ALTERAR
{
    public partial class ALT_PRODUTO : Form
    {
        public ALT_PRODUTO()
        {
            InitializeComponent();
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bANCO);

        }
        public int ASD;
        private void ALT_PRODUTO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bANCO.medidas'. Você pode movê-la ou removê-la conforme necessário.
            this.medidasTableAdapter.Fill(this.bANCO.medidas);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriasTableAdapter.Fill(this.bANCO.categorias);
            // TODO: esta linha de código carrega dados na tabela 'bANCO.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.bANCO.produtos);
            int pos = produtosBindingSource.Find("id_produto", ASD);
            produtosBindingSource.Position = pos;
        }

        private void margemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void preco_vendaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantidade_convertidaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            produtosBindingSource.EndEdit();
            produtosTableAdapter.Update(bANCO);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kg_metroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void preco_custoTextBox_Leave(object sender, EventArgs e)
        {
            if (margemTextBox.Text != "" && preco_custoTextBox.Text != "")
            {
                float a, b, c, d;
                a = float.Parse(preco_custoTextBox.Text);

                b = float.Parse(margemTextBox.Text) / 100;

                c = a * b;

                d = a + c;
                preco_vendaTextBox.Text = d.ToString();
            }
        }

        private void margemTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (margemTextBox.Text != "" && preco_custoTextBox.Text != "")
                {
                    float a, b, c, d;
                    a = float.Parse(preco_custoTextBox.Text);

                    b = float.Parse(margemTextBox.Text) / 100;

                    c = a * b;

                    d = a + c;
                    preco_vendaTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preco_vendaTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (preco_vendaTextBox.Text != "" && preco_custoTextBox.Text != "")
                {
                    float a, b, c, d;
                    a = float.Parse(preco_custoTextBox.Text);

                    b = float.Parse(preco_vendaTextBox.Text) * 100;

                    c = b / a;

                    d = c - 100;
                    margemTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quantidadeTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (quantidadeTextBox.Text != "" && kg_metroTextBox.Text != "")
                {
                    float a, b, d;
                    a = float.Parse(quantidadeTextBox.Text);

                    b = float.Parse(kg_metroTextBox.Text);

                    d = a * b;

                    quantidade_convertidaTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kg_metroTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (quantidadeTextBox.Text != "" && kg_metroTextBox.Text != "")
                {
                    float a, b, d;
                    a = float.Parse(quantidadeTextBox.Text);

                    b = float.Parse(kg_metroTextBox.Text);

                    d = a * b;

                    quantidade_convertidaTextBox.Text = d.ToString();
                }
                else if (quantidade_convertidaTextBox.Text != "" && kg_metroTextBox.Text != "")
                {
                    float a, b, d;
                    a = float.Parse(quantidade_convertidaTextBox.Text);

                    b = float.Parse(kg_metroTextBox.Text);

                    d = a / b;

                    quantidadeTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quantidade_convertidaTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (quantidade_convertidaTextBox.Text != "" && kg_metroTextBox.Text != "")
                {
                    float a, b, d;
                    a = float.Parse(quantidade_convertidaTextBox.Text);

                    b = float.Parse(kg_metroTextBox.Text);

                    d = a / b;

                    quantidadeTextBox.Text = d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao calcular os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }
    }
}
