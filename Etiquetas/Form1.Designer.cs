namespace Etiquetas
{
    partial class Form1
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
            this.btImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRh = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblError = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cbxBacteria = new System.Windows.Forms.CheckBox();
            this.cbxInsetos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbVolume = new System.Windows.Forms.TextBox();
            this.txbLote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.txbValidade = new System.Windows.Forms.MaskedTextBox();
            this.txbDiluicao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(124, 456);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(116, 34);
            this.btImprimir.TabIndex = 5;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "RH";
            // 
            // txbRh
            // 
            this.txbRh.Location = new System.Drawing.Point(124, 78);
            this.txbRh.Name = "txbRh";
            this.txbRh.Size = new System.Drawing.Size(143, 20);
            this.txbRh.TabIndex = 1;
            this.txbRh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRh_KeyPress);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(139, 157);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 6;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(104, 22);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(195, 20);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Aplicação Etiqueta Alergia";
            // 
            // cbxBacteria
            // 
            this.cbxBacteria.AutoSize = true;
            this.cbxBacteria.Location = new System.Drawing.Point(26, 121);
            this.cbxBacteria.Name = "cbxBacteria";
            this.cbxBacteria.Size = new System.Drawing.Size(234, 17);
            this.cbxBacteria.TabIndex = 12;
            this.cbxBacteria.Text = "D. pteromyssinus + B. Tropicalis + Ext. Bact.";
            this.cbxBacteria.UseVisualStyleBackColor = true;
            // 
            // cbxInsetos
            // 
            this.cbxInsetos.AutoSize = true;
            this.cbxInsetos.Location = new System.Drawing.Point(26, 152);
            this.cbxInsetos.Name = "cbxInsetos";
            this.cbxInsetos.Size = new System.Drawing.Size(60, 17);
            this.cbxInsetos.TabIndex = 13;
            this.cbxInsetos.Text = "Insetos";
            this.cbxInsetos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Volume";
            // 
            // txbVolume
            // 
            this.txbVolume.Location = new System.Drawing.Point(124, 243);
            this.txbVolume.Name = "txbVolume";
            this.txbVolume.Size = new System.Drawing.Size(100, 20);
            this.txbVolume.TabIndex = 15;
            // 
            // txbLote
            // 
            this.txbLote.Location = new System.Drawing.Point(124, 301);
            this.txbLote.Name = "txbLote";
            this.txbLote.Size = new System.Drawing.Size(100, 20);
            this.txbLote.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Lote";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fabricacao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Validade";
            // 
            // txbFabricacao
            // 
            this.txbFabricacao.Location = new System.Drawing.Point(124, 358);
            this.txbFabricacao.Mask = "00/00/0000";
            this.txbFabricacao.Name = "txbFabricacao";
            this.txbFabricacao.Size = new System.Drawing.Size(75, 20);
            this.txbFabricacao.TabIndex = 21;
            // 
            // txbValidade
            // 
            this.txbValidade.Location = new System.Drawing.Point(124, 400);
            this.txbValidade.Mask = "00/00/0000";
            this.txbValidade.Name = "txbValidade";
            this.txbValidade.Size = new System.Drawing.Size(75, 20);
            this.txbValidade.TabIndex = 22;
            // 
            // txbDiluicao
            // 
            this.txbDiluicao.Location = new System.Drawing.Point(124, 199);
            this.txbDiluicao.Name = "txbDiluicao";
            this.txbDiluicao.Size = new System.Drawing.Size(100, 20);
            this.txbDiluicao.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Diluição";
            // 
            // Form1
            // 
            this.AcceptButton = this.btImprimir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 539);
            this.Controls.Add(this.txbDiluicao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbValidade);
            this.Controls.Add(this.txbFabricacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbLote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxInsetos);
            this.Controls.Add(this.cbxBacteria);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbRh);
            this.Controls.Add(this.btImprimir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRh;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.CheckBox cbxBacteria;
        private System.Windows.Forms.CheckBox cbxInsetos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbVolume;
        private System.Windows.Forms.TextBox txbLote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txbFabricacao;
        private System.Windows.Forms.MaskedTextBox txbValidade;
        private System.Windows.Forms.TextBox txbDiluicao;
        private System.Windows.Forms.Label label6;

    }
}

