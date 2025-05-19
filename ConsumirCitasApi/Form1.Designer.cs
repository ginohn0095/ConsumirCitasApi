using System;
using System.Windows.Forms;



namespace ConsumirCitasApi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;



        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlLogin = new Panel();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUsuario = new Label();
            lblPassword = new Label();
            pnlCRUD = new Panel();
            txtIDCita = new TextBox();
            labelidcita = new Label();
            txtEstado = new TextBox();
            txtConsultorio = new TextBox();
            txtDoctor = new TextBox();
            txtPaciente = new TextBox();
            dtpFechaCita = new DateTimePicker();
            btnCrear = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvCitas = new DataGridView();
            lblPaciente = new Label();
            lblDoctor = new Label();
            lblConsultorio = new Label();
            lblFecha = new Label();
            lblEstado = new Label();
            pnlLogin.SuspendLayout();
            pnlCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lblUsuario);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Location = new Point(20, 20);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(300, 150);
            pnlLogin.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(100, 20);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(180, 35);
            txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 59);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(180, 35);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(100, 100);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 47);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.Click += btnLogin_Click_1;
            // 
            // lblUsuario
            // 
            lblUsuario.Location = new Point(10, 20);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(90, 35);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(10, 60);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 37);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña:";
            // 
            // pnlCRUD
            // 
            pnlCRUD.Controls.Add(txtIDCita);
            pnlCRUD.Controls.Add(labelidcita);
            pnlCRUD.Controls.Add(txtEstado);
            pnlCRUD.Controls.Add(txtConsultorio);
            pnlCRUD.Controls.Add(txtDoctor);
            pnlCRUD.Controls.Add(txtPaciente);
            pnlCRUD.Controls.Add(dtpFechaCita);
            pnlCRUD.Controls.Add(btnCrear);
            pnlCRUD.Controls.Add(btnActualizar);
            pnlCRUD.Controls.Add(btnEliminar);
            pnlCRUD.Controls.Add(dgvCitas);
            pnlCRUD.Controls.Add(lblPaciente);
            pnlCRUD.Controls.Add(lblDoctor);
            pnlCRUD.Controls.Add(lblConsultorio);
            pnlCRUD.Controls.Add(lblFecha);
            pnlCRUD.Controls.Add(lblEstado);
            pnlCRUD.Enabled = false;
            pnlCRUD.Location = new Point(12, 191);
            pnlCRUD.Name = "pnlCRUD";
            pnlCRUD.Size = new Size(1022, 631);
            pnlCRUD.TabIndex = 1;
            // 
            // txtIDCita
            // 
            txtIDCita.Location = new Point(140, 20);
            txtIDCita.Name = "txtIDCita";
            txtIDCita.Size = new Size(180, 35);
            txtIDCita.TabIndex = 18;
            // 
            // labelidcita
            // 
            labelidcita.Location = new Point(18, 23);
            labelidcita.Name = "labelidcita";
            labelidcita.Size = new Size(104, 32);
            labelidcita.TabIndex = 17;
            labelidcita.Text = "IDCita:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(140, 228);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(180, 35);
            txtEstado.TabIndex = 16;
            // 
            // txtConsultorio
            // 
            txtConsultorio.Location = new Point(140, 146);
            txtConsultorio.Name = "txtConsultorio";
            txtConsultorio.Size = new Size(180, 35);
            txtConsultorio.TabIndex = 15;
            // 
            // txtDoctor
            // 
            txtDoctor.Location = new Point(140, 105);
            txtDoctor.Name = "txtDoctor";
            txtDoctor.Size = new Size(180, 35);
            txtDoctor.TabIndex = 14;
            // 
            // txtPaciente
            // 
            txtPaciente.Location = new Point(140, 64);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(180, 35);
            txtPaciente.TabIndex = 5;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Location = new Point(140, 187);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(180, 35);
            dtpFechaCita.TabIndex = 4;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(612, 13);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(122, 51);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear";
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(612, 70);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(122, 48);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(612, 125);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 45);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvCitas
            // 
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.ColumnHeadersHeight = 40;
            dgvCitas.Location = new Point(18, 279);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.RowHeadersWidth = 72;
            dgvCitas.Size = new Size(969, 320);
            dgvCitas.TabIndex = 8;
    
            // 
            // lblPaciente
            // 
            lblPaciente.Location = new Point(19, 67);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(104, 32);
            lblPaciente.TabIndex = 9;
            lblPaciente.Text = "Paciente:";
            // 
            // lblDoctor
            // 
            lblDoctor.Location = new Point(19, 108);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(90, 32);
            lblDoctor.TabIndex = 10;
            lblDoctor.Text = "Doctor:";
            // 
            // lblConsultorio
            // 
            lblConsultorio.Location = new Point(19, 150);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.Size = new Size(104, 32);
            lblConsultorio.TabIndex = 11;
            lblConsultorio.Text = "Consultorio:";
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(24, 190);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(84, 32);
            lblFecha.TabIndex = 12;
            lblFecha.Text = "Fecha:";
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(18, 226);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(104, 37);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Estado:";
            // 
            // Form1
            // 
            ClientSize = new Size(1186, 834);
            Controls.Add(pnlLogin);
            Controls.Add(pnlCRUD);
            Name = "Form1";
            Text = "Sistema de Citas Médicas";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlCRUD.ResumeLayout(false);
            pnlCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;

        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstado;
        private TextBox txtEstado;
        private TextBox txtConsultorio;
        private TextBox txtDoctor;
        private TextBox txtPaciente;
        private TextBox txtIDCita;
        private Label labelidcita;
    }
}
