using Aplicacion.Datos;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion.Vistas
{
    public partial class Usuario : Form
    {
        readonly IManUsuario manUsuario = new ManUsuario(new RepoUsuario());
        public Usuario()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TbLogin.Text =="" || TbNombre.Text == "" || TbPaterno.Text == "" || TbMaterno.Text == "" || TbSueldo.Text == "")
                MessageBox.Show("Debe de llenar todos los campos","Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (!Regex.IsMatch(TbSueldo.Text, "^[0-9.]+$"))
                    MessageBox.Show("Sueldo ingresado no válido", "Sueldo no válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    empleados empleado = new empleados()
                    {
                        Sueldo = Convert.ToDouble(TbSueldo.Text),
                        FechaIngreso = DateTime.Today,
                    };

                    usuarios usuario = new usuarios()
                    {
                        Login = TbLogin.Text,
                        Nombre = TbNombre.Text,
                        Paterno = TbPaterno.Text,
                        Materno = TbMaterno.Text,
                        empleados = empleado
                    };

                    if (manUsuario.Agregar(usuario))
                    {
                        MessageBox.Show("Se registro correctamente el usuario", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Ocurrió un error al registrar el nuevo usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    }
}
