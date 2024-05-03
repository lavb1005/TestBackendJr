namespace Aplicacion
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
            this.TPnlContenido = new System.Windows.Forms.TableLayoutPanel();
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.PnlBotones = new System.Windows.Forms.Panel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnPrimeros = new System.Windows.Forms.Button();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.PnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // TPnlContenido
            // 
            this.TPnlContenido.ColumnCount = 3;
            this.TPnlContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TPnlContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TPnlContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TPnlContenido.Controls.Add(this.DGVUsuarios, 1, 1);
            this.TPnlContenido.Controls.Add(this.PnlBotones, 1, 0);
            this.TPnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TPnlContenido.Location = new System.Drawing.Point(0, 0);
            this.TPnlContenido.Name = "TPnlContenido";
            this.TPnlContenido.RowCount = 3;
            this.TPnlContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TPnlContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TPnlContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TPnlContenido.Size = new System.Drawing.Size(800, 450);
            this.TPnlContenido.TabIndex = 0;
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.Login,
            this.Nombre,
            this.Paterno,
            this.Materno});
            this.DGVUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUsuarios.Location = new System.Drawing.Point(123, 70);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.Size = new System.Drawing.Size(554, 309);
            this.DGVUsuarios.TabIndex = 0;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnActualizar.Location = new System.Drawing.Point(231, 9);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(110, 42);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "Actualizar Sueldo";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // PnlBotones
            // 
            this.PnlBotones.Controls.Add(this.BtnPrimeros);
            this.PnlBotones.Controls.Add(this.BtnNuevo);
            this.PnlBotones.Controls.Add(this.BtnActualizar);
            this.PnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBotones.Location = new System.Drawing.Point(123, 3);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Size = new System.Drawing.Size(554, 61);
            this.PnlBotones.TabIndex = 2;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNuevo.Location = new System.Drawing.Point(44, 9);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(110, 42);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "Nuevo Usuario";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnPrimeros
            // 
            this.BtnPrimeros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPrimeros.Location = new System.Drawing.Point(401, 9);
            this.BtnPrimeros.Name = "BtnPrimeros";
            this.BtnPrimeros.Size = new System.Drawing.Size(110, 42);
            this.BtnPrimeros.TabIndex = 3;
            this.BtnPrimeros.Text = "Primeros 10";
            this.BtnPrimeros.UseVisualStyleBackColor = true;
            this.BtnPrimeros.Click += new System.EventHandler(this.BtnPrimeros_Click);
            // 
            // userId
            // 
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "userID";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Paterno
            // 
            this.Paterno.DataPropertyName = "Paterno";
            this.Paterno.HeaderText = "Paterno";
            this.Paterno.Name = "Paterno";
            this.Paterno.ReadOnly = true;
            // 
            // Materno
            // 
            this.Materno.DataPropertyName = "Materno";
            this.Materno.HeaderText = "Materno";
            this.Materno.Name = "Materno";
            this.Materno.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TPnlContenido);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TPnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.PnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TPnlContenido;
        private System.Windows.Forms.DataGridView DGVUsuarios;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Panel PnlBotones;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnPrimeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materno;
    }
}

