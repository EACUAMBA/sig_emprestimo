namespace Gestão_de_Emprestimos
{
    partial class FormLoan
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
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbPercent = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.txtBoxCode = new System.Windows.Forms.TextBox();
            this.txtBoxClientCode = new System.Windows.Forms.TextBox();
            this.lbClientCode = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gbGeneratedInstallment = new System.Windows.Forms.GroupBox();
            this.dgvAction = new System.Windows.Forms.GroupBox();
            this.btnUpdateDataGrid = new System.Windows.Forms.Button();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.btnNewRow = new System.Windows.Forms.Button();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCleanForm = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbInformation = new System.Windows.Forms.Label();
            this.gbDataClient = new System.Windows.Forms.GroupBox();
            this.lbValueWithPercent = new System.Windows.Forms.Label();
            this.maskedTxtBoxResidualValue = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxCapital = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxPercent = new System.Windows.Forms.MaskedTextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFirstPayment = new System.Windows.Forms.DateTimePicker();
            this.lbFirstPayment = new System.Windows.Forms.Label();
            this.btnGenerateInstallment = new System.Windows.Forms.Button();
            this.comboBoxFrequency = new System.Windows.Forms.ComboBox();
            this.lbFrequency = new System.Windows.Forms.Label();
            this.lbResidualValue = new System.Windows.Forms.Label();
            this.checkBoxInstallment = new System.Windows.Forms.CheckBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbCapital = new System.Windows.Forms.Label();
            this.columnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLoanCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateToPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain.SuspendLayout();
            this.gbGeneratedInstallment.SuspendLayout();
            this.dgvAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.gbOperations.SuspendLayout();
            this.gbDataClient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndDate.Location = new System.Drawing.Point(21, 196);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(163, 20);
            this.lbEndDate.TabIndex = 26;
            this.lbEndDate.Text = "Data de Pagamento:";
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercent.Location = new System.Drawing.Point(21, 127);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(53, 20);
            this.lbPercent.TabIndex = 24;
            this.lbPercent.Text = "Juros:";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.Location = new System.Drawing.Point(21, 163);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(168, 20);
            this.lbStartDate.TabIndex = 22;
            this.lbStartDate.Text = "Data de Emprestimo: ";
            // 
            // txtBoxCode
            // 
            this.txtBoxCode.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCode.Location = new System.Drawing.Point(194, 26);
            this.txtBoxCode.Name = "txtBoxCode";
            this.txtBoxCode.Size = new System.Drawing.Size(326, 26);
            this.txtBoxCode.TabIndex = 1;
            // 
            // txtBoxClientCode
            // 
            this.txtBoxClientCode.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxClientCode.Location = new System.Drawing.Point(194, 60);
            this.txtBoxClientCode.Name = "txtBoxClientCode";
            this.txtBoxClientCode.Size = new System.Drawing.Size(326, 26);
            this.txtBoxClientCode.TabIndex = 9;
            // 
            // lbClientCode
            // 
            this.lbClientCode.AutoSize = true;
            this.lbClientCode.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientCode.Location = new System.Drawing.Point(21, 63);
            this.lbClientCode.Name = "lbClientCode";
            this.lbClientCode.Size = new System.Drawing.Size(147, 20);
            this.lbClientCode.TabIndex = 8;
            this.lbClientCode.Text = "Codigo do Cliente:";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(21, 28);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(67, 20);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "Codigo:";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.gbGeneratedInstallment);
            this.panelMain.Controls.Add(this.gbOperations);
            this.panelMain.Controls.Add(this.lbInformation);
            this.panelMain.Controls.Add(this.gbDataClient);
            this.panelMain.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1210, 637);
            this.panelMain.TabIndex = 1;
            // 
            // gbGeneratedInstallment
            // 
            this.gbGeneratedInstallment.Controls.Add(this.dgvAction);
            this.gbGeneratedInstallment.Controls.Add(this.dgvParcelas);
            this.gbGeneratedInstallment.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGeneratedInstallment.Location = new System.Drawing.Point(3, 281);
            this.gbGeneratedInstallment.Name = "gbGeneratedInstallment";
            this.gbGeneratedInstallment.Size = new System.Drawing.Size(1204, 353);
            this.gbGeneratedInstallment.TabIndex = 5;
            this.gbGeneratedInstallment.TabStop = false;
            this.gbGeneratedInstallment.Text = "Parcelas Geradas";
            // 
            // dgvAction
            // 
            this.dgvAction.Controls.Add(this.btnUpdateDataGrid);
            this.dgvAction.Controls.Add(this.btnRemoveRow);
            this.dgvAction.Controls.Add(this.btnNewRow);
            this.dgvAction.Enabled = false;
            this.dgvAction.Location = new System.Drawing.Point(1058, 15);
            this.dgvAction.Name = "dgvAction";
            this.dgvAction.Size = new System.Drawing.Size(140, 331);
            this.dgvAction.TabIndex = 5;
            this.dgvAction.TabStop = false;
            this.dgvAction.Text = "Ações";
            // 
            // btnUpdateDataGrid
            // 
            this.btnUpdateDataGrid.Enabled = false;
            this.btnUpdateDataGrid.Location = new System.Drawing.Point(6, 118);
            this.btnUpdateDataGrid.Name = "btnUpdateDataGrid";
            this.btnUpdateDataGrid.Size = new System.Drawing.Size(128, 40);
            this.btnUpdateDataGrid.TabIndex = 7;
            this.btnUpdateDataGrid.Text = "Update Table";
            this.btnUpdateDataGrid.UseVisualStyleBackColor = true;
            this.btnUpdateDataGrid.Click += new System.EventHandler(this.btnUpdateDataGrid_Click);
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Enabled = false;
            this.btnRemoveRow.Location = new System.Drawing.Point(6, 72);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(128, 40);
            this.btnRemoveRow.TabIndex = 6;
            this.btnRemoveRow.Text = "Remove Row";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // btnNewRow
            // 
            this.btnNewRow.Enabled = false;
            this.btnNewRow.Location = new System.Drawing.Point(6, 26);
            this.btnNewRow.Name = "btnNewRow";
            this.btnNewRow.Size = new System.Drawing.Size(128, 40);
            this.btnNewRow.TabIndex = 5;
            this.btnNewRow.Text = "Add Row";
            this.btnNewRow.UseVisualStyleBackColor = true;
            this.btnNewRow.Click += new System.EventHandler(this.btnNewRow_Click);
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCode,
            this.columnLoanCode,
            this.columnValue,
            this.columnDateToPay});
            this.dgvParcelas.Location = new System.Drawing.Point(6, 25);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvParcelas.Size = new System.Drawing.Size(1046, 322);
            this.dgvParcelas.TabIndex = 4;
            this.dgvParcelas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcelas_CellValueChanged);
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.btnBack);
            this.gbOperations.Controls.Add(this.btnCleanForm);
            this.gbOperations.Controls.Add(this.btnSave);
            this.gbOperations.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperations.Location = new System.Drawing.Point(887, 6);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(320, 231);
            this.gbOperations.TabIndex = 3;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operações";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(5, 184);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(309, 40);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Voltar ao Formulário anterior";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCleanForm
            // 
            this.btnCleanForm.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanForm.Location = new System.Drawing.Point(3, 110);
            this.btnCleanForm.Name = "btnCleanForm";
            this.btnCleanForm.Size = new System.Drawing.Size(308, 40);
            this.btnCleanForm.TabIndex = 4;
            this.btnCleanForm.Text = "Limpar Formulario";
            this.btnCleanForm.UseVisualStyleBackColor = true;
            this.btnCleanForm.Click += new System.EventHandler(this.btnCleanForm_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(5, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(303, 57);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbInformation
            // 
            this.lbInformation.BackColor = System.Drawing.Color.Black;
            this.lbInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInformation.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformation.ForeColor = System.Drawing.Color.White;
            this.lbInformation.Location = new System.Drawing.Point(197, 252);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(709, 22);
            this.lbInformation.TabIndex = 1;
            this.lbInformation.Text = "Status: No activity!";
            // 
            // gbDataClient
            // 
            this.gbDataClient.Controls.Add(this.lbValueWithPercent);
            this.gbDataClient.Controls.Add(this.maskedTxtBoxResidualValue);
            this.gbDataClient.Controls.Add(this.maskedTxtBoxCapital);
            this.gbDataClient.Controls.Add(this.maskedTxtBoxPercent);
            this.gbDataClient.Controls.Add(this.dtpStartDate);
            this.gbDataClient.Controls.Add(this.groupBox1);
            this.gbDataClient.Controls.Add(this.dtpEndDate);
            this.gbDataClient.Controls.Add(this.lbCapital);
            this.gbDataClient.Controls.Add(this.lbEndDate);
            this.gbDataClient.Controls.Add(this.lbPercent);
            this.gbDataClient.Controls.Add(this.lbStartDate);
            this.gbDataClient.Controls.Add(this.txtBoxClientCode);
            this.gbDataClient.Controls.Add(this.lbClientCode);
            this.gbDataClient.Controls.Add(this.txtBoxCode);
            this.gbDataClient.Controls.Add(this.lbCode);
            this.gbDataClient.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataClient.Location = new System.Drawing.Point(3, 6);
            this.gbDataClient.Name = "gbDataClient";
            this.gbDataClient.Size = new System.Drawing.Size(883, 231);
            this.gbDataClient.TabIndex = 0;
            this.gbDataClient.TabStop = false;
            this.gbDataClient.Text = "Dados do Cliente";
            // 
            // lbValueWithPercent
            // 
            this.lbValueWithPercent.AutoSize = true;
            this.lbValueWithPercent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueWithPercent.Location = new System.Drawing.Point(254, 127);
            this.lbValueWithPercent.Name = "lbValueWithPercent";
            this.lbValueWithPercent.Size = new System.Drawing.Size(99, 19);
            this.lbValueWithPercent.TabIndex = 39;
            this.lbValueWithPercent.Text = "Va. C/ J.:";
            // 
            // maskedTxtBoxResidualValue
            // 
            this.maskedTxtBoxResidualValue.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtBoxResidualValue.Location = new System.Drawing.Point(658, 68);
            this.maskedTxtBoxResidualValue.Mask = "000,000,000,000,00 MZN";
            this.maskedTxtBoxResidualValue.Name = "maskedTxtBoxResidualValue";
            this.maskedTxtBoxResidualValue.Size = new System.Drawing.Size(214, 26);
            this.maskedTxtBoxResidualValue.TabIndex = 38;
            // 
            // maskedTxtBoxCapital
            // 
            this.maskedTxtBoxCapital.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtBoxCapital.Location = new System.Drawing.Point(194, 91);
            this.maskedTxtBoxCapital.Mask = "000,000,000,000,00 MZN";
            this.maskedTxtBoxCapital.Name = "maskedTxtBoxCapital";
            this.maskedTxtBoxCapital.Size = new System.Drawing.Size(326, 26);
            this.maskedTxtBoxCapital.TabIndex = 37;
            // 
            // maskedTxtBoxPercent
            // 
            this.maskedTxtBoxPercent.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtBoxPercent.Location = new System.Drawing.Point(194, 124);
            this.maskedTxtBoxPercent.Mask = "00 %";
            this.maskedTxtBoxPercent.Name = "maskedTxtBoxPercent";
            this.maskedTxtBoxPercent.Size = new System.Drawing.Size(54, 26);
            this.maskedTxtBoxPercent.TabIndex = 6;
            this.maskedTxtBoxPercent.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtBoxPercent_MaskInputRejected);
            this.maskedTxtBoxPercent.TextChanged += new System.EventHandler(this.maskedTxtBoxPercent_TextChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = " dd/ MMMM / yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(194, 156);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(326, 26);
            this.dtpStartDate.TabIndex = 33;
            this.dtpStartDate.Value = new System.DateTime(2020, 9, 5, 19, 23, 3, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFirstPayment);
            this.groupBox1.Controls.Add(this.lbFirstPayment);
            this.groupBox1.Controls.Add(this.btnGenerateInstallment);
            this.groupBox1.Controls.Add(this.comboBoxFrequency);
            this.groupBox1.Controls.Add(this.lbFrequency);
            this.groupBox1.Controls.Add(this.lbResidualValue);
            this.groupBox1.Controls.Add(this.checkBoxInstallment);
            this.groupBox1.Location = new System.Drawing.Point(526, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 210);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parcelar";
            // 
            // dtpFirstPayment
            // 
            this.dtpFirstPayment.CustomFormat = "dd/MMMMM/yyyy";
            this.dtpFirstPayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFirstPayment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFirstPayment.Location = new System.Drawing.Point(132, 128);
            this.dtpFirstPayment.Name = "dtpFirstPayment";
            this.dtpFirstPayment.Size = new System.Drawing.Size(214, 26);
            this.dtpFirstPayment.TabIndex = 42;
            // 
            // lbFirstPayment
            // 
            this.lbFirstPayment.AutoSize = true;
            this.lbFirstPayment.Location = new System.Drawing.Point(6, 122);
            this.lbFirstPayment.Name = "lbFirstPayment";
            this.lbFirstPayment.Size = new System.Drawing.Size(99, 40);
            this.lbFirstPayment.TabIndex = 41;
            this.lbFirstPayment.Text = "Primeiro\r\nPagamento:";
            // 
            // btnGenerateInstallment
            // 
            this.btnGenerateInstallment.Location = new System.Drawing.Point(72, 169);
            this.btnGenerateInstallment.Name = "btnGenerateInstallment";
            this.btnGenerateInstallment.Size = new System.Drawing.Size(184, 30);
            this.btnGenerateInstallment.TabIndex = 40;
            this.btnGenerateInstallment.Text = "Gerar Parcelas";
            this.btnGenerateInstallment.UseVisualStyleBackColor = true;
            this.btnGenerateInstallment.Click += new System.EventHandler(this.btnGenerateInstallment_Click);
            // 
            // comboBoxFrequency
            // 
            this.comboBoxFrequency.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFrequency.FormattingEnabled = true;
            this.comboBoxFrequency.Location = new System.Drawing.Point(132, 88);
            this.comboBoxFrequency.Name = "comboBoxFrequency";
            this.comboBoxFrequency.Size = new System.Drawing.Size(214, 26);
            this.comboBoxFrequency.TabIndex = 39;
            this.comboBoxFrequency.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrequency_SelectedIndexChanged);
            // 
            // lbFrequency
            // 
            this.lbFrequency.AutoSize = true;
            this.lbFrequency.Location = new System.Drawing.Point(6, 91);
            this.lbFrequency.Name = "lbFrequency";
            this.lbFrequency.Size = new System.Drawing.Size(99, 20);
            this.lbFrequency.TabIndex = 38;
            this.lbFrequency.Text = "Frequência: ";
            // 
            // lbResidualValue
            // 
            this.lbResidualValue.AutoSize = true;
            this.lbResidualValue.Location = new System.Drawing.Point(6, 53);
            this.lbResidualValue.Name = "lbResidualValue";
            this.lbResidualValue.Size = new System.Drawing.Size(120, 20);
            this.lbResidualValue.TabIndex = 36;
            this.lbResidualValue.Text = "Valor Rasidual:";
            // 
            // checkBoxInstallment
            // 
            this.checkBoxInstallment.AutoSize = true;
            this.checkBoxInstallment.Location = new System.Drawing.Point(132, 20);
            this.checkBoxInstallment.Name = "checkBoxInstallment";
            this.checkBoxInstallment.Size = new System.Drawing.Size(99, 24);
            this.checkBoxInstallment.TabIndex = 35;
            this.checkBoxInstallment.Text = "Parcelar?";
            this.checkBoxInstallment.UseVisualStyleBackColor = true;
            this.checkBoxInstallment.CheckedChanged += new System.EventHandler(this.checkBoxInstallment_CheckedChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MMMM/yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(194, 189);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(326, 26);
            this.dtpEndDate.TabIndex = 33;
            this.dtpEndDate.Value = new System.DateTime(2020, 9, 5, 0, 0, 0, 0);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lbCapital
            // 
            this.lbCapital.AutoSize = true;
            this.lbCapital.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapital.Location = new System.Drawing.Point(21, 95);
            this.lbCapital.Name = "lbCapital";
            this.lbCapital.Size = new System.Drawing.Size(69, 20);
            this.lbCapital.TabIndex = 31;
            this.lbCapital.Text = "Capital:";
            // 
            // columnCode
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnCode.DefaultCellStyle = dataGridViewCellStyle1;
            this.columnCode.HeaderText = "Codigo";
            this.columnCode.Name = "columnCode";
            // 
            // columnLoanCode
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnLoanCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnLoanCode.HeaderText = "Codigo do Emprestimo";
            this.columnLoanCode.Name = "columnLoanCode";
            this.columnLoanCode.Width = 200;
            // 
            // columnValue
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.columnValue.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnValue.HeaderText = "Valor a Pagar";
            this.columnValue.Name = "columnValue";
            this.columnValue.Width = 300;
            // 
            // columnDateToPay
            // 
            this.columnDateToPay.HeaderText = "Data Para Pagar";
            this.columnDateToPay.Name = "columnDateToPay";
            this.columnDateToPay.Width = 400;
            // 
            // FormLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.panelMain);
            this.Name = "FormLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoan";
            this.Load += new System.EventHandler(this.FormLoan_Load);
            this.panelMain.ResumeLayout(false);
            this.gbGeneratedInstallment.ResumeLayout(false);
            this.dgvAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.gbOperations.ResumeLayout(false);
            this.gbDataClient.ResumeLayout(false);
            this.gbDataClient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.TextBox txtBoxCode;
        private System.Windows.Forms.TextBox txtBoxClientCode;
        private System.Windows.Forms.Label lbClientCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox gbDataClient;
        private System.Windows.Forms.Label lbCapital;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbResidualValue;
        private System.Windows.Forms.CheckBox checkBoxInstallment;
        private System.Windows.Forms.GroupBox gbGeneratedInstallment;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCleanForm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.ComboBox comboBoxFrequency;
        private System.Windows.Forms.Label lbFrequency;
        private System.Windows.Forms.Button btnGenerateInstallment;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpFirstPayment;
        private System.Windows.Forms.Label lbFirstPayment;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxPercent;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxResidualValue;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxCapital;
        private System.Windows.Forms.Label lbValueWithPercent;
        private System.Windows.Forms.GroupBox dgvAction;
        private System.Windows.Forms.Button btnUpdateDataGrid;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.Button btnNewRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLoanCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateToPay;
    }
}