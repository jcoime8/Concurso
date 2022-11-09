using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_FacturaElectronica;

namespace Win_FacturaElectronica
{

    public partial class Form1 : Form
    {
        Cls_Cliente objetoCL = new Cls_Cliente();
        private string idCliente = null;
        private bool Editar=false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idCliente = dataGridView1.CurrentRow.Cells["cli_codigo"].Value.ToString();
                objetoCL.eliminar(Convert.ToInt32(idCliente));
                MessageBox.Show("Registro eliminado");
                mostrarClientes();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que quiere editar");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCL.insertarCliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                    MessageBox.Show("insertacion completa");
                    Limpiar();
                    mostrarClientes();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            if (Editar==true)
            {
                try
                {
                    objetoCL.editarCliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, Convert.ToInt32(idCliente));
                    MessageBox.Show("insertacion completa", "Cuadro de confirmacion");
                    Limpiar();
                    mostrarClientes();
                    Editar = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error debido a: " +  ex);
                }
            }
        }

        private void mostrarClientes()
        {
            Cls_Cliente objeto = new Cls_Cliente();
            dataGridView1.DataSource = objeto.mostraCliente(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                textBox1.Text = dataGridView1.CurrentRow.Cells["cli_cedula"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["cli_apellidos"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["cli_nombres"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["cli_direccion"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["cli_fecha_nacimiento"].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells["cli_telefono"].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells["cli_mail"].Value.ToString();
                idCliente = dataGridView1.CurrentRow.Cells["cli_codigo"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que quiere editar");
            }
        }

        private void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
