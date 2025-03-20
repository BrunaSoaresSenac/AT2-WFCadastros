namespace AT2_WFCadastros
{
    partial class FormLista
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
            dgvListaCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaCategorias).BeginInit();
            SuspendLayout();
            // 
            // dgvListaCategorias
            // 
            dgvListaCategorias.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvListaCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCategorias.Location = new Point(0, 0);
            dgvListaCategorias.Name = "dgvListaCategorias";
            dgvListaCategorias.Size = new Size(547, 167);
            dgvListaCategorias.TabIndex = 0;
            // 
            // FormLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 168);
            Controls.Add(dgvListaCategorias);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem de Categorias";
            Load += FormLista_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaCategorias;
    }
}