using Gestão_de_Emprestimos.DAO;

namespace Gestão_de_Emprestimos
{
    partial class FormClient
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "CL1",
            "Cliente Teste",
            "Masculino",
            "27/outubro/1999",
            "842473772, 822565148",
            "EdilsonCuamba@gmail.com",
            "Maputo, Marracuene, Bairro Cumbeza, Casa 205, Q18",
            "123456789123B",
            "123456789"}, -1, System.Drawing.Color.Gray, System.Drawing.Color.Empty, new System.Drawing.Font("Gilroy Light", 10F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.panelMain = new System.Windows.Forms.Panel();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.btnSeeLoan = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnToEdit = new System.Windows.Forms.Button();
            this.btnToLoan = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCleanForm = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lvClients = new System.Windows.Forms.ListView();
            this.chCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBornDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContacts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumberBI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNUIT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbInformation = new System.Windows.Forms.Label();
            this.gbDataClient = new System.Windows.Forms.GroupBox();
            this.dtpBornDate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbBornDate = new System.Windows.Forms.Label();
            this.txtBoxNUIT = new System.Windows.Forms.TextBox();
            this.lbNumNUIT = new System.Windows.Forms.Label();
            this.txtBoxNumberBi = new System.Windows.Forms.TextBox();
            this.lbNumberBi = new System.Windows.Forms.Label();
            this.rTxtBoxAdress = new System.Windows.Forms.RichTextBox();
            this.lbAdress = new System.Windows.Forms.Label();
            this.gbContacts = new System.Windows.Forms.GroupBox();
            this.lbContact_2 = new System.Windows.Forms.Label();
            this.txtBoxContact_2 = new System.Windows.Forms.TextBox();
            this.txtBoxContact_1 = new System.Windows.Forms.TextBox();
            this.lbContact_1 = new System.Windows.Forms.Label();
            this.gbGenre = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtBoxCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.gbOperations.SuspendLayout();
            this.gbDataClient.SuspendLayout();
            this.gbContacts.SuspendLayout();
            this.gbGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.gbOperations);
            this.panelMain.Controls.Add(this.lvClients);
            this.panelMain.Controls.Add(this.lbInformation);
            this.panelMain.Controls.Add(this.gbDataClient);
            this.panelMain.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1210, 637);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.btnSeeLoan);
            this.gbOperations.Controls.Add(this.btnUpdate);
            this.gbOperations.Controls.Add(this.btnToEdit);
            this.gbOperations.Controls.Add(this.btnToLoan);
            this.gbOperations.Controls.Add(this.btnBack);
            this.gbOperations.Controls.Add(this.btnCleanForm);
            this.gbOperations.Controls.Add(this.btnSave);
            this.gbOperations.Controls.Add(this.btnDelete);
            this.gbOperations.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperations.Location = new System.Drawing.Point(887, 6);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(320, 300);
            this.gbOperations.TabIndex = 3;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operações";
            // 
            // btnSeeLoan
            // 
            this.btnSeeLoan.Font = new System.Drawing.Font("Gilroy ExtraBold", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeLoan.Location = new System.Drawing.Point(166, 162);
            this.btnSeeLoan.Name = "btnSeeLoan";
            this.btnSeeLoan.Size = new System.Drawing.Size(148, 40);
            this.btnSeeLoan.TabIndex = 10;
            this.btnSeeLoan.Text = "Ver Emprestimos";
            this.btnSeeLoan.UseVisualStyleBackColor = true;
            this.btnSeeLoan.Click += new System.EventHandler(this.btnSeeLoan_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(161, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnToEdit
            // 
            this.btnToEdit.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToEdit.Location = new System.Drawing.Point(7, 117);
            this.btnToEdit.Name = "btnToEdit";
            this.btnToEdit.Size = new System.Drawing.Size(308, 40);
            this.btnToEdit.TabIndex = 8;
            this.btnToEdit.Text = "Editar Dados";
            this.btnToEdit.UseVisualStyleBackColor = true;
            this.btnToEdit.Click += new System.EventHandler(this.btnToEdit_Click);
            // 
            // btnToLoan
            // 
            this.btnToLoan.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToLoan.Location = new System.Drawing.Point(7, 163);
            this.btnToLoan.Name = "btnToLoan";
            this.btnToLoan.Size = new System.Drawing.Size(148, 40);
            this.btnToLoan.TabIndex = 7;
            this.btnToLoan.Text = "Emprestar";
            this.btnToLoan.UseVisualStyleBackColor = true;
            this.btnToLoan.Click += new System.EventHandler(this.btnToLoan_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(6, 254);
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
            this.btnCleanForm.Location = new System.Drawing.Point(7, 208);
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
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(6, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(308, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Apagar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lvClients
            // 
            this.lvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCode,
            this.chName,
            this.chGenre,
            this.chBornDate,
            this.chContacts,
            this.chEmail,
            this.chAdress,
            this.chNumberBI,
            this.chNUIT});
            this.lvClients.Font = new System.Drawing.Font("Gilroy Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClients.FullRowSelect = true;
            this.lvClients.GridLines = true;
            this.lvClients.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvClients.Location = new System.Drawing.Point(3, 341);
            this.lvClients.Name = "lvClients";
            this.lvClients.Size = new System.Drawing.Size(1204, 241);
            this.lvClients.TabIndex = 2;
            this.lvClients.UseCompatibleStateImageBehavior = false;
            this.lvClients.View = System.Windows.Forms.View.Details;
            // 
            // chCode
            // 
            this.chCode.Text = "Codigo";
            this.chCode.Width = 75;
            // 
            // chName
            // 
            this.chName.Text = "Nome";
            this.chName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chName.Width = 225;
            // 
            // chGenre
            // 
            this.chGenre.Text = "Sexo";
            this.chGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chGenre.Width = 100;
            // 
            // chBornDate
            // 
            this.chBornDate.Text = "Data de Nascimento";
            this.chBornDate.Width = 144;
            // 
            // chContacts
            // 
            this.chContacts.Text = "Contactos";
            this.chContacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chContacts.Width = 131;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 124;
            // 
            // chAdress
            // 
            this.chAdress.Text = "Endereço";
            this.chAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAdress.Width = 150;
            // 
            // chNumberBI
            // 
            this.chNumberBI.Text = "Numero de BI";
            this.chNumberBI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNumberBI.Width = 130;
            // 
            // chNUIT
            // 
            this.chNUIT.Text = "NUIT";
            this.chNUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNUIT.Width = 99;
            // 
            // lbInformation
            // 
            this.lbInformation.BackColor = System.Drawing.Color.Black;
            this.lbInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInformation.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformation.ForeColor = System.Drawing.Color.White;
            this.lbInformation.Location = new System.Drawing.Point(263, 312);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(709, 22);
            this.lbInformation.TabIndex = 1;
            this.lbInformation.Text = "Status: No activity!";
            // 
            // gbDataClient
            // 
            this.gbDataClient.Controls.Add(this.dtpBornDate);
            this.gbDataClient.Controls.Add(this.txtBoxEmail);
            this.gbDataClient.Controls.Add(this.lbEmail);
            this.gbDataClient.Controls.Add(this.lbBornDate);
            this.gbDataClient.Controls.Add(this.txtBoxNUIT);
            this.gbDataClient.Controls.Add(this.lbNumNUIT);
            this.gbDataClient.Controls.Add(this.txtBoxNumberBi);
            this.gbDataClient.Controls.Add(this.lbNumberBi);
            this.gbDataClient.Controls.Add(this.rTxtBoxAdress);
            this.gbDataClient.Controls.Add(this.lbAdress);
            this.gbDataClient.Controls.Add(this.gbContacts);
            this.gbDataClient.Controls.Add(this.gbGenre);
            this.gbDataClient.Controls.Add(this.lbGenre);
            this.gbDataClient.Controls.Add(this.lbContact);
            this.gbDataClient.Controls.Add(this.txtBoxName);
            this.gbDataClient.Controls.Add(this.lbName);
            this.gbDataClient.Controls.Add(this.txtBoxCode);
            this.gbDataClient.Controls.Add(this.lbCode);
            this.gbDataClient.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataClient.Location = new System.Drawing.Point(3, 6);
            this.gbDataClient.Name = "gbDataClient";
            this.gbDataClient.Size = new System.Drawing.Size(850, 300);
            this.gbDataClient.TabIndex = 0;
            this.gbDataClient.TabStop = false;
            this.gbDataClient.Text = "Dados do Cliente";
            // 
            // dtpBornDate
            // 
            this.dtpBornDate.CustomFormat = "dd/MMMM/yyyy";
            this.dtpBornDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBornDate.Location = new System.Drawing.Point(533, 110);
            this.dtpBornDate.Name = "dtpBornDate";
            this.dtpBornDate.Size = new System.Drawing.Size(301, 27);
            this.dtpBornDate.TabIndex = 30;
            this.dtpBornDate.Value = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(531, 217);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(303, 26);
            this.txtBoxEmail.TabIndex = 29;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(440, 221);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 18);
            this.lbEmail.TabIndex = 28;
            this.lbEmail.Text = "Email:";
            // 
            // lbBornDate
            // 
            this.lbBornDate.AutoSize = true;
            this.lbBornDate.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBornDate.Location = new System.Drawing.Point(440, 114);
            this.lbBornDate.Name = "lbBornDate";
            this.lbBornDate.Size = new System.Drawing.Size(86, 18);
            this.lbBornDate.TabIndex = 26;
            this.lbBornDate.Text = "Born Date:";
            // 
            // txtBoxNUIT
            // 
            this.txtBoxNUIT.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNUIT.Location = new System.Drawing.Point(531, 176);
            this.txtBoxNUIT.Name = "txtBoxNUIT";
            this.txtBoxNUIT.Size = new System.Drawing.Size(303, 26);
            this.txtBoxNUIT.TabIndex = 25;
            // 
            // lbNumNUIT
            // 
            this.lbNumNUIT.AutoSize = true;
            this.lbNumNUIT.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumNUIT.Location = new System.Drawing.Point(440, 180);
            this.lbNumNUIT.Name = "lbNumNUIT";
            this.lbNumNUIT.Size = new System.Drawing.Size(43, 18);
            this.lbNumNUIT.TabIndex = 24;
            this.lbNumNUIT.Text = "NUIT";
            // 
            // txtBoxNumberBi
            // 
            this.txtBoxNumberBi.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumberBi.Location = new System.Drawing.Point(531, 143);
            this.txtBoxNumberBi.Name = "txtBoxNumberBi";
            this.txtBoxNumberBi.Size = new System.Drawing.Size(303, 26);
            this.txtBoxNumberBi.TabIndex = 23;
            // 
            // lbNumberBi
            // 
            this.lbNumberBi.AutoSize = true;
            this.lbNumberBi.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberBi.Location = new System.Drawing.Point(440, 147);
            this.lbNumberBi.Name = "lbNumberBi";
            this.lbNumberBi.Size = new System.Drawing.Size(69, 18);
            this.lbNumberBi.TabIndex = 22;
            this.lbNumberBi.Text = "Num. B.I.";
            // 
            // rTxtBoxAdress
            // 
            this.rTxtBoxAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtBoxAdress.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBoxAdress.Location = new System.Drawing.Point(531, 26);
            this.rTxtBoxAdress.Name = "rTxtBoxAdress";
            this.rTxtBoxAdress.Size = new System.Drawing.Size(303, 78);
            this.rTxtBoxAdress.TabIndex = 21;
            this.rTxtBoxAdress.Text = "";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.Location = new System.Drawing.Point(440, 52);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(85, 18);
            this.lbAdress.TabIndex = 19;
            this.lbAdress.Text = "Endereço: ";
            // 
            // gbContacts
            // 
            this.gbContacts.Controls.Add(this.lbContact_2);
            this.gbContacts.Controls.Add(this.txtBoxContact_2);
            this.gbContacts.Controls.Add(this.txtBoxContact_1);
            this.gbContacts.Controls.Add(this.lbContact_1);
            this.gbContacts.Location = new System.Drawing.Point(112, 160);
            this.gbContacts.Name = "gbContacts";
            this.gbContacts.Size = new System.Drawing.Size(303, 99);
            this.gbContacts.TabIndex = 18;
            this.gbContacts.TabStop = false;
            this.gbContacts.Text = "Contactos";
            // 
            // lbContact_2
            // 
            this.lbContact_2.AutoSize = true;
            this.lbContact_2.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact_2.Location = new System.Drawing.Point(15, 60);
            this.lbContact_2.Name = "lbContact_2";
            this.lbContact_2.Size = new System.Drawing.Size(33, 18);
            this.lbContact_2.TabIndex = 17;
            this.lbContact_2.Text = "2 - ";
            // 
            // txtBoxContact_2
            // 
            this.txtBoxContact_2.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContact_2.Location = new System.Drawing.Point(52, 60);
            this.txtBoxContact_2.Name = "txtBoxContact_2";
            this.txtBoxContact_2.Size = new System.Drawing.Size(245, 26);
            this.txtBoxContact_2.TabIndex = 16;
            // 
            // txtBoxContact_1
            // 
            this.txtBoxContact_1.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContact_1.Location = new System.Drawing.Point(52, 26);
            this.txtBoxContact_1.Name = "txtBoxContact_1";
            this.txtBoxContact_1.Size = new System.Drawing.Size(245, 26);
            this.txtBoxContact_1.TabIndex = 15;
            // 
            // lbContact_1
            // 
            this.lbContact_1.AutoSize = true;
            this.lbContact_1.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact_1.Location = new System.Drawing.Point(15, 29);
            this.lbContact_1.Name = "lbContact_1";
            this.lbContact_1.Size = new System.Drawing.Size(30, 18);
            this.lbContact_1.TabIndex = 10;
            this.lbContact_1.Text = "1 - ";
            // 
            // gbGenre
            // 
            this.gbGenre.Controls.Add(this.rbFemale);
            this.gbGenre.Controls.Add(this.rbMale);
            this.gbGenre.Location = new System.Drawing.Point(112, 91);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(303, 63);
            this.gbGenre.TabIndex = 17;
            this.gbGenre.TabStop = false;
            this.gbGenre.Text = "Sexo";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(173, 26);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(91, 22);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Feminino";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(15, 26);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(99, 22);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Masculino";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(21, 115);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(47, 18);
            this.lbGenre.TabIndex = 16;
            this.lbGenre.Text = "Sexo:";
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.Location = new System.Drawing.Point(21, 202);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(83, 18);
            this.lbContact.TabIndex = 14;
            this.lbContact.Text = "Contacto:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(112, 59);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(303, 26);
            this.txtBoxName.TabIndex = 9;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(21, 63);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 18);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "Nome: ";
            // 
            // txtBoxCode
            // 
            this.txtBoxCode.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCode.Location = new System.Drawing.Point(112, 26);
            this.txtBoxCode.Name = "txtBoxCode";
            this.txtBoxCode.Size = new System.Drawing.Size(303, 26);
            this.txtBoxCode.TabIndex = 1;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(21, 28);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(66, 18);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "Codigo:";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.panelMain);
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Cliente";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.panelMain.ResumeLayout(false);
            this.gbOperations.ResumeLayout(false);
            this.gbDataClient.ResumeLayout(false);
            this.gbDataClient.PerformLayout();
            this.gbContacts.ResumeLayout(false);
            this.gbContacts.PerformLayout();
            this.gbGenre.ResumeLayout(false);
            this.gbGenre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox gbDataClient;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtBoxCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.RichTextBox rTxtBoxAdress;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.GroupBox gbContacts;
        private System.Windows.Forms.Label lbContact_2;
        private System.Windows.Forms.TextBox txtBoxContact_2;
        private System.Windows.Forms.TextBox txtBoxContact_1;
        private System.Windows.Forms.Label lbContact_1;
        private System.Windows.Forms.GroupBox gbGenre;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.TextBox txtBoxNumberBi;
        private System.Windows.Forms.Label lbNumberBi;
        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.ColumnHeader chCode;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chGenre;
        private System.Windows.Forms.ColumnHeader chContacts;
        private System.Windows.Forms.ColumnHeader chAdress;
        private System.Windows.Forms.ColumnHeader chNumberBI;
        private System.Windows.Forms.ColumnHeader chNUIT;
        private System.Windows.Forms.TextBox txtBoxNUIT;
        private System.Windows.Forms.Label lbNumNUIT;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCleanForm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbBornDate;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.Button btnToLoan;
        private System.Windows.Forms.Button btnToEdit;
        private System.Windows.Forms.DateTimePicker dtpBornDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chBornDate;
        private System.Windows.Forms.Button btnSeeLoan;
    }
}