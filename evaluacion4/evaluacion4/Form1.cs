using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacion4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv.Rows.Remove(dgv.CurrentRow);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgv);
            fila.Cells[0].Value = txtID.Text;
            fila.Cells[1].Value = txtnombre.Text;
            fila.Cells[2].Value = txtprecio.Text;

            dgv.Rows.Add(fila);

            txtID.Text = "";
            txtnombre.Text = "";
            txtprecio.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
