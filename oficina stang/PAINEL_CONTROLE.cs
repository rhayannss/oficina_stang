using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficina_stang
{
    public partial class PAINEL_CONTROLE : Form
    {
        public PAINEL_CONTROLE()
        {
            InitializeComponent();
        }

        private void toolStripButton2_ButtonClick(object sender, EventArgs e)
        {
            CADASTRAR.CAD_PRODUTO CP = new CADASTRAR.CAD_PRODUTO();
            CP.Show();
        }

        private void aLTERARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_PRODUTO AP = new ALTERAR.ALT_PRODUTO();
            AP.Show();
        }

        private void pESQUISARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TABELAS.TAB_PRODUTO TP = new TABELAS.TAB_PRODUTO();
            TP.Show();
        }

        private void cATEGORIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_CATEGORIA CC = new CADASTRAR.CAD_CATEGORIA();
            CC.Show();
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            CADASTRAR.CAD_CLIENTE CC = new CADASTRAR.CAD_CLIENTE();
            CC.Show();
        }

        private void nOVAFAZENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_FAZENDA CC = new CADASTRAR.CAD_FAZENDA();
            CC.Show();
        }

        private void nOVOENCARREGADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_ENCARREGADOS CC = new CADASTRAR.CAD_ENCARREGADOS();
            CC.Show();
        }

        private void aLTERARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_CLIENTE CC = new ALTERAR.ALT_CLIENTE();
            CC.Show();
        }

        private void pESQUISARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TABELAS.TAB_CLIENTE_EXCLUIR TC = new TABELAS.TAB_CLIENTE_EXCLUIR();
            TC.Show();
        }

        private void toolStripSplitButton4_ButtonClick(object sender, EventArgs e)
        {
            CADASTRAR.CAD_FUNCIONARIO CC = new CADASTRAR.CAD_FUNCIONARIO();
            CC.Show();
        }

        private void cARGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_CARGO CC = new CADASTRAR.CAD_CARGO();
            CC.Show();
        }

        private void aLTERARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_FUNCIONARIO CC = new ALTERAR.ALT_FUNCIONARIO();
            CC.Show();
        }

        private void pESQUISARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TABELAS.TAB_FUNCIONARIO_EXCLUIR TC = new TABELAS.TAB_FUNCIONARIO_EXCLUIR();
            TC.Show();
        }

        private void toolStripSplitButton5_ButtonClick(object sender, EventArgs e)
        {
            CADASTRAR.CAD_CIDADE CC = new CADASTRAR.CAD_CIDADE();
            CC.Show();
        }

        private void eSTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_ESTADOS CC = new CADASTRAR.CAD_ESTADOS();
            CC.Show();
        }

        private void toolStripButton1_ButtonClick(object sender, EventArgs e)
        {
            CADASTRAR.CAD_ORDEM CO = new CADASTRAR.CAD_ORDEM();
            CO.Show();
        }

        private void aLTERARFAZENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_FAZENDA AF = new ALTERAR.ALT_FAZENDA();
            AF.Show();
        }

        private void aLTERARENCAREGADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_ENCARREGADO AF = new ALTERAR.ALT_ENCARREGADO();
            AF.Show();
        }

        private void pESQUISARFAZENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TABELAS.TAB_FAZENDA TC = new TABELAS.TAB_FAZENDA();
            TC.Show();
        }

        private void pESQUISARENCARREGADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TABELAS.TAB_ENCARREGADO TC = new TABELAS.TAB_ENCARREGADO();
            TC.Show();
        }

        private void aLTERARORDEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALTERAR.ALT_ORDEM AO = new ALTERAR.ALT_ORDEM();
            AO.Show();
        }

        private void pESQUISARToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TABELAS.TAB_ORDEN TO = new TABELAS.TAB_ORDEN();
            TO.Show();
        }

        private void toolStripButton3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void sERVIÇOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_SERVICO CS = new CADASTRAR.CAD_SERVICO();
            CS.Show();
        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
            DIVERSOS.DIV_RELATORIOS DR = new DIVERSOS.DIV_RELATORIOS();
            DR.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            TESTE t = new TESTE();
            t.Show();
        }

        private void pESQUISARSERVIÇOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TABELAS.TAB_SERVICO TS = new TABELAS.TAB_SERVICO();
            TS.Show();
        }

        private void pESQUISARCARGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TABELAS.TAB_CARGO TS = new TABELAS.TAB_CARGO();
            TS.Show();
        }

        private void pESQUISARCIDADEESTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TABELAS.TAB_CIDADE_ESTADO TS = new TABELAS.TAB_CIDADE_ESTADO();
            TS.Show();
        }

        private void pESQUISARCATEGORIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TABELAS.TAB_CATEGORIA TS = new TABELAS.TAB_CATEGORIA();
            TS.Show();
        }

        private void uNIDADEDEMEDIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTRAR.CAD_MEDIDAS CM = new CADASTRAR.CAD_MEDIDAS();
            CM.Show();
        }

        private void tABELAUNIDADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TABELAS.TAB_MEDIDAS TM = new TABELAS.TAB_MEDIDAS();
            TM.Show();
        }

        private void toolStripSplitButton6_ButtonClick(object sender, EventArgs e)
        {
            CADASTRAR.CAD_NT_SAIDA cis = new CADASTRAR.CAD_NT_SAIDA();
            cis.Show();
        }

        private void PAINEL_CONTROLE_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.RemoveAt(2);
        }
    }
}
