namespace oficina_stang.CADASTRAR
{
    partial class CAD_TRANSPORTADORA
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
            System.Windows.Forms.Label rasao_socialLabel;
            System.Windows.Forms.Label nome_fantasiaLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label telefone2Label;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label contatoLabel;
            System.Windows.Forms.Label id_cidadeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label bairroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAD_TRANSPORTADORA));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contatoTextBox = new System.Windows.Forms.TextBox();
            this.transportadorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANCO = new oficina_stang.BANCO();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefone2MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nome_fantasiaTextBox = new System.Windows.Forms.TextBox();
            this.rasao_socialTextBox = new System.Windows.Forms.TextBox();
            this.transportadorasTableAdapter = new oficina_stang.BANCOTableAdapters.transportadorasTableAdapter();
            this.tableAdapterManager = new oficina_stang.BANCOTableAdapters.TableAdapterManager();
            this.transportadorasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.transportadorasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.id_cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadesTableAdapter = new oficina_stang.BANCOTableAdapters.cidadesTableAdapter();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            rasao_socialLabel = new System.Windows.Forms.Label();
            nome_fantasiaLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            telefone2Label = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            id_cidadeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportadorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportadorasBindingNavigator)).BeginInit();
            this.transportadorasBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rasao_socialLabel
            // 
            rasao_socialLabel.AutoSize = true;
            rasao_socialLabel.Location = new System.Drawing.Point(6, 16);
            rasao_socialLabel.Name = "rasao_socialLabel";
            rasao_socialLabel.Size = new System.Drawing.Size(88, 13);
            rasao_socialLabel.TabIndex = 0;
            rasao_socialLabel.Text = "RAZÃO SOCIAL:";
            // 
            // nome_fantasiaLabel
            // 
            nome_fantasiaLabel.AutoSize = true;
            nome_fantasiaLabel.Location = new System.Drawing.Point(201, 16);
            nome_fantasiaLabel.Name = "nome_fantasiaLabel";
            nome_fantasiaLabel.Size = new System.Drawing.Size(97, 13);
            nome_fantasiaLabel.TabIndex = 37;
            nome_fantasiaLabel.Text = "NOME FANTASIA:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(152, 55);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(66, 13);
            telefoneLabel.TabIndex = 39;
            telefoneLabel.Text = "TELEFONE:";
            // 
            // telefone2Label
            // 
            telefone2Label.AutoSize = true;
            telefone2Label.Location = new System.Drawing.Point(254, 55);
            telefone2Label.Name = "telefone2Label";
            telefone2Label.Size = new System.Drawing.Size(66, 13);
            telefone2Label.TabIndex = 40;
            telefone2Label.Text = "TELEFONE:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(6, 94);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(42, 13);
            emailLabel.TabIndex = 37;
            emailLabel.Text = "EMAIL:";
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.Location = new System.Drawing.Point(201, 94);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(62, 13);
            contatoLabel.TabIndex = 37;
            contatoLabel.Text = "CONTATO:";
            // 
            // id_cidadeLabel
            // 
            id_cidadeLabel.AutoSize = true;
            id_cidadeLabel.Location = new System.Drawing.Point(6, 16);
            id_cidadeLabel.Name = "id_cidadeLabel";
            id_cidadeLabel.Size = new System.Drawing.Size(50, 13);
            id_cidadeLabel.TabIndex = 0;
            id_cidadeLabel.Text = "CIDADE:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(6, 56);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(70, 13);
            enderecoLabel.TabIndex = 2;
            enderecoLabel.Text = "ENDEREÇO:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(288, 15);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(31, 13);
            cepLabel.TabIndex = 4;
            cepLabel.Text = "CEP:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(288, 55);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(51, 13);
            bairroLabel.TabIndex = 6;
            bairroLabel.Text = "BAIRRO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(160, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sentinel Programações";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 33;
            this.button1.Text = "CONCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 47);
            this.button2.TabIndex = 32;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::oficina_stang.Properties.Resources.hitech;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contatoTextBox);
            this.groupBox1.Controls.Add(contatoLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(telefone2Label);
            this.groupBox1.Controls.Add(this.telefone2MaskedTextBox);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(this.telefoneMaskedTextBox);
            this.groupBox1.Controls.Add(this.cnpjMaskedTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nome_fantasiaTextBox);
            this.groupBox1.Controls.Add(nome_fantasiaLabel);
            this.groupBox1.Controls.Add(rasao_socialLabel);
            this.groupBox1.Controls.Add(this.rasao_socialTextBox);
            this.groupBox1.Location = new System.Drawing.Point(161, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 143);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportadorasBindingSource, "contato", true));
            this.contatoTextBox.Location = new System.Drawing.Point(204, 110);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(187, 20);
            this.contatoTextBox.TabIndex = 38;
            // 
            // transportadorasBindingSource
            // 
            this.transportadorasBindingSource.DataMember = "transportadoras";
            this.transportadorasBindingSource.DataSource = this.bANCO;
            // 
            // bANCO
            // 
            this.bANCO.DataSetName = "BANCO";
            this.bANCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailTextBox
            // 
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportadorasBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(9, 110);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(187, 20);
            this.emailTextBox.TabIndex = 38;
            // 
            // telefone2MaskedTextBox
            // 
            this.telefone2MaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportadorasBindingSource, "telefone2", true));
            this.telefone2MaskedTextBox.Location = new System.Drawing.Point(258, 71);
            this.telefone2MaskedTextBox.Mask = "(00) 0000-00000";
            this.telefone2MaskedTextBox.Name = "telefone2MaskedTextBox";
            this.telefone2MaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefone2MaskedTextBox.TabIndex = 41;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportadorasBindingSource, "telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(152, 71);
            this.telefoneMaskedTextBox.Mask = "(00) 0000-00000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneMaskedTextBox.TabIndex = 40;
            // 
            // cnpjMaskedTextBox
            // 
            this.cnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportadorasBindingSource, "cnpj", true));
            this.cnpjMaskedTextBox.Location = new System.Drawing.Point(37, 71);
            this.cnpjMaskedTextBox.Mask = "00.000.000/0000-00";
            this.cnpjMaskedTextBox.Name = "cnpjMaskedTextBox";
            this.cnpjMaskedTextBox.Size = new System.Drawing.Size(109, 20);
            this.cnpjMaskedTextBox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "CNPJ:";
            // 
            // nome_fantasiaTextBox
            // 
            this.nome_fantasiaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome_fantasiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportadorasBindingSource, "nome_fantasia", true));
            this.nome_fantasiaTextBox.Location = new System.Drawing.Point(204, 32);
            this.nome_fantasiaTextBox.Name = "nome_fantasiaTextBox";
            this.nome_fantasiaTextBox.Size = new System.Drawing.Size(187, 20);
            this.nome_fantasiaTextBox.TabIndex = 38;
            // 
            // rasao_socialTextBox
            // 
            this.rasao_socialTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.rasao_socialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportadorasBindingSource, "rasao_social", true));
            this.rasao_socialTextBox.Location = new System.Drawing.Point(9, 32);
            this.rasao_socialTextBox.Name = "rasao_socialTextBox";
            this.rasao_socialTextBox.Size = new System.Drawing.Size(187, 20);
            this.rasao_socialTextBox.TabIndex = 1;
            // 
            // transportadorasTableAdapter
            // 
            this.transportadorasTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.itens_servicoTableAdapter = null;
            this.tableAdapterManager.medidasTableAdapter = null;
            this.tableAdapterManager.orcamentoTableAdapter = null;
            this.tableAdapterManager.ordem_servicoTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.servicos_orcamentoTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.transportadorasTableAdapter = this.transportadorasTableAdapter;
            this.tableAdapterManager.UpdateOrder = oficina_stang.BANCOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // transportadorasBindingNavigator
            // 
            this.transportadorasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.transportadorasBindingNavigator.BindingSource = this.transportadorasBindingSource;
            this.transportadorasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.transportadorasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.transportadorasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.transportadorasBindingNavigatorSaveItem});
            this.transportadorasBindingNavigator.Location = new System.Drawing.Point(154, 0);
            this.transportadorasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.transportadorasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.transportadorasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.transportadorasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.transportadorasBindingNavigator.Name = "transportadorasBindingNavigator";
            this.transportadorasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.transportadorasBindingNavigator.Size = new System.Drawing.Size(492, 25);
            this.transportadorasBindingNavigator.TabIndex = 37;
            this.transportadorasBindingNavigator.Text = "bindingNavigator1";
            this.transportadorasBindingNavigator.Visible = false;
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
            // transportadorasBindingNavigatorSaveItem
            // 
            this.transportadorasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transportadorasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("transportadorasBindingNavigatorSaveItem.Image")));
            this.transportadorasBindingNavigatorSaveItem.Name = "transportadorasBindingNavigatorSaveItem";
            this.transportadorasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.transportadorasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.transportadorasBindingNavigatorSaveItem.Click += new System.EventHandler(this.transportadorasBindingNavigatorSaveItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(bairroLabel);
            this.groupBox2.Controls.Add(this.bairroTextBox);
            this.groupBox2.Controls.Add(cepLabel);
            this.groupBox2.Controls.Add(this.cepMaskedTextBox);
            this.groupBox2.Controls.Add(enderecoLabel);
            this.groupBox2.Controls.Add(this.enderecoTextBox);
            this.groupBox2.Controls.Add(this.id_cidadeComboBox);
            this.groupBox2.Controls.Add(id_cidadeLabel);
            this.groupBox2.Location = new System.Drawing.Point(161, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 109);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportadorasBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(291, 71);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(100, 20);
            this.bairroTextBox.TabIndex = 7;
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportadorasBindingSource, "cep", true));
            this.cepMaskedTextBox.Location = new System.Drawing.Point(291, 32);
            this.cepMaskedTextBox.Mask = "00000-000";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cepMaskedTextBox.TabIndex = 5;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportadorasBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(9, 72);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(276, 20);
            this.enderecoTextBox.TabIndex = 3;
            // 
            // id_cidadeComboBox
            // 
            this.id_cidadeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.id_cidadeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.id_cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.transportadorasBindingSource, "id_cidade", true));
            this.id_cidadeComboBox.DataSource = this.cidadesBindingSource;
            this.id_cidadeComboBox.DisplayMember = "nome";
            this.id_cidadeComboBox.FormattingEnabled = true;
            this.id_cidadeComboBox.Location = new System.Drawing.Point(9, 32);
            this.id_cidadeComboBox.Name = "id_cidadeComboBox";
            this.id_cidadeComboBox.Size = new System.Drawing.Size(276, 21);
            this.id_cidadeComboBox.TabIndex = 2;
            this.id_cidadeComboBox.ValueMember = "id_cidade";
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "cidades";
            this.cidadesBindingSource.DataSource = this.bANCO;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.X1 = 278;
            this.lineShape1.X2 = 559;
            this.lineShape1.Y1 = 283;
            this.lineShape1.Y2 = 283;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(575, 354);
            this.shapeContainer1.TabIndex = 39;
            this.shapeContainer1.TabStop = false;
            // 
            // CAD_TRANSPORTADORA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(575, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.transportadorasBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "CAD_TRANSPORTADORA";
            this.Text = "CAD_TRANSPORTADORA";
            this.Load += new System.EventHandler(this.CAD_TRANSPORTADORA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportadorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportadorasBindingNavigator)).EndInit();
            this.transportadorasBindingNavigator.ResumeLayout(false);
            this.transportadorasBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource transportadorasBindingSource;
        private BANCOTableAdapters.transportadorasTableAdapter transportadorasTableAdapter;
        private BANCOTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator transportadorasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton transportadorasBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox telefone2MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cnpjMaskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome_fantasiaTextBox;
        private System.Windows.Forms.TextBox rasao_socialTextBox;
        private System.Windows.Forms.TextBox contatoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox id_cidadeComboBox;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private BANCOTableAdapters.cidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}