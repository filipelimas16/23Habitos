namespace WindowsFormsApplication1
{
    partial class load_tarefa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagrid_ListTarefas = new System.Windows.Forms.DataGridView();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.text_Tarefa = new System.Windows.Forms.TextBox();
            this.num_nivelTarefa = new System.Windows.Forms.NumericUpDown();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.label_Tarefa = new System.Windows.Forms.Label();
            this.label_NivelT = new System.Windows.Forms.Label();
            this.mask_data = new System.Windows.Forms.MaskedTextBox();
            this.label_Data = new System.Windows.Forms.Label();
            this.btn_ListTarefas = new System.Windows.Forms.Button();
            this.label_Dayweek = new System.Windows.Forms.Label();
            this.cmbo_Dayweek = new System.Windows.Forms.ComboBox();
            this.btn_Criarnovo = new System.Windows.Forms.Button();
            this.label_NivelR = new System.Windows.Forms.Label();
            this.label_Recompensa = new System.Windows.Forms.Label();
            this.num_nivelRecompensa = new System.Windows.Forms.NumericUpDown();
            this.text_Recompensa = new System.Windows.Forms.TextBox();
            this.label_NivelC = new System.Windows.Forms.Label();
            this.label_Consequencia = new System.Windows.Forms.Label();
            this.num_nivelConsequencia = new System.Windows.Forms.NumericUpDown();
            this.text_Consequencia = new System.Windows.Forms.TextBox();
            this.btn_VerAgenda = new System.Windows.Forms.Button();
            this.checkedListBox_Segunda = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_Terca = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_Quarta = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_Quinta = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_Sexta = new System.Windows.Forms.CheckedListBox();
            this.label_S = new System.Windows.Forms.Label();
            this.label_T = new System.Windows.Forms.Label();
            this.label_Q = new System.Windows.Forms.Label();
            this.label_Quinta = new System.Windows.Forms.Label();
            this.label_Sexta = new System.Windows.Forms.Label();
            this.btn_NovaTarefa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ListTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelRecompensa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelConsequencia)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_ListTarefas
            // 
            this.datagrid_ListTarefas.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_ListTarefas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_ListTarefas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_ListTarefas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_ListTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_ListTarefas.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_ListTarefas.GridColor = System.Drawing.SystemColors.Control;
            this.datagrid_ListTarefas.Location = new System.Drawing.Point(32, 84);
            this.datagrid_ListTarefas.Name = "datagrid_ListTarefas";
            this.datagrid_ListTarefas.Size = new System.Drawing.Size(1088, 328);
            this.datagrid_ListTarefas.TabIndex = 0;
            this.datagrid_ListTarefas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_ListTarefas_CellContentClick);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(880, 547);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(117, 82);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // text_Tarefa
            // 
            this.text_Tarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Tarefa.Location = new System.Drawing.Point(42, 442);
            this.text_Tarefa.Multiline = true;
            this.text_Tarefa.Name = "text_Tarefa";
            this.text_Tarefa.Size = new System.Drawing.Size(253, 29);
            this.text_Tarefa.TabIndex = 2;
            // 
            // num_nivelTarefa
            // 
            this.num_nivelTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_nivelTarefa.Location = new System.Drawing.Point(42, 525);
            this.num_nivelTarefa.Name = "num_nivelTarefa";
            this.num_nivelTarefa.Size = new System.Drawing.Size(125, 29);
            this.num_nivelTarefa.TabIndex = 3;
            this.num_nivelTarefa.ValueChanged += new System.EventHandler(this.num_nivelTarefa_ValueChanged);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Enabled = false;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.Black;
            this.btn_Alterar.Location = new System.Drawing.Point(32, 12);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(98, 66);
            this.btn_Alterar.TabIndex = 4;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(145, 12);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(98, 66);
            this.btn_Excluir.TabIndex = 5;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // label_Tarefa
            // 
            this.label_Tarefa.AutoSize = true;
            this.label_Tarefa.BackColor = System.Drawing.Color.Transparent;
            this.label_Tarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tarefa.ForeColor = System.Drawing.Color.Azure;
            this.label_Tarefa.Location = new System.Drawing.Point(38, 415);
            this.label_Tarefa.Name = "label_Tarefa";
            this.label_Tarefa.Size = new System.Drawing.Size(108, 25);
            this.label_Tarefa.TabIndex = 6;
            this.label_Tarefa.Text = "TAREFA:";
            // 
            // label_NivelT
            // 
            this.label_NivelT.AutoSize = true;
            this.label_NivelT.BackColor = System.Drawing.Color.Transparent;
            this.label_NivelT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NivelT.ForeColor = System.Drawing.Color.Azure;
            this.label_NivelT.Location = new System.Drawing.Point(38, 474);
            this.label_NivelT.Name = "label_NivelT";
            this.label_NivelT.Size = new System.Drawing.Size(174, 50);
            this.label_NivelT.TabIndex = 7;
            this.label_NivelT.Text = "NÍVEL DE\r\nIMPORTANCIA:";
            // 
            // mask_data
            // 
            this.mask_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_data.Location = new System.Drawing.Point(316, 600);
            this.mask_data.Mask = "00/00/0000";
            this.mask_data.Name = "mask_data";
            this.mask_data.Size = new System.Drawing.Size(125, 29);
            this.mask_data.TabIndex = 8;
            this.mask_data.ValidatingType = typeof(System.DateTime);
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.BackColor = System.Drawing.Color.Transparent;
            this.label_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Data.ForeColor = System.Drawing.Color.Azure;
            this.label_Data.Location = new System.Drawing.Point(312, 575);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(88, 25);
            this.label_Data.TabIndex = 9;
            this.label_Data.Text = "*DATA:";
            // 
            // btn_ListTarefas
            // 
            this.btn_ListTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListTarefas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ListTarefas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_ListTarefas.Location = new System.Drawing.Point(1003, 547);
            this.btn_ListTarefas.Name = "btn_ListTarefas";
            this.btn_ListTarefas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ListTarefas.Size = new System.Drawing.Size(120, 82);
            this.btn_ListTarefas.TabIndex = 10;
            this.btn_ListTarefas.Text = "Listar Tarefas";
            this.btn_ListTarefas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_ListTarefas.UseVisualStyleBackColor = true;
            this.btn_ListTarefas.Click += new System.EventHandler(this.btn_ListTarefas_Click);
            // 
            // label_Dayweek
            // 
            this.label_Dayweek.AutoSize = true;
            this.label_Dayweek.BackColor = System.Drawing.Color.Transparent;
            this.label_Dayweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dayweek.ForeColor = System.Drawing.Color.Azure;
            this.label_Dayweek.Location = new System.Drawing.Point(38, 575);
            this.label_Dayweek.Name = "label_Dayweek";
            this.label_Dayweek.Size = new System.Drawing.Size(196, 25);
            this.label_Dayweek.TabIndex = 13;
            this.label_Dayweek.Text = "DIA DA SEMANA:";
            // 
            // cmbo_Dayweek
            // 
            this.cmbo_Dayweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_Dayweek.FormattingEnabled = true;
            this.cmbo_Dayweek.Items.AddRange(new object[] {
            "segunda",
            "terca",
            "quarta",
            "quinta",
            "sexta"});
            this.cmbo_Dayweek.Location = new System.Drawing.Point(42, 602);
            this.cmbo_Dayweek.Name = "cmbo_Dayweek";
            this.cmbo_Dayweek.Size = new System.Drawing.Size(178, 33);
            this.cmbo_Dayweek.TabIndex = 14;
            // 
            // btn_Criarnovo
            // 
            this.btn_Criarnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Criarnovo.Location = new System.Drawing.Point(880, 547);
            this.btn_Criarnovo.Name = "btn_Criarnovo";
            this.btn_Criarnovo.Size = new System.Drawing.Size(117, 82);
            this.btn_Criarnovo.TabIndex = 15;
            this.btn_Criarnovo.Text = "Cria novo";
            this.btn_Criarnovo.UseVisualStyleBackColor = true;
            this.btn_Criarnovo.Visible = false;
            this.btn_Criarnovo.Click += new System.EventHandler(this.btn_Criarnovo_Click);
            // 
            // label_NivelR
            // 
            this.label_NivelR.AutoSize = true;
            this.label_NivelR.BackColor = System.Drawing.Color.Transparent;
            this.label_NivelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NivelR.ForeColor = System.Drawing.Color.Azure;
            this.label_NivelR.Location = new System.Drawing.Point(594, 480);
            this.label_NivelR.Name = "label_NivelR";
            this.label_NivelR.Size = new System.Drawing.Size(178, 50);
            this.label_NivelR.TabIndex = 33;
            this.label_NivelR.Text = "NÍVEL DESSA \r\nRECOMPENSA:";
            // 
            // label_Recompensa
            // 
            this.label_Recompensa.AutoSize = true;
            this.label_Recompensa.BackColor = System.Drawing.Color.Transparent;
            this.label_Recompensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Recompensa.ForeColor = System.Drawing.Color.Azure;
            this.label_Recompensa.Location = new System.Drawing.Point(593, 415);
            this.label_Recompensa.Name = "label_Recompensa";
            this.label_Recompensa.Size = new System.Drawing.Size(178, 25);
            this.label_Recompensa.TabIndex = 32;
            this.label_Recompensa.Text = "RECOMPENSA:";
            // 
            // num_nivelRecompensa
            // 
            this.num_nivelRecompensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_nivelRecompensa.Location = new System.Drawing.Point(598, 531);
            this.num_nivelRecompensa.Name = "num_nivelRecompensa";
            this.num_nivelRecompensa.Size = new System.Drawing.Size(125, 29);
            this.num_nivelRecompensa.TabIndex = 31;
            // 
            // text_Recompensa
            // 
            this.text_Recompensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Recompensa.Location = new System.Drawing.Point(597, 442);
            this.text_Recompensa.Name = "text_Recompensa";
            this.text_Recompensa.Size = new System.Drawing.Size(253, 29);
            this.text_Recompensa.TabIndex = 30;
            // 
            // label_NivelC
            // 
            this.label_NivelC.AutoSize = true;
            this.label_NivelC.BackColor = System.Drawing.Color.Transparent;
            this.label_NivelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NivelC.ForeColor = System.Drawing.Color.Azure;
            this.label_NivelC.Location = new System.Drawing.Point(312, 474);
            this.label_NivelC.Name = "label_NivelC";
            this.label_NivelC.Size = new System.Drawing.Size(199, 50);
            this.label_NivelC.TabIndex = 29;
            this.label_NivelC.Text = "NÍVEL DESSA \r\nCONSEQUÊNCIA:";
            // 
            // label_Consequencia
            // 
            this.label_Consequencia.AutoSize = true;
            this.label_Consequencia.BackColor = System.Drawing.Color.Transparent;
            this.label_Consequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Consequencia.ForeColor = System.Drawing.Color.Azure;
            this.label_Consequencia.Location = new System.Drawing.Point(314, 415);
            this.label_Consequencia.Name = "label_Consequencia";
            this.label_Consequencia.Size = new System.Drawing.Size(199, 25);
            this.label_Consequencia.TabIndex = 28;
            this.label_Consequencia.Text = "CONSEQUÊNCIA:";
            // 
            // num_nivelConsequencia
            // 
            this.num_nivelConsequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_nivelConsequencia.Location = new System.Drawing.Point(316, 531);
            this.num_nivelConsequencia.Name = "num_nivelConsequencia";
            this.num_nivelConsequencia.Size = new System.Drawing.Size(125, 29);
            this.num_nivelConsequencia.TabIndex = 27;
            // 
            // text_Consequencia
            // 
            this.text_Consequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Consequencia.Location = new System.Drawing.Point(317, 442);
            this.text_Consequencia.Name = "text_Consequencia";
            this.text_Consequencia.Size = new System.Drawing.Size(253, 29);
            this.text_Consequencia.TabIndex = 26;
            // 
            // btn_VerAgenda
            // 
            this.btn_VerAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerAgenda.ForeColor = System.Drawing.Color.Black;
            this.btn_VerAgenda.Location = new System.Drawing.Point(993, 8);
            this.btn_VerAgenda.Name = "btn_VerAgenda";
            this.btn_VerAgenda.Size = new System.Drawing.Size(130, 74);
            this.btn_VerAgenda.TabIndex = 34;
            this.btn_VerAgenda.Text = "Ver agenda";
            this.btn_VerAgenda.UseVisualStyleBackColor = true;
            this.btn_VerAgenda.Click += new System.EventHandler(this.btn_VerAgenda_Click);
            // 
            // checkedListBox_Segunda
            // 
            this.checkedListBox_Segunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Segunda.FormattingEnabled = true;
            this.checkedListBox_Segunda.Location = new System.Drawing.Point(9, 93);
            this.checkedListBox_Segunda.Name = "checkedListBox_Segunda";
            this.checkedListBox_Segunda.Size = new System.Drawing.Size(182, 316);
            this.checkedListBox_Segunda.TabIndex = 35;
            this.checkedListBox_Segunda.Visible = false;
            // 
            // checkedListBox_Terca
            // 
            this.checkedListBox_Terca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Terca.FormattingEnabled = true;
            this.checkedListBox_Terca.Location = new System.Drawing.Point(197, 93);
            this.checkedListBox_Terca.Name = "checkedListBox_Terca";
            this.checkedListBox_Terca.Size = new System.Drawing.Size(191, 316);
            this.checkedListBox_Terca.TabIndex = 36;
            this.checkedListBox_Terca.Visible = false;
            // 
            // checkedListBox_Quarta
            // 
            this.checkedListBox_Quarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Quarta.FormattingEnabled = true;
            this.checkedListBox_Quarta.Location = new System.Drawing.Point(394, 93);
            this.checkedListBox_Quarta.Name = "checkedListBox_Quarta";
            this.checkedListBox_Quarta.Size = new System.Drawing.Size(198, 316);
            this.checkedListBox_Quarta.TabIndex = 37;
            this.checkedListBox_Quarta.Visible = false;
            // 
            // checkedListBox_Quinta
            // 
            this.checkedListBox_Quinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Quinta.FormattingEnabled = true;
            this.checkedListBox_Quinta.Location = new System.Drawing.Point(598, 93);
            this.checkedListBox_Quinta.Name = "checkedListBox_Quinta";
            this.checkedListBox_Quinta.Size = new System.Drawing.Size(184, 316);
            this.checkedListBox_Quinta.TabIndex = 38;
            this.checkedListBox_Quinta.Visible = false;
            // 
            // checkedListBox_Sexta
            // 
            this.checkedListBox_Sexta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Sexta.FormattingEnabled = true;
            this.checkedListBox_Sexta.Location = new System.Drawing.Point(787, 93);
            this.checkedListBox_Sexta.Name = "checkedListBox_Sexta";
            this.checkedListBox_Sexta.Size = new System.Drawing.Size(186, 316);
            this.checkedListBox_Sexta.TabIndex = 39;
            this.checkedListBox_Sexta.Visible = false;
            // 
            // label_S
            // 
            this.label_S.AutoSize = true;
            this.label_S.BackColor = System.Drawing.Color.Transparent;
            this.label_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_S.ForeColor = System.Drawing.Color.Azure;
            this.label_S.Location = new System.Drawing.Point(39, 54);
            this.label_S.Name = "label_S";
            this.label_S.Size = new System.Drawing.Size(122, 25);
            this.label_S.TabIndex = 40;
            this.label_S.Text = "SEGUNDA";
            this.label_S.Visible = false;
            // 
            // label_T
            // 
            this.label_T.AutoSize = true;
            this.label_T.BackColor = System.Drawing.Color.Transparent;
            this.label_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T.ForeColor = System.Drawing.Color.Azure;
            this.label_T.Location = new System.Drawing.Point(249, 54);
            this.label_T.Name = "label_T";
            this.label_T.Size = new System.Drawing.Size(88, 25);
            this.label_T.TabIndex = 41;
            this.label_T.Text = "TERÇA";
            this.label_T.Visible = false;
            // 
            // label_Q
            // 
            this.label_Q.AutoSize = true;
            this.label_Q.BackColor = System.Drawing.Color.Transparent;
            this.label_Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Q.ForeColor = System.Drawing.Color.Azure;
            this.label_Q.Location = new System.Drawing.Point(446, 54);
            this.label_Q.Name = "label_Q";
            this.label_Q.Size = new System.Drawing.Size(105, 25);
            this.label_Q.TabIndex = 42;
            this.label_Q.Text = "QUARTA";
            this.label_Q.Visible = false;
            // 
            // label_Quinta
            // 
            this.label_Quinta.AutoSize = true;
            this.label_Quinta.BackColor = System.Drawing.Color.Transparent;
            this.label_Quinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Quinta.ForeColor = System.Drawing.Color.Azure;
            this.label_Quinta.Location = new System.Drawing.Point(639, 54);
            this.label_Quinta.Name = "label_Quinta";
            this.label_Quinta.Size = new System.Drawing.Size(96, 25);
            this.label_Quinta.TabIndex = 43;
            this.label_Quinta.Text = "QUINTA";
            this.label_Quinta.Visible = false;
            // 
            // label_Sexta
            // 
            this.label_Sexta.AutoSize = true;
            this.label_Sexta.BackColor = System.Drawing.Color.Transparent;
            this.label_Sexta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sexta.ForeColor = System.Drawing.Color.Azure;
            this.label_Sexta.Location = new System.Drawing.Point(830, 54);
            this.label_Sexta.Name = "label_Sexta";
            this.label_Sexta.Size = new System.Drawing.Size(86, 25);
            this.label_Sexta.TabIndex = 44;
            this.label_Sexta.Text = "SEXTA";
            this.label_Sexta.Visible = false;
            // 
            // btn_NovaTarefa
            // 
            this.btn_NovaTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovaTarefa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_NovaTarefa.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_NovaTarefa.Location = new System.Drawing.Point(993, 88);
            this.btn_NovaTarefa.Name = "btn_NovaTarefa";
            this.btn_NovaTarefa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_NovaTarefa.Size = new System.Drawing.Size(127, 82);
            this.btn_NovaTarefa.TabIndex = 45;
            this.btn_NovaTarefa.Text = "Criar Tarefa";
            this.btn_NovaTarefa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_NovaTarefa.UseVisualStyleBackColor = true;
            this.btn_NovaTarefa.Visible = false;
            this.btn_NovaTarefa.Click += new System.EventHandler(this.btn_NovaTarefa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "ALUNOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // load_tarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fundo_textuta_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_NovaTarefa);
            this.Controls.Add(this.label_Sexta);
            this.Controls.Add(this.label_Quinta);
            this.Controls.Add(this.label_Q);
            this.Controls.Add(this.label_T);
            this.Controls.Add(this.label_S);
            this.Controls.Add(this.checkedListBox_Sexta);
            this.Controls.Add(this.checkedListBox_Quinta);
            this.Controls.Add(this.checkedListBox_Quarta);
            this.Controls.Add(this.checkedListBox_Terca);
            this.Controls.Add(this.checkedListBox_Segunda);
            this.Controls.Add(this.btn_VerAgenda);
            this.Controls.Add(this.label_NivelR);
            this.Controls.Add(this.label_Recompensa);
            this.Controls.Add(this.num_nivelRecompensa);
            this.Controls.Add(this.text_Recompensa);
            this.Controls.Add(this.label_NivelC);
            this.Controls.Add(this.label_Consequencia);
            this.Controls.Add(this.num_nivelConsequencia);
            this.Controls.Add(this.text_Consequencia);
            this.Controls.Add(this.btn_Criarnovo);
            this.Controls.Add(this.cmbo_Dayweek);
            this.Controls.Add(this.label_Dayweek);
            this.Controls.Add(this.btn_ListTarefas);
            this.Controls.Add(this.label_Data);
            this.Controls.Add(this.mask_data);
            this.Controls.Add(this.label_NivelT);
            this.Controls.Add(this.label_Tarefa);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.num_nivelTarefa);
            this.Controls.Add(this.text_Tarefa);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.datagrid_ListTarefas);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "load_tarefa";
            this.RightToLeftLayout = true;
            this.Text = "Tarefa";
            this.Load += new System.EventHandler(this.load_tarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ListTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelRecompensa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivelConsequencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_ListTarefas;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox text_Tarefa;
        private System.Windows.Forms.NumericUpDown num_nivelTarefa;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Label label_Tarefa;
        private System.Windows.Forms.Label label_NivelT;
        private System.Windows.Forms.MaskedTextBox mask_data;
        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.Button btn_ListTarefas;
        private System.Windows.Forms.Label label_Dayweek;
        private System.Windows.Forms.ComboBox cmbo_Dayweek;
        private System.Windows.Forms.Button btn_Criarnovo;
        private System.Windows.Forms.Label label_NivelR;
        private System.Windows.Forms.Label label_Recompensa;
        private System.Windows.Forms.NumericUpDown num_nivelRecompensa;
        private System.Windows.Forms.TextBox text_Recompensa;
        private System.Windows.Forms.Label label_NivelC;
        private System.Windows.Forms.Label label_Consequencia;
        private System.Windows.Forms.NumericUpDown num_nivelConsequencia;
        private System.Windows.Forms.TextBox text_Consequencia;
        private System.Windows.Forms.Button btn_VerAgenda;
        private System.Windows.Forms.CheckedListBox checkedListBox_Segunda;
        private System.Windows.Forms.CheckedListBox checkedListBox_Terca;
        private System.Windows.Forms.CheckedListBox checkedListBox_Quarta;
        private System.Windows.Forms.CheckedListBox checkedListBox_Quinta;
        private System.Windows.Forms.CheckedListBox checkedListBox_Sexta;
        private System.Windows.Forms.Label label_S;
        private System.Windows.Forms.Label label_T;
        private System.Windows.Forms.Label label_Q;
        private System.Windows.Forms.Label label_Quinta;
        private System.Windows.Forms.Label label_Sexta;
        private System.Windows.Forms.Button btn_NovaTarefa;
        private System.Windows.Forms.Button button1;
    }
}

