namespace oficina_stang.CADASTRAR
{
    partial class CAD_NT_SAIDA
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
            System.Windows.Forms.Label id_notaLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label id_clienteLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAD_NT_SAIDA));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.notas_saidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANCO = new oficina_stang.BANCO();
            this.descontoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.id_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.notas_saidaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.notas_saidaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_notaTextBox = new System.Windows.Forms.TextBox();
            this.notas_saidaTableAdapter = new oficina_stang.BANCOTableAdapters.notas_saidaTableAdapter();
            this.tableAdapterManager = new oficina_stang.BANCOTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new oficina_stang.BANCOTableAdapters.clientesTableAdapter();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            id_notaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            id_clienteLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notas_saidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notas_saidaBindingNavigator)).BeginInit();
            this.notas_saidaBindingNavigator.SuspendLayout();
            this.shapeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_notaLabel
            // 
            id_notaLabel.AutoSize = true;
            id_notaLabel.Location = new System.Drawing.Point(6, 16);
            id_notaLabel.Name = "id_notaLabel";
            id_notaLabel.Size = new System.Drawing.Size(58, 13);
            id_notaLabel.TabIndex = 0;
            id_notaLabel.Text = "NUMERO:";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(150, 16);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(55, 13);
            id_clienteLabel.TabIndex = 37;
            id_clienteLabel.Text = "CLIENTE:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(70, 16);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(39, 13);
            dataLabel.TabIndex = 37;
            dataLabel.Text = "DATA:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(6, 55);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(67, 13);
            valorLabel.TabIndex = 37;
            valorLabel.Text = "SUBTOTAL:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(127, 56);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(70, 13);
            descontoLabel.TabIndex = 37;
            descontoLabel.Text = "DESCONTO:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(245, 55);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(45, 13);
            totalLabel.TabIndex = 37;
            totalLabel.Text = "TOTAL:";
            // 
            // id_clienteLabel1
            // 
            id_clienteLabel1.AutoSize = true;
            id_clienteLabel1.Location = new System.Drawing.Point(171, 294);
            id_clienteLabel1.Name = "id_clienteLabel1";
            id_clienteLabel1.Size = new System.Drawing.Size(52, 13);
            id_clienteLabel1.TabIndex = 0;
            id_clienteLabel1.Text = "id cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(160, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sentinel Programações";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "CONCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::oficina_stang.Properties.Resources.hitech;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Controls.Add(totalLabel);
            this.groupBox1.Controls.Add(this.descontoTextBox);
            this.groupBox1.Controls.Add(descontoLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.dataMaskedTextBox);
            this.groupBox1.Controls.Add(dataLabel);
            this.groupBox1.Controls.Add(this.id_clienteComboBox);
            this.groupBox1.Controls.Add(id_clienteLabel);
            this.groupBox1.Controls.Add(this.numeroTextBox);
            this.groupBox1.Controls.Add(id_notaLabel);
            this.groupBox1.Location = new System.Drawing.Point(161, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notas_saidaBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(248, 71);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(115, 20);
            this.totalTextBox.TabIndex = 4;
            // 
            // notas_saidaBindingSource
            // 
            this.notas_saidaBindingSource.DataMember = "notas_saida";
            this.notas_saidaBindingSource.DataSource = this.bANCO;
            // 
            // bANCO
            // 
            this.bANCO.DataSetName = "BANCO";
            this.bANCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descontoTextBox
            // 
            this.descontoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notas_saidaBindingSource, "desconto", true));
            this.descontoTextBox.Location = new System.Drawing.Point(127, 71);
            this.descontoTextBox.Name = "descontoTextBox";
            this.descontoTextBox.Size = new System.Drawing.Size(115, 20);
            this.descontoTextBox.TabIndex = 3;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notas_saidaBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(6, 71);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(115, 20);
            this.valorTextBox.TabIndex = 38;
            this.valorTextBox.TabStop = false;
            // 
            // dataMaskedTextBox
            // 
            this.dataMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notas_saidaBindingSource, "data", true));
            this.dataMaskedTextBox.Location = new System.Drawing.Point(70, 32);
            this.dataMaskedTextBox.Mask = "00/00/0000";
            this.dataMaskedTextBox.Name = "dataMaskedTextBox";
            this.dataMaskedTextBox.Size = new System.Drawing.Size(77, 20);
            this.dataMaskedTextBox.TabIndex = 1;
            this.dataMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // id_clienteComboBox
            // 
            this.id_clienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_clienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notas_saidaBindingSource, "id_cliente", true));
            this.id_clienteComboBox.DataSource = this.clientesBindingSource;
            this.id_clienteComboBox.DisplayMember = "nome";
            this.id_clienteComboBox.FormattingEnabled = true;
            this.id_clienteComboBox.Location = new System.Drawing.Point(153, 32);
            this.id_clienteComboBox.Name = "id_clienteComboBox";
            this.id_clienteComboBox.Size = new System.Drawing.Size(210, 21);
            this.id_clienteComboBox.TabIndex = 2;
            this.id_clienteComboBox.ValueMember = "id_cliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.bANCO;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notas_saidaBindingSource, "numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(6, 32);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(58, 20);
            this.numeroTextBox.TabIndex = 0;
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
            this.notas_saidaBindingNavigator.Location = new System.Drawing.Point(154, 0);
            this.notas_saidaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notas_saidaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notas_saidaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notas_saidaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notas_saidaBindingNavigator.Name = "notas_saidaBindingNavigator";
            this.notas_saidaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notas_saidaBindingNavigator.Size = new System.Drawing.Size(707, 25);
            this.notas_saidaBindingNavigator.TabIndex = 37;
            this.notas_saidaBindingNavigator.Text = "bindingNavigator1";
            this.notas_saidaBindingNavigator.Visible = false;
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
            // notas_saidaBindingNavigatorSaveItem
            // 
            this.notas_saidaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notas_saidaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notas_saidaBindingNavigatorSaveItem.Image")));
            this.notas_saidaBindingNavigatorSaveItem.Name = "notas_saidaBindingNavigatorSaveItem";
            this.notas_saidaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.notas_saidaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.notas_saidaBindingNavigatorSaveItem.Click += new System.EventHandler(this.notas_saidaBindingNavigatorSaveItem_Click);
            // 
            // id_notaTextBox
            // 
            this.id_notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notas_saidaBindingSource, "id_nota", true));
            this.id_notaTextBox.Location = new System.Drawing.Point(163, 244);
            this.id_notaTextBox.Name = "id_notaTextBox";
            this.id_notaTextBox.ReadOnly = true;
            this.id_notaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_notaTextBox.TabIndex = 1;
            this.id_notaTextBox.TabStop = false;
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
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.X1 = 275;
            this.lineShape1.X2 = 529;
            this.lineShape1.Y1 = 129;
            this.lineShape1.Y2 = 129;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Controls.Add(id_clienteLabel1);
            this.shapeContainer1.Controls.Add(this.id_clienteTextBox);
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(555, 376);
            this.shapeContainer1.TabIndex = 38;
            this.shapeContainer1.TabStop = false;
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(229, 291);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.ReadOnly = true;
            this.id_clienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_clienteTextBox.TabIndex = 1;
            this.id_clienteTextBox.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(161, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 47);
            this.button3.TabIndex = 1;
            this.button3.Text = "O.S. DA N.F";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CAD_NT_SAIDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 376);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.notas_saidaBindingNavigator);
            this.Controls.Add(this.id_notaTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "CAD_NT_SAIDA";
            this.Text = "CAD_NT_SAIDA";
            this.Load += new System.EventHandler(this.CAD_NT_SAIDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notas_saidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notas_saidaBindingNavigator)).EndInit();
            this.notas_saidaBindingNavigator.ResumeLayout(false);
            this.notas_saidaBindingNavigator.PerformLayout();
            this.shapeContainer1.ResumeLayout(false);
            this.shapeContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.TextBox id_notaTextBox;
        private System.Windows.Forms.ComboBox id_clienteComboBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BANCOTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox descontoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.MaskedTextBox dataMaskedTextBox;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox id_clienteTextBox;
    }
}