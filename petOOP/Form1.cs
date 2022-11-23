using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pet pet;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string type = textBox2.Text;
            decimal age = 0.0m;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type) && decimal.TryParse(textBox3.Text, out age))
            {
                pet = new Pet(name, type, age);
            }
            else {
                MessageBox.Show("please correct your input", "invalid input");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("pet`s name: " + pet.Name);
                listBox1.Items.Add("pet`s type: " + pet.Type);
                listBox1.Items.Add("pet`s age: " + pet.Age);


            }
            catch (NullReferenceException){
                MessageBox.Show("please enter the data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
