namespace Prueba2
{
    partial class Form1
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
            TbContenido = new TableLayoutPanel();
            DGVUsuarios = new DataGridView();
            TbContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).BeginInit();
            SuspendLayout();
            // 
            // TbContenido
            // 
            TbContenido.ColumnCount = 3;
            TbContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            TbContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            TbContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            TbContenido.Controls.Add(DGVUsuarios, 1, 1);
            TbContenido.Dock = DockStyle.Fill;
            TbContenido.Location = new Point(0, 0);
            TbContenido.Name = "TbContenido";
            TbContenido.RowCount = 3;
            TbContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            TbContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            TbContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            TbContenido.Size = new Size(800, 450);
            TbContenido.TabIndex = 0;
            // 
            // DGVUsuarios
            // 
            DGVUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuarios.Dock = DockStyle.Fill;
            DGVUsuarios.Location = new Point(123, 70);
            DGVUsuarios.Name = "DGVUsuarios";
            DGVUsuarios.RowTemplate.Height = 25;
            DGVUsuarios.Size = new Size(554, 309);
            DGVUsuarios.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TbContenido);
            Name = "Form1";
            Text = "Form1";
            TbContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TbContenido;
        private DataGridView DGVUsuarios;
    }
}