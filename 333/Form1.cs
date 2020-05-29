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
    public partial class Form1 : Form
    {
        
        
            public static Form1 FORMA { get; set; }

            public static  Users USER { get; set; }

            Model1 db = new Model1();
            public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно ввести логин и пароль! ");
                return;
            }
            Users usr = db.Users.Find(textBox1.Text);

            if ((usr != null) && (usr.psw == textBox2.Text))
            {
                USER = usr;

                FORMA = this;

                if (usr.role == "Директор")
                {
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
                else if (usr.role == "Менеджер")
                {
                    Form3 frm = new Form3();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Роли {usr.role} в системе нет!");
                    return;
                }
            }
            else
            {
                MessageBox.Show($"Пользователь с таким логином и паролем нет!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            FORMA = this;
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        
    
    

