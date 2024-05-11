namespace API_VerificaCPF_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonVerificaCPFMascara = new Button();
            maskedTextBoxCPF = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            buttonGerarCPF = new Button();
            maskedTextBoxCPFGerado = new MaskedTextBox();
            buttonGerarCPFSemMascara = new Button();
            textBoxCPFGeradoSemMaskara = new TextBox();
            buttonLimpar = new Button();
            buttonGeraCPFsMascara = new Button();
            numericUpDownqQtdeCpfs = new NumericUpDown();
            buttonGeraCPFs = new Button();
            label4 = new Label();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)numericUpDownqQtdeCpfs).BeginInit();
            SuspendLayout();
            // 
            // buttonVerificaCPFMascara
            // 
            buttonVerificaCPFMascara.BackColor = Color.OliveDrab;
            buttonVerificaCPFMascara.Cursor = Cursors.Hand;
            buttonVerificaCPFMascara.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVerificaCPFMascara.ForeColor = SystemColors.Info;
            buttonVerificaCPFMascara.Location = new Point(527, 56);
            buttonVerificaCPFMascara.Name = "buttonVerificaCPFMascara";
            buttonVerificaCPFMascara.Size = new Size(231, 29);
            buttonVerificaCPFMascara.TabIndex = 1;
            buttonVerificaCPFMascara.Text = "Verificar CPF";
            buttonVerificaCPFMascara.UseVisualStyleBackColor = false;
            buttonVerificaCPFMascara.Click += buttonVerificaCPFMascara_Click;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxCPF.ForeColor = SystemColors.WindowText;
            maskedTextBoxCPF.Location = new Point(274, 56);
            maskedTextBoxCPF.Mask = "000,000,000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(247, 29);
            maskedTextBoxCPF.TabIndex = 0;
            maskedTextBoxCPF.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            maskedTextBoxCPF.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(256, 28);
            label2.TabIndex = 3;
            label2.Text = "Digite o CPF (somente numeros): ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(307, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 6;
            label1.Text = "VALIDADOR DE CPF";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(153, 28);
            label3.TabIndex = 7;
            label3.Text = "GERADOR DE CPF";
            // 
            // buttonGerarCPF
            // 
            buttonGerarCPF.BackColor = Color.OliveDrab;
            buttonGerarCPF.Cursor = Cursors.Hand;
            buttonGerarCPF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGerarCPF.ForeColor = SystemColors.Info;
            buttonGerarCPF.Location = new Point(12, 193);
            buttonGerarCPF.Name = "buttonGerarCPF";
            buttonGerarCPF.Size = new Size(256, 39);
            buttonGerarCPF.TabIndex = 2;
            buttonGerarCPF.Text = "Gerar CPF (XXX.XXX.XXX-XX)";
            buttonGerarCPF.UseVisualStyleBackColor = false;
            buttonGerarCPF.Click += buttonGerarCPF_Click;
            // 
            // maskedTextBoxCPFGerado
            // 
            maskedTextBoxCPFGerado.Cursor = Cursors.No;
            maskedTextBoxCPFGerado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxCPFGerado.ForeColor = SystemColors.WindowText;
            maskedTextBoxCPFGerado.Location = new Point(274, 199);
            maskedTextBoxCPFGerado.Mask = "000,000,000-00";
            maskedTextBoxCPFGerado.Name = "maskedTextBoxCPFGerado";
            maskedTextBoxCPFGerado.ReadOnly = true;
            maskedTextBoxCPFGerado.Size = new Size(247, 29);
            maskedTextBoxCPFGerado.TabIndex = 9;
            maskedTextBoxCPFGerado.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxCPFGerado.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            maskedTextBoxCPFGerado.UseWaitCursor = true;
            // 
            // buttonGerarCPFSemMascara
            // 
            buttonGerarCPFSemMascara.BackColor = Color.OliveDrab;
            buttonGerarCPFSemMascara.Cursor = Cursors.Hand;
            buttonGerarCPFSemMascara.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGerarCPFSemMascara.ForeColor = SystemColors.Info;
            buttonGerarCPFSemMascara.Location = new Point(12, 256);
            buttonGerarCPFSemMascara.Name = "buttonGerarCPFSemMascara";
            buttonGerarCPFSemMascara.Size = new Size(256, 39);
            buttonGerarCPFSemMascara.TabIndex = 3;
            buttonGerarCPFSemMascara.Text = "Gerar CPF (XXXXXXXXXXX)";
            buttonGerarCPFSemMascara.UseVisualStyleBackColor = false;
            buttonGerarCPFSemMascara.Click += buttonGerarCPFSemMascara_Click;
            // 
            // textBoxCPFGeradoSemMaskara
            // 
            textBoxCPFGeradoSemMaskara.Cursor = Cursors.No;
            textBoxCPFGeradoSemMaskara.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCPFGeradoSemMaskara.Location = new Point(274, 262);
            textBoxCPFGeradoSemMaskara.Name = "textBoxCPFGeradoSemMaskara";
            textBoxCPFGeradoSemMaskara.ReadOnly = true;
            textBoxCPFGeradoSemMaskara.Size = new Size(247, 29);
            textBoxCPFGeradoSemMaskara.TabIndex = 11;
            textBoxCPFGeradoSemMaskara.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.Red;
            buttonLimpar.Cursor = Cursors.Hand;
            buttonLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpar.ForeColor = SystemColors.Info;
            buttonLimpar.Location = new Point(658, 409);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(100, 29);
            buttonLimpar.TabIndex = 4;
            buttonLimpar.Text = "LIMPAR";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // buttonGeraCPFsMascara
            // 
            buttonGeraCPFsMascara.BackColor = Color.OliveDrab;
            buttonGeraCPFsMascara.Cursor = Cursors.Hand;
            buttonGeraCPFsMascara.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGeraCPFsMascara.ForeColor = SystemColors.Info;
            buttonGeraCPFsMascara.Location = new Point(12, 315);
            buttonGeraCPFsMascara.Name = "buttonGeraCPFsMascara";
            buttonGeraCPFsMascara.Size = new Size(256, 39);
            buttonGeraCPFsMascara.TabIndex = 13;
            buttonGeraCPFsMascara.Text = "Gerar CPFs (XXX.XXX.XXX-XX)";
            buttonGeraCPFsMascara.UseVisualStyleBackColor = false;
            buttonGeraCPFsMascara.Click += buttonGeraCPFsMascara_Click;
            // 
            // numericUpDownqQtdeCpfs
            // 
            numericUpDownqQtdeCpfs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownqQtdeCpfs.Location = new Point(433, 325);
            numericUpDownqQtdeCpfs.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownqQtdeCpfs.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownqQtdeCpfs.Name = "numericUpDownqQtdeCpfs";
            numericUpDownqQtdeCpfs.Size = new Size(120, 29);
            numericUpDownqQtdeCpfs.TabIndex = 14;
            numericUpDownqQtdeCpfs.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // buttonGeraCPFs
            // 
            buttonGeraCPFs.BackColor = Color.OliveDrab;
            buttonGeraCPFs.Cursor = Cursors.Hand;
            buttonGeraCPFs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGeraCPFs.ForeColor = SystemColors.Info;
            buttonGeraCPFs.Location = new Point(12, 371);
            buttonGeraCPFs.Name = "buttonGeraCPFs";
            buttonGeraCPFs.Size = new Size(256, 39);
            buttonGeraCPFs.TabIndex = 15;
            buttonGeraCPFs.Text = "Gerar CPFs (XXXXXXXXXXX)";
            buttonGeraCPFs.UseVisualStyleBackColor = false;
            buttonGeraCPFs.Click += buttonGeraCPFs_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(307, 324);
            label4.Name = "label4";
            label4.Size = new Size(120, 30);
            label4.TabIndex = 16;
            label4.Text = "QUANTIDADE";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(746, 297);
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(770, 450);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(buttonGeraCPFs);
            Controls.Add(numericUpDownqQtdeCpfs);
            Controls.Add(buttonGeraCPFsMascara);
            Controls.Add(buttonLimpar);
            Controls.Add(textBoxCPFGeradoSemMaskara);
            Controls.Add(buttonGerarCPFSemMascara);
            Controls.Add(maskedTextBoxCPFGerado);
            Controls.Add(buttonGerarCPF);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(buttonVerificaCPFMascara);
            Controls.Add(maskedTextBoxCPF);
            Controls.Add(label2);
            MaximumSize = new Size(786, 489);
            MinimumSize = new Size(786, 489);
            Name = "Form1";
            Text = "Validador e Gerador de CPFs";
            ((System.ComponentModel.ISupportInitialize)numericUpDownqQtdeCpfs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonVerificaCPFMascara;
        private MaskedTextBox maskedTextBoxCPF;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button buttonGerarCPF;
        private MaskedTextBox maskedTextBoxCPFGerado;
        private Button buttonGerarCPFSemMascara;
        private TextBox textBoxCPFGeradoSemMaskara;
        private Button buttonLimpar;
        private Button buttonGeraCPFsMascara;
        private Button buttonGeraCPFs;
        private Label label4;
        private ListView listView1;
        public NumericUpDown numericUpDownqQtdeCpfs;
    }
}
