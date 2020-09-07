namespace Gestão_de_Emprestimos
{
    partial class InputMessageDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputMessageDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseProgram = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbWebURLDataBase = new System.Windows.Forms.Label();
            this.lbLocalPathName = new System.Windows.Forms.Label();
            this.rTxtBoxWebURLDataBase = new System.Windows.Forms.RichTextBox();
            this.txtLocalPathName = new System.Windows.Forms.TextBox();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWarningImage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbInstruction);
            this.panel1.Controls.Add(this.txtLocalPathName);
            this.panel1.Controls.Add(this.rTxtBoxWebURLDataBase);
            this.panel1.Controls.Add(this.lbLocalPathName);
            this.panel1.Controls.Add(this.lbWebURLDataBase);
            this.panel1.Controls.Add(this.btnCloseProgram);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lbWarningImage);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 514);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.Location = new System.Drawing.Point(6, 478);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(268, 29);
            this.btnCloseProgram.TabIndex = 2;
            this.btnCloseProgram.Text = "Fechar Programa";
            this.btnCloseProgram.UseVisualStyleBackColor = true;
            this.btnCloseProgram.Click += new System.EventHandler(this.btnCloseProgram_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(399, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(258, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbWebURLDataBase
            // 
            this.lbWebURLDataBase.AutoSize = true;
            this.lbWebURLDataBase.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWebURLDataBase.Location = new System.Drawing.Point(161, 334);
            this.lbWebURLDataBase.Name = "lbWebURLDataBase";
            this.lbWebURLDataBase.Size = new System.Drawing.Size(320, 20);
            this.lbWebURLDataBase.TabIndex = 6;
            this.lbWebURLDataBase.Text = "URL do Banco de dados Online (Opcional):";
            // 
            // lbLocalPathName
            // 
            this.lbLocalPathName.AutoSize = true;
            this.lbLocalPathName.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalPathName.Location = new System.Drawing.Point(188, 216);
            this.lbLocalPathName.Name = "lbLocalPathName";
            this.lbLocalPathName.Size = new System.Drawing.Size(270, 20);
            this.lbLocalPathName.TabIndex = 7;
            this.lbLocalPathName.Text = "Caminho do Banco de Dados Local:";
            // 
            // rTxtBoxWebURLDataBase
            // 
            this.rTxtBoxWebURLDataBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtBoxWebURLDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBoxWebURLDataBase.Location = new System.Drawing.Point(3, 366);
            this.rTxtBoxWebURLDataBase.Name = "rTxtBoxWebURLDataBase";
            this.rTxtBoxWebURLDataBase.Size = new System.Drawing.Size(651, 96);
            this.rTxtBoxWebURLDataBase.TabIndex = 8;
            this.rTxtBoxWebURLDataBase.Text = "";
            // 
            // txtLocalPathName
            // 
            this.txtLocalPathName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalPathName.Location = new System.Drawing.Point(6, 293);
            this.txtLocalPathName.Name = "txtLocalPathName";
            this.txtLocalPathName.Size = new System.Drawing.Size(648, 23);
            this.txtLocalPathName.TabIndex = 9;
            // 
            // lbInstruction
            // 
            this.lbInstruction.AutoSize = true;
            this.lbInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruction.Location = new System.Drawing.Point(5, 249);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(654, 30);
            this.lbInstruction.TabIndex = 10;
            this.lbInstruction.Text = "De preferencia Crie uma pasta na pasta Documents com o nome de \"SIG Emprestimo\" e" +
    " coloque o banco de dados aí,\r\n depois cópie o cominho do arquivo. ele deverá te" +
    "rminar com /nomedoarquivo.accdb";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Antes de Usar o programa preciso de algumas informações! Se não conseguir complet" +
    "a-lás,\r\nEntre em contacto com o programador pelos numeros -  (+258) 84 24 73 772" +
    " ou (+258) 82 25 65 148 ";
            // 
            // lbWarningImage
            // 
            this.lbWarningImage.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbWarningImage.Image = ((System.Drawing.Image)(resources.GetObject("lbWarningImage.Image")));
            this.lbWarningImage.Location = new System.Drawing.Point(235, 0);
            this.lbWarningImage.Name = "lbWarningImage";
            this.lbWarningImage.Size = new System.Drawing.Size(193, 148);
            this.lbWarningImage.TabIndex = 12;
            this.lbWarningImage.Text = "eqweqwe ";
            this.lbWarningImage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InputMessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 541);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputMessageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning Informations Needed";
            this.Load += new System.EventHandler(this.InputMessageDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCloseProgram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInstruction;
        private System.Windows.Forms.TextBox txtLocalPathName;
        private System.Windows.Forms.RichTextBox rTxtBoxWebURLDataBase;
        private System.Windows.Forms.Label lbLocalPathName;
        private System.Windows.Forms.Label lbWebURLDataBase;
        private System.Windows.Forms.Label lbWarningImage;
    }
}