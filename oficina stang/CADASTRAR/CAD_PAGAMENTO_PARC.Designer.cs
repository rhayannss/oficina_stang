namespace oficina_stang.CADASTRAR
{
    partial class CAD_PAGAMENTO_PARC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAD_PAGAMENTO_PARC));
            System.Windows.Forms.Label vlor_pagoLabel;
            System.Windows.Forms.Label tipo_pagLabel;
            System.Windows.Forms.Label vlorLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label numero_nfLabel;
            this.bANCO = new oficina_stang.BANCO();
            this.prazoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prazoTableAdapter = new oficina_stang.BANCOTableAdapters.prazoTableAdapter();
            this.tableAdapterManager = new oficina_stang.BANCOTableAdapters.TableAdapterManager();
            this.prazoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.prazoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vlor_pagoTextBox = new System.Windows.Forms.TextBox();
            this.tipo_pagComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.vlorTextBox = new System.Windows.Forms.TextBox();
            this.numero_nfTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            vlor_pagoLabel = new System.Windows.Forms.Label();
            tipo_pagLabel = new System.Windows.Forms.Label();
            vlorLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            numero_nfLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prazoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prazoBindingNavigator)).BeginInit();
            this.prazoBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bANCO
            // 
            this.bANCO.DataSetName = "BANCO";
            this.bANCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prazoBindingSource
            // 
            this.prazoBindingSource.DataMember = "prazo";
            this.prazoBindingSource.DataSource = this.bANCO;
            // 
            // prazoTableAdapter
            // 
            this.prazoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.mov_caixaTableAdapter = null;
            this.tableAdapterManager.mov_cartaoTableAdapter = null;
            this.tableAdapterManager.notas_saidaTableAdapter = null;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.ordem_servicoTableAdapter = null;
            this.tableAdapterManager.prazoTableAdapter = this.prazoTableAdapter;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.servicos_orcamentoTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.transportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = oficina_stang.BANCOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prazoBindingNavigator
            // 
            this.prazoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prazoBindingNavigator.BindingSource = this.prazoBindingSource;
            this.prazoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prazoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prazoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prazoBindingNavigatorSaveItem});
            this.prazoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prazoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prazoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prazoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prazoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prazoBindingNavigator.Name = "prazoBindingNavigator";
            this.prazoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prazoBindingNavigator.Size = new System.Drawing.Size(495, 25);
            this.prazoBindingNavigator.TabIndex = 0;
            this.prazoBindingNavigator.Text = "bindingNavigator1";
            this.prazoBindingNavigator.Visible = false;
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // prazoBindingNavigatorSaveItem
            // 
            this.prazoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prazoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prazoBindingNavigatorSaveItem.Image")));
            this.prazoBindingNavigatorSaveItem.Name = "prazoBindingNavigatorSaveItem";
            this.prazoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prazoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.prazoBindingNavigatorSaveItem.Click += new System.EventHandler(this.prazoBindingNavigatorSaveItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.vlor_pagoTextBox);
            this.groupBox2.Controls.Add(vlor_pagoLabel);
            this.groupBox2.Controls.Add(this.tipo_pagComboBox);
            this.groupBox2.Controls.Add(tipo_pagLabel);
            this.groupBox2.Location = new System.Drawing.Point(160, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 69);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // vlor_pagoTextBox
            // 
            this.vlor_pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prazoBindingSource, "vlor_pago", true));
            this.vlor_pagoTextBox.Location = new System.Drawing.Point(112, 33);
            this.vlor_pagoTextBox.Name = "vlor_pagoTextBox";
            this.vlor_pagoTextBox.Size = new System.Drawing.Size(100, 20);
            this.vlor_pagoTextBox.TabIndex = 39;
            // 
            // vlor_pagoLabel
            // 
            vlor_pagoLabel.AutoSize = true;
            vlor_pagoLabel.Location = new System.Drawing.Point(109, 17);
            vlor_pagoLabel.Name = "vlor_pagoLabel";
            vlor_pagoLabel.Size = new System.Drawing.Size(78, 13);
            vlor_pagoLabel.TabIndex = 38;
            vlor_pagoLabel.Text = "TOTAL PAGO:";
            // 
            // tipo_pagComboBox
            // 
            this.tipo_pagComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prazoBindingSource, "tipo_pag", true));
            this.tipo_pagComboBox.FormattingEnabled = true;
            this.tipo_pagComboBox.Items.AddRange(new object[] {
            "A VISTA",
            "CARTÃO"});
            this.tipo_pagComboBox.Location = new System.Drawing.Point(6, 32);
            this.tipo_pagComboBox.Name = "tipo_pagComboBox";
            this.tipo_pagComboBox.Size = new System.Drawing.Size(100, 21);
            this.tipo_pagComboBox.TabIndex = 39;
            // 
            // tipo_pagLabel
            // 
            tipo_pagLabel.AutoSize = true;
            tipo_pagLabel.Location = new System.Drawing.Point(3, 16);
            tipo_pagLabel.Name = "tipo_pagLabel";
            tipo_pagLabel.Size = new System.Drawing.Size(106, 13);
            tipo_pagLabel.TabIndex = 38;
            tipo_pagLabel.Text = "TIPO PAGAMENTO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataTextBox);
            this.groupBox1.Controls.Add(vlorLabel);
            this.groupBox1.Controls.Add(this.vlorTextBox);
            this.groupBox1.Controls.Add(dataLabel);
            this.groupBox1.Controls.Add(numero_nfLabel);
            this.groupBox1.Controls.Add(this.numero_nfTextBox);
            this.groupBox1.Location = new System.Drawing.Point(160, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 66);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // dataTextBox
            // 
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prazoBindingSource, "data", true));
            this.dataTextBox.Location = new System.Drawing.Point(112, 32);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ReadOnly = true;
            this.dataTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataTextBox.TabIndex = 38;
            // 
            // vlorLabel
            // 
            vlorLabel.AutoSize = true;
            vlorLabel.Location = new System.Drawing.Point(215, 16);
            vlorLabel.Name = "vlorLabel";
            vlorLabel.Size = new System.Drawing.Size(46, 13);
            vlorLabel.TabIndex = 4;
            vlorLabel.Text = "VALOR:";
            // 
            // vlorTextBox
            // 
            this.vlorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prazoBindingSource, "vlor", true));
            this.vlorTextBox.Location = new System.Drawing.Point(218, 32);
            this.vlorTextBox.Name = "vlorTextBox";
            this.vlorTextBox.ReadOnly = true;
            this.vlorTextBox.Size = new System.Drawing.Size(100, 20);
            this.vlorTextBox.TabIndex = 5;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(106, 16);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(39, 13);
            dataLabel.TabIndex = 2;
            dataLabel.Text = "DATA:";
            // 
            // numero_nfLabel
            // 
            numero_nfLabel.AutoSize = true;
            numero_nfLabel.Location = new System.Drawing.Point(3, 16);
            numero_nfLabel.Name = "numero_nfLabel";
            numero_nfLabel.Size = new System.Drawing.Size(45, 13);
            numero_nfLabel.TabIndex = 0;
            numero_nfLabel.Text = "Nº N.F.:";
            // 
            // numero_nfTextBox
            // 
            this.numero_nfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prazoBindingSource, "numero_nf", true));
            this.numero_nfTextBox.Location = new System.Drawing.Point(6, 32);
            this.numero_nfTextBox.Name = "numero_nfTextBox";
            this.numero_nfTextBox.ReadOnly = true;
            this.numero_nfTextBox.Size = new System.Drawing.Size(100, 20);
            this.numero_nfTextBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::oficina_stang.Properties.Resources.hitech;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(157, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Sentinel Programações";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 40;
            this.button1.Text = "CONCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 47);
            this.button2.TabIndex = 39;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.X1 = 273;
            this.lineShape1.X2 = 475;
            this.lineShape1.Y1 = 162;
            this.lineShape1.Y2 = 162;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(495, 232);
            this.shapeContainer1.TabIndex = 45;
            this.shapeContainer1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "FALTA:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 41;
            // 
            // CAD_PAGAMENTO_PARC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 232);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prazoBindingNavigator);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "CAD_PAGAMENTO_PARC";
            this.Text = "CAD_PAGAMENTO_PARC";
            this.Load += new System.EventHandler(this.CAD_PAGAMENTO_PARC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prazoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prazoBindingNavigator)).EndInit();
            this.prazoBindingNavigator.ResumeLayout(false);
            this.prazoBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BANCO bANCO;
        private System.Windows.Forms.BindingSource prazoBindingSource;
        private BANCOTableAdapters.prazoTableAdapter prazoTableAdapter;
        private BANCOTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prazoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prazoBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox vlor_pagoTextBox;
        private System.Windows.Forms.ComboBox tipo_pagComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.TextBox vlorTextBox;
        private System.Windows.Forms.TextBox numero_nfTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}