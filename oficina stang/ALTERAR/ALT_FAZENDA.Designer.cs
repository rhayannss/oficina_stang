namespace oficina_stang.ALTERAR
{
    partial class ALT_FAZENDA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label inscricao_estadualLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label id_cidadeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.fazendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANCO = new oficina_stang.BANCO();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscricao_estadualTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.fazendasTableAdapter = new oficina_stang.BANCOTableAdapters.fazendasTableAdapter();
            this.tableAdapterManager = new oficina_stang.BANCOTableAdapters.TableAdapterManager();
            this.cidadesTableAdapter = new oficina_stang.BANCOTableAdapters.cidadesTableAdapter();
            inscricao_estadualLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            id_cidadeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inscricao_estadualLabel
            // 
            inscricao_estadualLabel.AutoSize = true;
            inscricao_estadualLabel.Location = new System.Drawing.Point(6, 55);
            inscricao_estadualLabel.Name = "inscricao_estadualLabel";
            inscricao_estadualLabel.Size = new System.Drawing.Size(128, 13);
            inscricao_estadualLabel.TabIndex = 4;
            inscricao_estadualLabel.Text = "INSCRIÇÃO ESTADUAL:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(6, 16);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(42, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "NOME:";
            // 
            // id_cidadeLabel
            // 
            id_cidadeLabel.AutoSize = true;
            id_cidadeLabel.Location = new System.Drawing.Point(6, 94);
            id_cidadeLabel.Name = "id_cidadeLabel";
            id_cidadeLabel.Size = new System.Drawing.Size(50, 13);
            id_cidadeLabel.TabIndex = 4;
            id_cidadeLabel.Text = "CIDADE:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_cidadeLabel);
            this.groupBox1.Controls.Add(this.id_cidadeComboBox);
            this.groupBox1.Controls.Add(inscricao_estadualLabel);
            this.groupBox1.Controls.Add(this.inscricao_estadualTextBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // id_cidadeComboBox
            // 
            this.id_cidadeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_cidadeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fazendasBindingSource, "id_cidade", true));
            this.id_cidadeComboBox.DataSource = this.cidadesBindingSource;
            this.id_cidadeComboBox.DisplayMember = "nome";
            this.id_cidadeComboBox.FormattingEnabled = true;
            this.id_cidadeComboBox.Location = new System.Drawing.Point(9, 110);
            this.id_cidadeComboBox.Name = "id_cidadeComboBox";
            this.id_cidadeComboBox.Size = new System.Drawing.Size(256, 21);
            this.id_cidadeComboBox.TabIndex = 2;
            this.id_cidadeComboBox.ValueMember = "id_cidade";
            // 
            // fazendasBindingSource
            // 
            this.fazendasBindingSource.DataMember = "fazendas";
            this.fazendasBindingSource.DataSource = this.bANCO;
            // 
            // bANCO
            // 
            this.bANCO.DataSetName = "BANCO";
            this.bANCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "cidades";
            this.cidadesBindingSource.DataSource = this.bANCO;
            // 
            // inscricao_estadualTextBox
            // 
            this.inscricao_estadualTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inscricao_estadualTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fazendasBindingSource, "inscricao_estadual", true));
            this.inscricao_estadualTextBox.Location = new System.Drawing.Point(9, 71);
            this.inscricao_estadualTextBox.Name = "inscricao_estadualTextBox";
            this.inscricao_estadualTextBox.Size = new System.Drawing.Size(256, 20);
            this.inscricao_estadualTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fazendasBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(9, 32);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(256, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sentinel Programações";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "CONCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(154, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.X1 = 117;
            this.lineShape1.X2 = 275;
            this.lineShape1.Y1 = 155;
            this.lineShape1.Y2 = 155;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(291, 224);
            this.shapeContainer2.TabIndex = 41;
            this.shapeContainer2.TabStop = false;
            // 
            // fazendasTableAdapter
            // 
            this.fazendasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.cidadesTableAdapter = null;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.encarregadosTableAdapter = null;
            this.tableAdapterManager.estadosTableAdapter = null;
            this.tableAdapterManager.fazendasTableAdapter = this.fazendasTableAdapter;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.funcoesTableAdapter = null;
            this.tableAdapterManager.horas_servicosTableAdapter = null;
            this.tableAdapterManager.itens_orcamentoTableAdapter = null;
            this.tableAdapterManager.itens_ordemTableAdapter = null;
            this.tableAdapterManager.itens_servicoTableAdapter = null;
            this.tableAdapterManager.medidasTableAdapter = null;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.ordem_servicoTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.servicos_orcamentoTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.transportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = oficina_stang.BANCOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // ALT_FAZENDA
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(291, 224);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.shapeContainer2);
            this.MaximumSize = new System.Drawing.Size(307, 262);
            this.MinimumSize = new System.Drawing.Size(307, 262);
            this.Name = "ALT_FAZENDA";
            this.Text = "ALTERAR FAZENDA";
            this.Load += new System.EventHandler(this.ALT_FAZENDA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inscricao_estadualTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private BANCO bANCO;
        private System.Windows.Forms.BindingSource fazendasBindingSource;
        private BANCOTableAdapters.fazendasTableAdapter fazendasTableAdapter;
        private BANCOTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox id_cidadeComboBox;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private BANCOTableAdapters.cidadesTableAdapter cidadesTableAdapter;
    }
}