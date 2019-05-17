using SmileDent.Interfaz;
using System;
using System.Windows.Forms;
namespace SmileDent
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
          
            catalogoDientes catatalogo = new catalogoDientes();
            catatalogo.Show();
        }
    }
}
