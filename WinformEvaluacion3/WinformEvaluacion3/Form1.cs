using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformEvaluacion3.datos;
using WinformEvaluacion3.modelo;

namespace WinformEvaluacion3
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato = new Usuario();
        public Form1()
        {
            InitializeComponent();
            Iniciar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbmenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Iniciar(){
            tabla = new DataTable();
            tabla.Columns.Add("nombre");
            tabla.Columns.Add("apellido");
            tabla.Columns.Add("menu");
            tabla.Columns.Add("mesa");
            grilla.DataSource = tabla;
        
        }
        private void Guardar() {
            Usuariomodel modelo = new Usuariomodel()
            {
                Nombre=txtnombre.Text,
                Apellido=txtapellido.Text,
                Menu=cmbmenu.Text,
                Mesa=cmbmesa.Text


            };

            dato.Guardar(modelo);

        }
        private void Consultar()
        {
            foreach(var item in dato.Consultar())
            {

                DataRow fila = tabla.NewRow();
                fila["nombre"] = item.Nombre;
                fila["apellido"] = item.Apellido;
                fila["menu"] = item.Menu;
                fila["mesa"] = item.Mesa;
                tabla.Rows.Add(fila);

            }
        }
         private void Limpiar()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            cmbmenu.FormatString = "";
            cmbmesa.FormatString = "";

        }
    }
}
