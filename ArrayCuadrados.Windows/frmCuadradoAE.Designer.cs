namespace ArrayCuadrados.Windows
{
    partial class frmCuadradoAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtLado = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            cboColores = new ComboBox();
            label3 = new Label();
            cboBorde = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Medida de lado:";
            // 
            // txtLado
            // 
            txtLado.Location = new Point(125, 6);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(100, 23);
            txtLado.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(27, 145);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(89, 49);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(226, 145);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 49);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 72);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Color relleno:";
            label2.Click += label2_Click;
            // 
            // cboColores
            // 
            cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColores.FormattingEnabled = true;
            cboColores.Location = new Point(125, 69);
            cboColores.Name = "cboColores";
            cboColores.Size = new Size(121, 23);
            cboColores.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 73);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 6;
            label3.Text = "Tipo de borde:";
            // 
            // cboBorde
            // 
            cboBorde.FormattingEnabled = true;
            cboBorde.Location = new Point(354, 70);
            cboBorde.Name = "cboBorde";
            cboBorde.Size = new Size(121, 23);
            cboBorde.TabIndex = 7;
            // 
            // frmCuadradoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 291);
            Controls.Add(cboBorde);
            Controls.Add(label3);
            Controls.Add(cboColores);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtLado);
            Controls.Add(label1);
            MaximumSize = new Size(510, 330);
            MinimumSize = new Size(510, 330);
            Name = "frmCuadradoAE";
            Text = "frmCuadradoAE";
            Load += frmCuadradoAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLado;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
        private Label label2;
        private ComboBox cboColores;
        private ComboBox cboBorde;
        private Label label3;
    }
}