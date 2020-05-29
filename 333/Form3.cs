using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _333
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Добрый день, " + Form1.FORMA.Name + " !";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.FORMA.Show();
        }
    }
}
        
    

