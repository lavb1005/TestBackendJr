namespace Aplicacion.Vistas
{
    partial class Usuario
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
            this.TPnlFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.PnlForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbPaterno = new System.Windows.Forms.TextBox();
            this.TbMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbSueldo = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TPnlFormulario.SuspendLayout();
            this.PnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // TPnlFormulario
            // 
            this.TPnlFormulario.ColumnCount = 3;
            this.TPnlFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPnlFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TPnlFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPnlFormulario.Controls.Add(this.PnlForm, 1, 1);
            this.TPnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TPnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.TPnlFormulario.Name = "TPnlFormulario";
            this.TPnlFormulario.RowCount = 3;
            this.TPnlFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPnlFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TPnlFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TPnlFormulario.Size = new System.Drawing.Size(435, 426);
            this.TPnlFormulario.TabIndex = 0;
            // 
            // PnlForm
            // 
            this.PnlForm.Controls.Add(this.BtnCancelar);
            this.PnlForm.Controls.Add(this.label6);
            this.PnlForm.Controls.Add(this.BtnGuardar);
            this.PnlForm.Controls.Add(this.TbSueldo);
            this.PnlForm.Controls.Add(this.label5);
            this.PnlForm.Controls.Add(this.TbMaterno);
            this.PnlForm.Controls.Add(this.TbPaterno);
            this.PnlForm.Controls.Add(this.TbNombre);
            this.PnlForm.Controls.Add(this.label1);
            this.PnlForm.Controls.Add(this.TbLogin);
            this.PnlForm.Controls.Add(this.label2);
            this.PnlForm.Controls.Add(this.label4);
            this.PnlForm.Controls.Add(this.label3);
            this.PnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlForm.Location = new System.Drawing.Point(46, 45);
            this.PnlForm.Name = "PnlForm";
            this.PnlForm.Size = new System.Drawing.Size(342, 334);
            this.PnlForm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paterno";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Materno";
            // 
            // TbLogin
            // 
            this.TbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbLogin.Location = new System.Drawing.Point(137, 65);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(142, 20);
            this.TbLogin.TabIndex = 4;
            // 
            // TbNombre
            // 
            this.TbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbNombre.Location = new System.Drawing.Point(135, 96);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(142, 20);
            this.TbNombre.TabIndex = 5;
            // 
            // TbPaterno
            // 
            this.TbPaterno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbPaterno.Location = new System.Drawing.Point(135, 128);
            this.TbPaterno.Name = "TbPaterno";
            this.TbPaterno.Size = new System.Drawing.Size(142, 20);
            this.TbPaterno.TabIndex = 6;
            // 
            // TbMaterno
            // 
            this.TbMaterno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbMaterno.Location = new System.Drawing.Point(135, 161);
            this.TbMaterno.Name = "TbMaterno";
            this.TbMaterno.Size = new System.Drawing.Size(142, 20);
            this.TbMaterno.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sueldo";
            // 
            // TbSueldo
            // 
            this.TbSueldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbSueldo.Location = new System.Drawing.Point(135, 204);
            this.TbSueldo.Name = "TbSueldo";
            this.TbSueldo.Size = new System.Drawing.Size(142, 20);
            this.TbSueldo.TabIndex = 9;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(48, 274);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nuevo Usuario";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(218, 274);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 426);
            this.Controls.Add(this.TPnlFormulario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.TPnlFormulario.ResumeLayout(false);
            this.PnlForm.ResumeLayout(false);
            this.PnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TPnlFormulario;
        private System.Windows.Forms.Panel PnlForm;
        private System.Windows.Forms.TextBox TbMaterno;
        private System.Windows.Forms.TextBox TbPaterno;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TbSueldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCancelar;
    }
}