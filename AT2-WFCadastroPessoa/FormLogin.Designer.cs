namespace AT2_WFCadastroPessoa
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtLogin = new TextBox();
            textBox1 = new TextBox();
            btnAcessar = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.BackColor = SystemColors.ControlLightLight;
            txtLogin.Location = new Point(31, 50);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "LOGIN";
            txtLogin.Size = new Size(135, 23);
            txtLogin.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Location = new Point(31, 92);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "SENHA";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 1;
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = SystemColors.ActiveCaption;
            btnAcessar.Location = new Point(58, 140);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(75, 23);
            btnAcessar.TabIndex = 2;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(204, 189);
            Controls.Add(btnAcessar);
            Controls.Add(textBox1);
            Controls.Add(txtLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acesso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox textBox1;
        private Button btnAcessar;
    }
}
