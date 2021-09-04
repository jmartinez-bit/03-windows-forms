
namespace Lab03
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.chkAutenticacion = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBaseDeDatos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(39, 61);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(221, 22);
            this.txtServidor.TabIndex = 1;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConectar.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConectar.Location = new System.Drawing.Point(116, 226);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(93, 40);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // chkAutenticacion
            // 
            this.chkAutenticacion.AutoSize = true;
            this.chkAutenticacion.Checked = true;
            this.chkAutenticacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutenticacion.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutenticacion.Location = new System.Drawing.Point(39, 161);
            this.chkAutenticacion.Name = "chkAutenticacion";
            this.chkAutenticacion.Size = new System.Drawing.Size(192, 23);
            this.chkAutenticacion.TabIndex = 3;
            this.chkAutenticacion.Text = "Autenticación Integrada";
            this.chkAutenticacion.UseVisualStyleBackColor = true;
            this.chkAutenticacion.CheckedChanged += new System.EventHandler(this.chkAutenticacion_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(318, 61);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Base de Datos";
            // 
            // txtBaseDeDatos
            // 
            this.txtBaseDeDatos.Location = new System.Drawing.Point(39, 118);
            this.txtBaseDeDatos.Name = "txtBaseDeDatos";
            this.txtBaseDeDatos.Size = new System.Drawing.Size(221, 22);
            this.txtBaseDeDatos.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contraseña";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(318, 118);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(221, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // btnEstado
            // 
            this.btnEstado.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.Location = new System.Drawing.Point(234, 226);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(75, 40);
            this.btnEstado.TabIndex = 2;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(332, 226);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(122, 40);
            this.btnDesconectar.TabIndex = 2;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(219, 286);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(112, 37);
            this.btnPersona.TabIndex = 4;
            this.btnPersona.Text = "Personas";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(606, 350);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.chkAutenticacion);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtBaseDeDatos);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.CheckBox chkAutenticacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaseDeDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnPersona;
    }
}

