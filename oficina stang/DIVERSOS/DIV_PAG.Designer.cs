namespace oficina_stang.DIVERSOS
{
    partial class DIV_PAG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DIV_PAG));
            System.Windows.Forms.Label tipo_pagLabel;
            System.Windows.Forms.Label vencLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bANCO = new oficina_stang.BANCO();
            this.notas_saidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notas_saidaTableAdapter = new oficina_stang.BANCOTableAdapters.notas_saidaTableAdapter();
            this.tableAdapterManager = new oficina_stang.BANCOTableAdapters.TableAdapterManager();
            this.notas_saidaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.notas_saidaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tipo_pagComboBox = new System.Windows.Forms.ComboBox();
            this.vencMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            tipo_pagLabel = new System.Windows.Forms.Label();
            vencLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notas_saidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notas_saidaBindingNavigator)).BeginInit();
            this.notas_saidaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sentinel Programações";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 32;
            this.button1.Text = "CONCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 47);
            this.button2.TabIndex = 31;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(vencLabel);
            this.groupBox1.Controls.Add(this.vencMaskedTextBox);
            this.groupBox1.Controls.Add(tipo_pagLabel);
            this.groupBox1.Controls.Add(this.tipo_pagComboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 69);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // bANCO
            // 
            this.bANCO.DataSetName = "BANCO";
            this.bANCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notas_saidaBindingSource
            // 
            this.notas_saidaBindingSource.DataMember = "notas_saida";
            this.notas_saidaBindingSource.DataSource = this.bANCO;
            // 
            // notas_saidaTableAdapter
            // 
            this.notas_saidaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.cidadesTableAdapter = null;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.encarregadosTableAdapter = null;
            this.tableAdapterManager.estadosTableAdapter = null;
            this.tableAdapterManager.fazendasTableAdapter = null;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.funcoesTableAdapter = null;
            this.tableAdapterManager.horas_servicosTableAdapter = null;
            this.tableAdapterManager.itens_orcamentoTableAdapter = null;
            this.tableAdapterManager.itens_ordemTableAdapter = null;
            this.tableAdapterManager.itens_saidaTableAdapter = null;
            this.tableAdapterManager.itens_servicoTableAdapter = null;
            this.tableAdapterManager.medidasTableAdapter = null;
            this.tableAdapterManager.notas_saidaTableAdapter = this.notas_saidaTableAdapter;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.ordem_servicoTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.servicos_orcamentoTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.transportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = oficina_stang.BANCOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notas_saidaBindingNavigator
            // 
            this.notas_saidaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notas_saidaBindingNavigator.BindingSource = this.notas_saidaBindingSource;
            this.notas_saidaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notas_saidaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notas_saidaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.notas_saidaBindingNavigatorSaveItem});
            this.notas_saidaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notas_saidaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notas_saidaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notas_saidaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notas_saidaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notas_saidaBindingNavigator.Name = "notas_saidaBindingNavigator";
            this.notas_saidaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notas_saidaBindingNavigator.Size = new System.Drawing.Size(401, 25);
            this.notas_saidaBindingNavigator.TabIndex = 35;
            this.notas_saidaBindingNavigator.Text = "bindingNavigator1";
            this.notas_saidaBindingNavigator.Visible = false;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // notas_saidaBindingNavigatorSaveItem
            // 
            this.notas_saidaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notas_saidaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notas_saidaBindingNavigatorSaveItem.Image")));
            this.notas_saidaBindingNavigatorSaveItem.Name = "notas_saidaBindingNavigatorSaveItem";
            this.notas_saidaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.notas_saidaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.notas_saidaBindingNavigatorSaveItem.Click += new System.EventHandler(this.notas_saidaBindingNavigatorSaveItem_Click);
            // 
            // tipo_pagLabel
            // 
            tipo_pagLabel.AutoSize = true;
            tipo_pagLabel.Location = new System.Drawing.Point(6, 16);
            tipo_pagLabel.Name = "tipo_pagLabel";
            tipo_pagLabel.Size = new System.Drawing.Size(124, 13);
            tipo_pagLabel.TabIndex = 0;
            tipo_pagLabel.Text = "TIPO DE PAGAMENTO:";
            // 
            // tipo_pagComboBox
            // 
            this.tipo_pagComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tipo_pagComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tipo_pagComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notas_saidaBindingSource, "tipo_pag", true));
            this.tipo_pagComboBox.FormattingEnabled = true;
            this.tipo_pagComboBox.Items.AddRange(new object[] {
            "A VISTA",
            "A PRAZO",
            "CARTÃO"});
            this.tipo_pagComboBox.Location = new System.Drawing.Point(9, 32);
            this.tipo_pagComboBox.Name = "tipo_pagComboBox";
            this.tipo_pagComboBox.Size = new System.Drawing.Size(148, 21);
            this.tipo_pagComboBox.TabIndex = 1;
            // 
            // vencLabel
            // 
            vencLabel.AutoSize = true;
            vencLabel.Location = new System.Drawing.Point(163, 17);
            vencLabel.Name = "vencLabel";
            vencLabel.Size = new System.Drawing.Size(81, 13);
            vencLabel.TabIndex = 2;
            vencLabel.Text = "VENCIMENTO:";
            // 
            // vencMaskedTextBox
            // 
            this.vencMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notas_saidaBindingSource, "venc", true));
            this.vencMaskedTextBox.Location = new System.Drawing.Point(163, 33);
            this.vencMaskedTextBox.Mask = "00/00/0000";
            this.vencMaskedTextBox.Name = "vencMaskedTextBox";
            this.vencMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.vencMaskedTextBox.TabIndex = 3;
            this.vencMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // DIV_PAG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(289, 147);
            this.Controls.Add(this.notas_saidaBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "DIV_PAG";
            this.Text = "DIV_PAG";
            this.Load += new System.EventHandler(this.DIV_PAG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notas_saidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notas_saidaBindingNavigator)).EndInit();
            this.notas_saidaBindingNavigator.ResumeLayout(false);
            this.notas_saidaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private BANCO bANCO;
        private System.Windows.Forms.BindingSource notas_saidaBindingSource;
        private BANCOTableAdapters.notas_saidaTableAdapter notas_saidaTableAdapter;
        private BANCOTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notas_saidaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton notas_saidaBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox tipo_pagComboBox;
        private System.Windows.Forms.MaskedTextBox vencMaskedTextBox;
    }
}