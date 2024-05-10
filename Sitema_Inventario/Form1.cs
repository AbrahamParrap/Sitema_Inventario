using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sitema_Inventario
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void inventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tiendaDataSet.Inventario' table. You can move, or remove it, as needed.
            this.inventarioTableAdapter.Fill(this.tiendaDataSet.Inventario);

        }

        private void button1_Click(object sender, EventArgs e)
        {

       

            this.inventarioTableAdapter.Insertar(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            this.inventarioTableAdapter.Fill(this.tiendaDataSet.Inventario);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.inventarioBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.inventarioBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.inventarioBindingSource.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.inventarioBindingSource.MoveLast();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.inventarioTableAdapter.Borrar(Convert.ToInt32(textBox1.Text));
            this.inventarioTableAdapter.Fill(this.tiendaDataSet.Inventario);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.inventarioTableAdapter.Modificar(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            this.inventarioTableAdapter.Fill(this.tiendaDataSet.Inventario);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.inventarioTableAdapter.FillBy(this.tiendaDataSet.Inventario, Convert.ToInt32(textBox1.Text));
        }
    }
}
