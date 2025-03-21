namespace AT2_WFCadastros
{
    partial class FormCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrar));
            mtbCodigo = new MaskedTextBox();
            lblCodigo = new Label();
            lblCategoria = new Label();
            lblDescricao = new Label();
            lblStatus = new Label();
            lblDataCadastro = new Label();
            txtCategoria = new TextBox();
            rtbDescricao = new RichTextBox();
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            dtpDataCadastro = new DateTimePicker();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // mtbCodigo
            // 
            mtbCodigo.Enabled = false;
            mtbCodigo.Location = new Point(12, 28);
            mtbCodigo.Name = "mtbCodigo";
            mtbCodigo.ReadOnly = true;
            mtbCodigo.Size = new Size(70, 23);
            mtbCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(13, 10);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(133, 9);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 75);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Descrição:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(31, 182);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(169, 179);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(84, 15);
            lblDataCadastro.TabIndex = 5;
            lblDataCadastro.Text = "Data Cadastro:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(129, 29);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(143, 23);
            txtCategoria.TabIndex = 1;
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(12, 93);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(260, 71);
            rtbDescricao.TabIndex = 2;
            rtbDescricao.Text = "";
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(31, 200);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 3;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(31, 225);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 4;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(169, 197);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(91, 23);
            dtpDataCadastro.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.MenuHighlight;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.Location = new Point(148, 227);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(124, 41);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(287, 280);
            Controls.Add(btnCadastrar);
            Controls.Add(dtpDataCadastro);
            Controls.Add(rdbInativo);
            Controls.Add(rdbAtivo);
            Controls.Add(rtbDescricao);
            Controls.Add(txtCategoria);
            Controls.Add(lblDataCadastro);
            Controls.Add(lblStatus);
            Controls.Add(lblDescricao);
            Controls.Add(lblCategoria);
            Controls.Add(lblCodigo);
            Controls.Add(mtbCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu de Cadastro";
            Load += FormCadastrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbCodigo;
        private Label lblCodigo;
        private Label lblCategoria;
        private Label lblDescricao;
        private Label lblStatus;
        private Label lblDataCadastro;
        private TextBox txtCategoria;
        private RichTextBox rtbDescricao;
        private RadioButton rdbAtivo;
        private RadioButton rdbInativo;
        private DateTimePicker dtpDataCadastro;
        private Button btnCadastrar;
    }
}