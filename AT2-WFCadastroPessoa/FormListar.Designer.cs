namespace AT2_WFCadastroPessoa
{
    partial class FormListar
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
            dgvListaPessoas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaPessoas).BeginInit();
            SuspendLayout();
            // 
            // dgvListaPessoas
            // 
            dgvListaPessoas.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvListaPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaPessoas.Location = new Point(0, 0);
            dgvListaPessoas.Name = "dgvListaPessoas";
            dgvListaPessoas.Size = new Size(782, 225);
            dgvListaPessoas.TabIndex = 0;
            // 
            // FormListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 223);
            Controls.Add(dgvListaPessoas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Cadastro";
            Load += FormListar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaPessoas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaPessoas;
    }
}