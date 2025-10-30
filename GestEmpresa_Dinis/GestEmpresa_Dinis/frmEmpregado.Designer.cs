namespace GestEmpresa_Dinis
{
    partial class frmEmpregado
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
            lblCargo = new Label();
            txtNome = new TextBox();
            dtpDataNasc = new DateTimePicker();
            chkEditar = new CheckBox();
            gpbMorada = new GroupBox();
            txtLocalidade = new TextBox();
            txtCodPostal = new TextBox();
            txtRua = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cmbCargo = new ComboBox();
            lblNome = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblID = new Label();
            txtID = new TextBox();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            lblDataNasc = new Label();
            pnlAnalista = new Panel();
            txtProjeto = new TextBox();
            lblProjeto = new Label();
            btnCancelar = new Button();
            btnOk = new Button();
            gpbMorada.SuspendLayout();
            pnlAnalista.SuspendLayout();
            SuspendLayout();
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 10F);
            lblCargo.Location = new Point(25, 23);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(46, 19);
            lblCargo.TabIndex = 0;
            lblCargo.Text = "Cargo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(75, 62);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(480, 23);
            txtNome.TabIndex = 1;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(375, 142);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(180, 23);
            dtpDataNasc.TabIndex = 2;
            // 
            // chkEditar
            // 
            chkEditar.AutoSize = true;
            chkEditar.Font = new Font("Segoe UI", 10F);
            chkEditar.Location = new Point(492, 19);
            chkEditar.Name = "chkEditar";
            chkEditar.Size = new Size(63, 23);
            chkEditar.TabIndex = 3;
            chkEditar.Text = "Editar";
            chkEditar.UseVisualStyleBackColor = true;
            // 
            // gpbMorada
            // 
            gpbMorada.Controls.Add(txtLocalidade);
            gpbMorada.Controls.Add(txtCodPostal);
            gpbMorada.Controls.Add(txtRua);
            gpbMorada.Font = new Font("Segoe UI", 10F);
            gpbMorada.Location = new Point(27, 183);
            gpbMorada.Name = "gpbMorada";
            gpbMorada.Size = new Size(528, 107);
            gpbMorada.TabIndex = 4;
            gpbMorada.TabStop = false;
            gpbMorada.Text = "Morada";
            // 
            // txtLocalidade
            // 
            txtLocalidade.Location = new Point(226, 64);
            txtLocalidade.Name = "txtLocalidade";
            txtLocalidade.Size = new Size(284, 25);
            txtLocalidade.TabIndex = 16;
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(20, 64);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(180, 25);
            txtCodPostal.TabIndex = 11;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(20, 27);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(490, 25);
            txtRua.TabIndex = 10;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(75, 22);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(180, 23);
            cmbCargo.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(25, 63);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 19);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(26, 103);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 19);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(75, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 23);
            txtEmail.TabIndex = 9;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.Location = new Point(337, 22);
            lblID.Name = "lblID";
            lblID.Size = new Size(23, 19);
            lblID.TabIndex = 10;
            lblID.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(375, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(72, 23);
            txtID.TabIndex = 11;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(375, 102);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(180, 23);
            txtTelefone.TabIndex = 13;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 10F);
            lblTelefone.Location = new Point(305, 103);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(59, 19);
            lblTelefone.TabIndex = 12;
            lblTelefone.Text = "Telefone";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Font = new Font("Segoe UI", 10F);
            lblDataNasc.Location = new Point(236, 146);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(133, 19);
            lblDataNasc.TabIndex = 14;
            lblDataNasc.Text = "Data de Nascimento";
            // 
            // pnlAnalista
            // 
            pnlAnalista.Controls.Add(txtProjeto);
            pnlAnalista.Controls.Add(lblProjeto);
            pnlAnalista.Location = new Point(27, 310);
            pnlAnalista.Name = "pnlAnalista";
            pnlAnalista.Size = new Size(528, 48);
            pnlAnalista.TabIndex = 15;
            // 
            // txtProjeto
            // 
            txtProjeto.Location = new Point(67, 11);
            txtProjeto.Name = "txtProjeto";
            txtProjeto.Size = new Size(443, 23);
            txtProjeto.TabIndex = 12;
            // 
            // lblProjeto
            // 
            lblProjeto.AutoSize = true;
            lblProjeto.Font = new Font("Segoe UI", 10F);
            lblProjeto.Location = new Point(10, 12);
            lblProjeto.Name = "lblProjeto";
            lblProjeto.Size = new Size(53, 19);
            lblProjeto.TabIndex = 8;
            lblProjeto.Text = "Projeto";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(339, 372);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 10F);
            btnOk.Location = new Point(455, 372);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 30);
            btnOk.TabIndex = 17;
            btnOk.Text = "&Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // frmEmpregado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 411);
            Controls.Add(btnOk);
            Controls.Add(btnCancelar);
            Controls.Add(pnlAnalista);
            Controls.Add(lblDataNasc);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(cmbCargo);
            Controls.Add(gpbMorada);
            Controls.Add(chkEditar);
            Controls.Add(dtpDataNasc);
            Controls.Add(txtNome);
            Controls.Add(lblCargo);
            Name = "frmEmpregado";
            ShowIcon = false;
            Text = "Empregado";
            gpbMorada.ResumeLayout(false);
            gpbMorada.PerformLayout();
            pnlAnalista.ResumeLayout(false);
            pnlAnalista.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCargo;
        private TextBox txtNome;
        private DateTimePicker dtpDataNasc;
        private CheckBox chkEditar;
        private GroupBox gpbMorada;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmbCargo;
        private Label lblNome;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblID;
        private TextBox txtID;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private Label lblDataNasc;
        private Panel pnlAnalista;
        private TextBox txtLocalidade;
        private TextBox txtCodPostal;
        private TextBox txtRua;
        private TextBox txtProjeto;
        private Label lblProjeto;
        private Button btnCancelar;
        private Button btnOk;
    }
}