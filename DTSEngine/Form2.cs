using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTCEngine
{
    public partial class object_creation : Form
    {
        public string Output_Primitive { get; set; }
        public string Output_1_X { get; set; }
        public string Output_1_Y { get; set; }
        public string Output_2_X { get; set; }
        public string Output_2_Y { get; set; }
        public string Output_3_X { get; set; }
        public string Output_3_Y { get; set; }
        public string Output_4_X { get; set; }
        public string Output_4_Y { get; set; }
        
        public object_creation()
        {
            InitializeComponent();
            Output_Primitive = Primitive_Type.Text;                        
        }        
        private void primitive_value_Load(object sender, EventArgs e){}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // primitive type
        {
            Output_Primitive = Primitive_Type.Text;  
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // vertex 1 x component
        {
            Output_1_X = textBox1.Text; 
        }

        private void textBox5_TextChanged(object sender, EventArgs e) // vertex 1 y component
        {
            Output_1_Y = textBox5.Text; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // vertex 2 x component
        {
            Output_2_X = textBox2.Text; 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Output_2_Y = textBox3.Text; 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Output_3_X = textBox4.Text; 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Output_3_Y = textBox6.Text; 
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Output_4_X = textBox7.Text;          
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Output_4_Y = textBox8.Text;
        }
        private void label15_Click(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
