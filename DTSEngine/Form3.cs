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

    public partial class RunThread : Form
    {
        public bool loaded = false;
        public string Height_0 { get; set; }

        public string Width_0 { get; set; }

        public string Framerate { get; set; }

        public System.Diagnostics.Stopwatch sw_OK_RUN = new System.Diagnostics.Stopwatch();


        public RunThread()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e){}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Height_0 = height.Text; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Width_0 = width.Text; 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Framerate = framerate.Text; 
        }

        public void OK_Click(object sender, EventArgs e)
        {            
            this.DialogResult = DialogResult.OK;
            this.Close();                                  
        }
    }
}
