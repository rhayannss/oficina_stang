﻿namespace oficina_stang.CADASTRAR
{
    partial class CAD_FAZENDA
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
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label inscricao_estadualLabel;
            System.Windows.Forms.Label id_cidadeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAD_FAZENDA));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.fazendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANCO = new oficina_stang.BANCO();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscricao_estadualTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.fazendasTableAdapter = new oficina_stang.BANCOTableAdapters.fazendasTableAdapter();
            this.tableAdapterManager = new oficina_stang.BANCOTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new oficina_stang.BANCOTableAdapters.clientesTableAdapter();
            this.fazendasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fazendasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadesTableAdapter = new oficina_stang.BANCOTableAdapters.cidadesTableAdapter();
            id_clienteLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            inscricao_estadualLabel = new System.Windows.Forms.Label();
            id_cidadeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasBindingNavigator)).BeginInit();
            this.fazendasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(25, 247);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(52, 13);
            id_clienteLabel.TabIndex = 37;
            id_clienteLabel.Text = "id cliente:";
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
            // inscricao_estadualLabel
            // 
            inscricao_estadualLabel.AutoSize = true;
            inscricao_estadualLabel.Location = new System.Drawing.Point(6, 55);
            inscricao_estadualLabel.Name = "inscricao_estadualLabel";
            inscricao_estadualLabel.Size = new System.Drawing.Size(128, 13);
            inscricao_estadualLabel.TabIndex = 4;
            inscricao_estadualLabel.Text = "INSCRIÇÃO ESTADUAL:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sentinel Programações";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(10, 166);
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
            this.button2.Location = new System.Drawing.Point(152, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_cidadeComboBox);
            this.groupBox1.Controls.Add(id_cidadeLabel);
            this.groupBox1.Controls.Add(inscricao_estadualLabel);
            this.groupBox1.Controls.Add(this.inscricao_estadualTextBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 143);
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
            this.id_cidadeComboBox.TabIndex = 6;
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
            // fazendasTableAdapter
            // 
            this.fazendasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.cidadesTableAdapter = null;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
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
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // fazendasBindingNavigator
            // 
            this.fazendasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fazendasBindingNavigator.BindingSource = this.fazendasBindingSource;
            this.fazendasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fazendasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fazendasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.fazendasBindingNavigatorSaveItem});
            this.fazendasBindingNavigator.Location = new System.Drawing.Point(154, 0);
            this.fazendasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fazendasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fazendasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fazendasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fazendasBindingNavigator.Name = "fazendasBindingNavigator";
            this.fazendasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fazendasBindingNavigator.Size = new System.Drawing.Size(428, 25);
            this.fazendasBindingNavigator.TabIndex = 37;
            this.fazendasBindingNavigator.Text = "bindingNavigator1";
            this.fazendasBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // fazendasBindingNavigatorSaveItem
            // 
            this.fazendasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fazendasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fazendasBindingNavigatorSaveItem.Image")));
            this.fazendasBindingNavigatorSaveItem.Name = "fazendasBindingNavigatorSaveItem";
            this.fazendasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fazendasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.fazendasBindingNavigatorSaveItem.Click += new System.EventHandler(this.fazendasBindingNavigatorSaveItem_Click);
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fazendasBindingSource, "id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(83, 244);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_clienteTextBox.TabIndex = 38;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.X1 = 118;
            this.lineShape1.X2 = 276;
            this.lineShape1.Y1 = 156;
            this.lineShape1.Y2 = 156;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(290, 224);
            this.shapeContainer1.TabIndex = 39;
            this.shapeContainer1.TabStop = false;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.bANCO;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // CAD_FAZENDA
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(290, 224);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(this.fazendasBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.shapeContainer1);
            this.MaximumSize = new System.Drawing.Size(306, 262);
            this.MinimumSize = new System.Drawing.Size(306, 262);
            this.Name = "CAD_FAZENDA";
            this.Text = "CADASTRAR FAZENDA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CAD_FAZENDA_FormClosing);
            this.Load += new System.EventHandler(this.CAD_FAZENDA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasBindingNavigator)).EndInit();
            this.fazendasBindingNavigator.ResumeLayout(false);
            this.fazendasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private BANCO bANCO;
        private System.Windows.Forms.BindingSource fazendasBindingSource;
        private BANCOTableAdapters.fazendasTableAdapter fazendasTableAdapter;
        private BANCOTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fazendasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton fazendasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox inscricao_estadualTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private BANCOTableAdapters.clientesTableAdapter clientesTableAdapter;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.ComboBox id_cidadeComboBox;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private BANCOTableAdapters.cidadesTableAdapter cidadesTableAdapter;
    }
}