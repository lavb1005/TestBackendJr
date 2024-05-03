using Business;
using ClassLibrary1.Interface;
using Repository;

namespace Prueba2
{
    public partial class Form1 : Form
    {
        readonly IManEmpleados empleados = new ManEmpleado(new RepoEmpleado());
        readonly IManUsuario usuarios = new ManUsuario(new RepoUsuario());

        public Form1()
        {
            InitializeComponent();
            ListarUsuarios();
        }


        //PROGRAMACIÓN DE MÉTODOS
        private void ListarUsuarios()
        {
            DGVUsuarios.AutoGenerateColumns = false;
            DGVUsuarios.DataSource = usuarios.Listar;
        }
    }
}