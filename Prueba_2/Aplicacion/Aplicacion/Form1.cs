using Aplicacion.Vistas;
using Business;
using Interface;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class Form1 : Form
    {
        readonly IManUsuario usuario = new ManUsuario(new RepoUsuario());
        public Form1()
        {
            InitializeComponent();
            ListarUsuarios();
        }

        //========================================================//
        //                Programación de BOTONES                 //
        //========================================================//

        //Boton Actualizar
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if(DGVUsuarios.SelectedRows.Count<0)
                MessageBox.Show("Debe de selecionar un usuario", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                ActualizarSueldo frm = new ActualizarSueldo(usuario.Listar.FirstOrDefault(x => x.userId == Convert.ToInt32(DGVUsuarios.CurrentRow.Cells[0].Value.ToString())));
                if (frm.ShowDialog() == DialogResult.OK)
                    ListarUsuarios();
            }
        }

        //Boton Nuevo Usuario
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Usuario frm = new Usuario();
            if (frm.ShowDialog() == DialogResult.OK)
                ListarUsuarios();
        }
        
        //Boton Primeros 10
        private void BtnPrimeros_Click(object sender, EventArgs e) => TomarPrimeros10();


        //========================================================//
        //                Programación de METODOS                 //
        //========================================================//
        private void ListarUsuarios()
        {
            DGVUsuarios.AutoGenerateColumns = false;
            DGVUsuarios.DataSource = usuario.Listar;
        }
        private void TomarPrimeros10()
        {
            DGVUsuarios.AutoGenerateColumns = false;
            DGVUsuarios.DataSource = usuario.Listar.Take(10).ToList();
        }
    }
}
