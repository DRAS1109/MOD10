namespace GestEmpresa_Dinis
{
    partial class frmPrincipal
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
            dgbDados = new DataGridView();
            btnEditar = new Button();
            btnNovo = new Button();
            btnRemover = new Button();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)dgbDados).BeginInit();
            SuspendLayout();
            // 
            // dgbDados
            // 
            dgbDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbDados.Location = new Point(12, 12);
            dgbDados.Name = "dgbDados";
            dgbDados.Size = new Size(646, 406);
            dgbDados.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(679, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 25);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "&Ver/Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(679, 43);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(100, 25);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(679, 74);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(100, 25);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "&Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(679, 393);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 25);
            btnSair.TabIndex = 4;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 430);
            Controls.Add(btnSair);
            Controls.Add(btnRemover);
            Controls.Add(btnNovo);
            Controls.Add(btnEditar);
            Controls.Add(dgbDados);
            Name = "frmPrincipal";
            ShowIcon = false;
            Text = "GestEmpresa";
            ((System.ComponentModel.ISupportInitialize)dgbDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgbDados;
        private Button btnEditar;
        private Button btnNovo;
        private Button btnRemover;
        private Button btnSair;
    }
}
