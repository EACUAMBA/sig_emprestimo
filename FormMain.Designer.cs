namespace Gestão_de_Emprestimos
{
    partial class FormMain
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
            "Edilson Alexandre Cuamba",
            "250.000.00MZN",
            "10%",
            "30.000.00MZN",
            "25/Janeiro/2020",
            "25/Setembro/2020",
            "-5"}, -1, System.Drawing.Color.Black, System.Drawing.Color.Yellow, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvMainLoan = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCapital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInterest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResidualValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateTimeStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDaysLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelMainOperations = new System.Windows.Forms.Panel();
            this.gbInstallment = new System.Windows.Forms.GroupBox();
            this.btnSystemConfig = new System.Windows.Forms.Button();
            this.gbLoan = new System.Windows.Forms.GroupBox();
            this.btnFormLoan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnFormClient = new System.Windows.Forms.Button();
            this.lbClientDetails = new System.Windows.Forms.Label();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMainOperations.SuspendLayout();
            this.gbInstallment.SuspendLayout();
            this.gbLoan.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Gilroy ExtraBold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(421, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(392, 42);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Gestão de Emprestimos";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.btnUpdateList);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelMainOperations);
            this.panelMain.Controls.Add(this.lbTitle);
            this.panelMain.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1210, 537);
            this.panelMain.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvMainLoan);
            this.panel1.Location = new System.Drawing.Point(3, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 186);
            this.panel1.TabIndex = 4;
            // 
            // lvMainLoan
            // 
            this.lvMainLoan.CheckBoxes = true;
            this.lvMainLoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chCapital,
            this.chInterest,
            this.chResidualValue,
            this.chDateTimeStart,
            this.chDateEnd,
            this.chDaysLeft});
            this.lvMainLoan.FullRowSelect = true;
            this.lvMainLoan.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            this.lvMainLoan.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvMainLoan.Location = new System.Drawing.Point(0, 3);
            this.lvMainLoan.Name = "lvMainLoan";
            this.lvMainLoan.Size = new System.Drawing.Size(1201, 187);
            this.lvMainLoan.TabIndex = 0;
            this.lvMainLoan.UseCompatibleStateImageBehavior = false;
            this.lvMainLoan.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Nome do Cliente";
            this.chName.Width = 252;
            // 
            // chCapital
            // 
            this.chCapital.Text = "Capital";
            this.chCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chCapital.Width = 150;
            // 
            // chInterest
            // 
            this.chInterest.Text = "Juros";
            this.chInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chInterest.Width = 84;
            // 
            // chResidualValue
            // 
            this.chResidualValue.Text = "Valor Residual Aproximado";
            this.chResidualValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chResidualValue.Width = 225;
            // 
            // chDateTimeStart
            // 
            this.chDateTimeStart.Text = "Data Feito";
            this.chDateTimeStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chDateTimeStart.Width = 172;
            // 
            // chDateEnd
            // 
            this.chDateEnd.Text = "Data Termíno";
            this.chDateEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chDateEnd.Width = 175;
            // 
            // chDaysLeft
            // 
            this.chDaysLeft.Text = "Dias Restantes";
            this.chDaysLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chDaysLeft.Width = 125;
            // 
            // panelMainOperations
            // 
            this.panelMainOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainOperations.Controls.Add(this.gbInstallment);
            this.panelMainOperations.Controls.Add(this.gbLoan);
            this.panelMainOperations.Controls.Add(this.gbCliente);
            this.panelMainOperations.Location = new System.Drawing.Point(67, 62);
            this.panelMainOperations.Name = "panelMainOperations";
            this.panelMainOperations.Size = new System.Drawing.Size(1100, 280);
            this.panelMainOperations.TabIndex = 3;
            // 
            // gbInstallment
            // 
            this.gbInstallment.Controls.Add(this.btnSystemConfig);
            this.gbInstallment.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbInstallment.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInstallment.Location = new System.Drawing.Point(741, 15);
            this.gbInstallment.Name = "gbInstallment";
            this.gbInstallment.Size = new System.Drawing.Size(350, 258);
            this.gbInstallment.TabIndex = 4;
            this.gbInstallment.TabStop = false;
            this.gbInstallment.Text = "Sistema";
            // 
            // btnSystemConfig
            // 
            this.btnSystemConfig.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemConfig.Location = new System.Drawing.Point(125, 219);
            this.btnSystemConfig.Name = "btnSystemConfig";
            this.btnSystemConfig.Size = new System.Drawing.Size(219, 33);
            this.btnSystemConfig.TabIndex = 4;
            this.btnSystemConfig.Text = "Configuração do Sistema";
            this.btnSystemConfig.UseVisualStyleBackColor = true;
            this.btnSystemConfig.Click += new System.EventHandler(this.btnListInstallment_Click);
            // 
            // gbLoan
            // 
            this.gbLoan.Controls.Add(this.btnFormLoan);
            this.gbLoan.Controls.Add(this.label1);
            this.gbLoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbLoan.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoan.Location = new System.Drawing.Point(376, 15);
            this.gbLoan.Name = "gbLoan";
            this.gbLoan.Size = new System.Drawing.Size(350, 258);
            this.gbLoan.TabIndex = 3;
            this.gbLoan.TabStop = false;
            this.gbLoan.Text = "Gestão de Emprestimos";
            // 
            // btnFormLoan
            // 
            this.btnFormLoan.Font = new System.Drawing.Font("Gilroy ExtraBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormLoan.Location = new System.Drawing.Point(125, 219);
            this.btnFormLoan.Name = "btnFormLoan";
            this.btnFormLoan.Size = new System.Drawing.Size(219, 33);
            this.btnFormLoan.TabIndex = 2;
            this.btnFormLoan.Text = "Gerir Emprestimos";
            this.btnFormLoan.UseVisualStyleBackColor = true;
            this.btnFormLoan.Click += new System.EventHandler(this.btnFormLoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 204);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnFormClient);
            this.gbCliente.Controls.Add(this.lbClientDetails);
            this.gbCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbCliente.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(9, 15);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(350, 258);
            this.gbCliente.TabIndex = 2;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Gestão de Clientes";
            // 
            // btnFormClient
            // 
            this.btnFormClient.Font = new System.Drawing.Font("Gilroy ExtraBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormClient.Location = new System.Drawing.Point(125, 219);
            this.btnFormClient.Name = "btnFormClient";
            this.btnFormClient.Size = new System.Drawing.Size(219, 33);
            this.btnFormClient.TabIndex = 0;
            this.btnFormClient.Text = "Gerir Clientes";
            this.btnFormClient.UseVisualStyleBackColor = true;
            this.btnFormClient.Click += new System.EventHandler(this.btnFormClient_Click);
            // 
            // lbClientDetails
            // 
            this.lbClientDetails.AutoSize = true;
            this.lbClientDetails.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientDetails.Location = new System.Drawing.Point(6, 23);
            this.lbClientDetails.Name = "lbClientDetails";
            this.lbClientDetails.Size = new System.Drawing.Size(271, 204);
            this.lbClientDetails.TabIndex = 1;
            this.lbClientDetails.Text = resources.GetString("lbClientDetails.Text");
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Location = new System.Drawing.Point(6, 9);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(181, 23);
            this.btnUpdateList.TabIndex = 5;
            this.btnUpdateList.Text = "Actualizar Lista";
            this.btnUpdateList.UseVisualStyleBackColor = true;
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Emprestimos";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelMainOperations.ResumeLayout(false);
            this.gbInstallment.ResumeLayout(false);
            this.gbLoan.ResumeLayout(false);
            this.gbLoan.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMainOperations;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.GroupBox gbInstallment;
        private System.Windows.Forms.GroupBox gbLoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvMainLoan;
        private System.Windows.Forms.Button btnSystemConfig;
        private System.Windows.Forms.Button btnFormLoan;
        private System.Windows.Forms.Button btnFormClient;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chCapital;
        private System.Windows.Forms.ColumnHeader chInterest;
        private System.Windows.Forms.ColumnHeader chResidualValue;
        private System.Windows.Forms.ColumnHeader chDateTimeStart;
        private System.Windows.Forms.ColumnHeader chDateEnd;
        private System.Windows.Forms.ColumnHeader chDaysLeft;
        private System.Windows.Forms.Label lbClientDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateList;
    }
}

