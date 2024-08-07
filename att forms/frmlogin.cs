using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace att_forms
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String senha = textBox2.Text;  

            if(user == "admin")
            {
               if(senha == "admin")
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    frmlogin frmlogin = new frmlogin();
                    frmlogin.Hide();
                }
                else
                {
                    MessageBox.Show("A senha nao coincide com o login");
                }
               
            }
            else
            {
                MessageBox.Show("O login nao coincide com nenhum login registrado");
            }

            
        }
    }
}
