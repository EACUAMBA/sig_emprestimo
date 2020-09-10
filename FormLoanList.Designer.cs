namespace Gestão_de_Emprestimos
{
    partial class FormLoanList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbInstallments = new System.Windows.Forms.GroupBox();
            this.lbInstallmenttitle = new System.Windows.Forms.Label();
            this.lviInstallments = new System.Windows.Forms.ListView();
            this.chInstallmentCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLoanCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateToPay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvLoans = new System.Windows.Forms.ListView();
            this.chCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClientCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCapital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResidualValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPaidLoan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.lbSetInformation = new System.Windows.Forms.Label();
            this.btnDefineLoanAsPaid = new System.Windows.Forms.Button();
            this.lbInstallment = new System.Windows.Forms.Label();
            this.lbClientName = new System.Windows.Forms.Label();
            this.lbInformation = new System.Windows.Forms.Label();
            this.btnDefineInstallmentAsPaid = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbInstallments.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbInstallments);
            this.panel1.Controls.Add(this.lvLoans);
            this.panel1.Controls.Add(this.gbActions);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 637);
            this.panel1.TabIndex = 0;
            // 
            // gbInstallments
            // 
            this.gbInstallments.Controls.Add(this.btnDefineInstallmentAsPaid);
            this.gbInstallments.Controls.Add(this.lbInstallmenttitle);
            this.gbInstallments.Controls.Add(this.lviInstallments);
            this.gbInstallments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInstallments.Location = new System.Drawing.Point(3, 308);
            this.gbInstallments.Name = "gbInstallments";
            this.gbInstallments.Size = new System.Drawing.Size(1204, 326);
            this.gbInstallments.TabIndex = 2;
            this.gbInstallments.TabStop = false;
            this.gbInstallments.Text = "Parcelas";
            // 
            // lbInstallmenttitle
            // 
            this.lbInstallmenttitle.AutoSize = true;
            this.lbInstallmenttitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstallmenttitle.Location = new System.Drawing.Point(556, 17);
            this.lbInstallmenttitle.Name = "lbInstallmenttitle";
            this.lbInstallmenttitle.Size = new System.Drawing.Size(127, 32);
            this.lbInstallmenttitle.TabIndex = 1;
            this.lbInstallmenttitle.Text = "Parcelas";
            // 
            // lviInstallments
            // 
            this.lviInstallments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chInstallmentCode,
            this.chLoanCode,
            this.chValue,
            this.chDateToPay,
            this.chPaid});
            this.lviInstallments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviInstallments.FullRowSelect = true;
            this.lviInstallments.GridLines = true;
            this.lviInstallments.Location = new System.Drawing.Point(6, 53);
            this.lviInstallments.Name = "lviInstallments";
            this.lviInstallments.Size = new System.Drawing.Size(1192, 267);
            this.lviInstallments.TabIndex = 0;
            this.lviInstallments.UseCompatibleStateImageBehavior = false;
            this.lviInstallments.View = System.Windows.Forms.View.Details;
            // 
            // chInstallmentCode
            // 
            this.chInstallmentCode.Text = "Codigo";
            this.chInstallmentCode.Width = 122;
            // 
            // chLoanCode
            // 
            this.chLoanCode.Text = "Codigo do Emprestimo";
            this.chLoanCode.Width = 231;
            // 
            // chValue
            // 
            this.chValue.Text = "Valor a pagar";
            this.chValue.Width = 304;
            // 
            // chDateToPay
            // 
            this.chDateToPay.Text = "Data de pagamento";
            this.chDateToPay.Width = 331;
            // 
            // chPaid
            // 
            this.chPaid.Text = "Está pago?";
            this.chPaid.Width = 200;
            // 
            // lvLoans
            // 
            this.lvLoans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCode,
            this.chClientCode,
            this.chCapital,
            this.chPercent,
            this.chStartDate,
            this.chEndDate,
            this.chResidualValue,
            this.chPaidLoan});
            this.lvLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLoans.FullRowSelect = true;
            this.lvLoans.GridLines = true;
            this.lvLoans.Location = new System.Drawing.Point(3, 93);
            this.lvLoans.Name = "lvLoans";
            this.lvLoans.Size = new System.Drawing.Size(1204, 209);
            this.lvLoans.TabIndex = 1;
            this.lvLoans.UseCompatibleStateImageBehavior = false;
            this.lvLoans.View = System.Windows.Forms.View.Details;
            this.lvLoans.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvLoans_MouseClick);
            // 
            // chCode
            // 
            this.chCode.Text = "Codigo";
            this.chCode.Width = 58;
            // 
            // chClientCode
            // 
            this.chClientCode.Text = "Codigo do Cliente";
            this.chClientCode.Width = 130;
            // 
            // chCapital
            // 
            this.chCapital.Text = "Capital";
            this.chCapital.Width = 250;
            // 
            // chPercent
            // 
            this.chPercent.Text = "Juros";
            this.chPercent.Width = 75;
            // 
            // chStartDate
            // 
            this.chStartDate.Text = "Data do Emprestimo";
            this.chStartDate.Width = 211;
            // 
            // chEndDate
            // 
            this.chEndDate.Text = "Data de Pagamento";
            this.chEndDate.Width = 213;
            // 
            // chResidualValue
            // 
            this.chResidualValue.Text = "Valor Residual";
            this.chResidualValue.Width = 175;
            // 
            // chPaidLoan
            // 
            this.chPaidLoan.Text = "Pago";
            this.chPaidLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chPaidLoan.Width = 85;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.lbSetInformation);
            this.gbActions.Controls.Add(this.btnDefineLoanAsPaid);
            this.gbActions.Controls.Add(this.lbInstallment);
            this.gbActions.Controls.Add(this.lbClientName);
            this.gbActions.Controls.Add(this.lbInformation);
            this.gbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActions.Location = new System.Drawing.Point(3, 3);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(1204, 84);
            this.gbActions.TabIndex = 0;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Detalhes";
            // 
            // lbSetInformation
            // 
            this.lbSetInformation.AutoSize = true;
            this.lbSetInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetInformation.Location = new System.Drawing.Point(800, 58);
            this.lbSetInformation.Name = "lbSetInformation";
            this.lbSetInformation.Size = new System.Drawing.Size(398, 17);
            this.lbSetInformation.TabIndex = 4;
            this.lbSetInformation.Text = "Selecione um emprestimo ou parcela para colocar como pago";
            // 
            // btnDefineLoanAsPaid
            // 
            this.btnDefineLoanAsPaid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDefineLoanAsPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefineLoanAsPaid.Location = new System.Drawing.Point(876, 13);
            this.btnDefineLoanAsPaid.Name = "btnDefineLoanAsPaid";
            this.btnDefineLoanAsPaid.Size = new System.Drawing.Size(322, 33);
            this.btnDefineLoanAsPaid.TabIndex = 3;
            this.btnDefineLoanAsPaid.Text = "Colocar Emprestimo como pago!";
            this.btnDefineLoanAsPaid.UseVisualStyleBackColor = false;
            this.btnDefineLoanAsPaid.Click += new System.EventHandler(this.btnDefineLoanAsPaid_Click);
            // 
            // lbInstallment
            // 
            this.lbInstallment.AutoSize = true;
            this.lbInstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstallment.ForeColor = System.Drawing.Color.Red;
            this.lbInstallment.Location = new System.Drawing.Point(21, 58);
            this.lbInstallment.Name = "lbInstallment";
            this.lbInstallment.Size = new System.Drawing.Size(370, 17);
            this.lbInstallment.TabIndex = 2;
            this.lbInstallment.Text = "Clique no emprestimo com parcelas para ver as parcelas.";
            // 
            // lbClientName
            // 
            this.lbClientName.AutoSize = true;
            this.lbClientName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientName.Location = new System.Drawing.Point(319, 23);
            this.lbClientName.Name = "lbClientName";
            this.lbClientName.Size = new System.Drawing.Size(82, 24);
            this.lbClientName.TabIndex = 1;
            this.lbClientName.Text = "Teste 1";
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformation.Location = new System.Drawing.Point(20, 24);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(282, 22);
            this.lbInformation.TabIndex = 0;
            this.lbInformation.Text = "Apresentando emprestimos de: ";
            this.lbInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDefineInstallmentAsPaid
            // 
            this.btnDefineInstallmentAsPaid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDefineInstallmentAsPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefineInstallmentAsPaid.Location = new System.Drawing.Point(866, 14);
            this.btnDefineInstallmentAsPaid.Name = "btnDefineInstallmentAsPaid";
            this.btnDefineInstallmentAsPaid.Size = new System.Drawing.Size(322, 33);
            this.btnDefineInstallmentAsPaid.TabIndex = 5;
            this.btnDefineInstallmentAsPaid.Text = "Colocar Parcela como pago!";
            this.btnDefineInstallmentAsPaid.UseVisualStyleBackColor = false;
            this.btnDefineInstallmentAsPaid.Click += new System.EventHandler(this.btnDefineInstallmentAsPaid_Click);
            // 
            // FormLoanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FormLoanList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoanList";
            this.Load += new System.EventHandler(this.FormLoanList_Load);
            this.panel1.ResumeLayout(false);
            this.gbInstallments.ResumeLayout(false);
            this.gbInstallments.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.gbActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.GroupBox gbInstallments;
        private System.Windows.Forms.ListView lviInstallments;
        private System.Windows.Forms.ListView lvLoans;
        private System.Windows.Forms.ColumnHeader chCode;
        private System.Windows.Forms.ColumnHeader chClientCode;
        private System.Windows.Forms.ColumnHeader chCapital;
        private System.Windows.Forms.ColumnHeader chPercent;
        private System.Windows.Forms.ColumnHeader chStartDate;
        private System.Windows.Forms.ColumnHeader chEndDate;
        private System.Windows.Forms.ColumnHeader chResidualValue;
        private System.Windows.Forms.ColumnHeader chPaidLoan;
        private System.Windows.Forms.ColumnHeader chInstallmentCode;
        private System.Windows.Forms.ColumnHeader chLoanCode;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.ColumnHeader chDateToPay;
        private System.Windows.Forms.ColumnHeader chPaid;
        private System.Windows.Forms.Label lbClientName;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.Label lbInstallment;
        private System.Windows.Forms.Label lbSetInformation;
        private System.Windows.Forms.Button btnDefineLoanAsPaid;
        private System.Windows.Forms.Label lbInstallmenttitle;
        private System.Windows.Forms.Button btnDefineInstallmentAsPaid;
    }
}