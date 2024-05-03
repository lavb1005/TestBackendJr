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
    public partial class ActualizarSueldo : Form
    {
        readonly IManEmpleados manEmpleados = new ManEmpleado(new RepoEmpleado());
        readonly empleados empleado = new empleados();

        public ActualizarSueldo(usuarios usuarios)
        {
            InitializeComponent();
            empleado = usuarios.empleados;
            label2.Text = string.Concat(label2.Text, $" {usuarios.Nombre} {usuarios.Paterno} {usuarios.Materno}" );
            label3.Text = string.Concat(label3.Text, $" ${empleado.Sueldo}");
        }

        //========================================================//
        //                Programación de BOTONES                 //
        //========================================================//
        
        //Boton Actualizar
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if(TbSueldo.Text == "")
                MessageBox.Show("Debe de llenar todos los campos","Campos vacíos",MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if(!Regex.IsMatch(TbSueldo.Text, "^[0-9.]+$"))
                    MessageBox.Show("Valor ingresado no válido", "Sueldo no válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    empleado.Sueldo = Convert.ToDouble(TbSueldo.Text);
                    if (manEmpleados.Modificar(empleado))
                    {
                        MessageBox.Show("Se actualizo correctamente el sueldo", "Actualizacion exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Ocurrió un error al actualizar el sueldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Boton Cancelar
        private void BtnCancelar_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    }
}
