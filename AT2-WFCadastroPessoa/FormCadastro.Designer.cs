namespace AT2_WFCadastroPessoa
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblCodigo = new Label();
            lblCPF = new Label();
            lblNomeCompleto = new Label();
            lblEmail = new Label();
            lblCelular = new Label();
            chkFilhos = new CheckBox();
            grpTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            mtbCodigo = new MaskedTextBox();
            mtbCpf = new MaskedTextBox();
            txtNomeCompleto = new TextBox();
            txtEmail = new TextBox();
            mtbCelular = new MaskedTextBox();
            btnVoltar = new Button();
            btnSalvar = new Button();
            grpTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(20, 15);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(182, 15);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 1;
            lblCPF.Text = "CPF:";
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(15, 72);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(99, 15);
            lblNomeCompleto.TabIndex = 2;
            lblNomeCompleto.Text = "Nome Completo:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(17, 127);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-mail:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(21, 197);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(73, 15);
            lblCelular.TabIndex = 4;
            lblCelular.Text = "DDD/Celular";
            // 
            // chkFilhos
            // 
            chkFilhos.AutoSize = true;
            chkFilhos.Location = new Point(21, 251);
            chkFilhos.Name = "chkFilhos";
            chkFilhos.Size = new Size(99, 19);
            chkFilhos.TabIndex = 6;
            chkFilhos.Text = "Possui Filhos?";
            chkFilhos.UseVisualStyleBackColor = true;
            // 
            // grpTelefone
            // 
            grpTelefone.Controls.Add(rdbRecado);
            grpTelefone.Controls.Add(rdbComercial);
            grpTelefone.Controls.Add(rdbPessoal);
            grpTelefone.Location = new Point(171, 176);
            grpTelefone.Name = "grpTelefone";
            grpTelefone.Size = new Size(101, 105);
            grpTelefone.TabIndex = 7;
            grpTelefone.TabStop = false;
            grpTelefone.Text = "Tipo Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(12, 75);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 9;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(12, 50);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 8;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(12, 25);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 7;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // mtbCodigo
            // 
            mtbCodigo.Enabled = false;
            mtbCodigo.Location = new Point(15, 33);
            mtbCodigo.Name = "mtbCodigo";
            mtbCodigo.ReadOnly = true;
            mtbCodigo.Size = new Size(100, 23);
            mtbCodigo.TabIndex = 1;
            // 
            // mtbCpf
            // 
            mtbCpf.Location = new Point(182, 33);
            mtbCpf.Mask = "000.000.000-00";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(90, 23);
            mtbCpf.TabIndex = 2;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(15, 90);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(260, 23);
            txtNomeCompleto.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 23);
            txtEmail.TabIndex = 4;
            // 
            // mtbCelular
            // 
            mtbCelular.Location = new Point(21, 213);
            mtbCelular.Mask = "(00) 00000-0000";
            mtbCelular.Name = "mtbCelular";
            mtbCelular.Size = new Size(100, 23);
            mtbCelular.TabIndex = 5;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ActiveCaption;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(37, 289);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 36);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ActiveCaption;
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(178, 289);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(92, 36);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(296, 335);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(mtbCelular);
            Controls.Add(txtEmail);
            Controls.Add(txtNomeCompleto);
            Controls.Add(mtbCpf);
            Controls.Add(mtbCodigo);
            Controls.Add(grpTelefone);
            Controls.Add(chkFilhos);
            Controls.Add(lblCelular);
            Controls.Add(lblEmail);
            Controls.Add(lblNomeCompleto);
            Controls.Add(lblCPF);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            grpTelefone.ResumeLayout(false);
            grpTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblCPF;
        private Label lblNomeCompleto;
        private Label lblEmail;
        private Label lblCelular;
        private CheckBox chkFilhos;
        private GroupBox grpTelefone;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private MaskedTextBox mtbCodigo;
        private MaskedTextBox mtbCpf;
        private TextBox txtNomeCompleto;
        private TextBox txtEmail;
        private MaskedTextBox mtbCelular;
        private Button btnVoltar;
        private Button btnSalvar;
    }
}