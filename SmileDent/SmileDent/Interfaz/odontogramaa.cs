using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmileDent.Interfaz
{
    public partial class odontogramaa : Form
    {
         static int sum = 0;
         static int izq = 0;
         static int der = 0;
         static int cent = 0;
         static int inf = 0;

        public odontogramaa()
        {
            InitializeComponent();
            
        }

        private void superior_Click(object sender, EventArgs e)
        {
            sum += color(superior, sum);
        }

        private void izquiero_Click(object sender, EventArgs e)
        {
          izq = color(izquiero, izq);
        }

        private void central_Click(object sender, EventArgs e)
        {
           cent += color(central,cent);
        }

        private void derecho_Click(object sender, EventArgs e)
        {
           der += color(derecho,der);
        }

        private void inferior_Click(object sender, EventArgs e)
        {
           inf+= color(inferior,inf);
        }
        private int color(Button button, int cont)
        {
            if (cont == 0)
            {
                button.BackColor = Color.White;
               return  1;
            }
            else if (cont == 1)
            {
                button.BackColor = Color.Black;
                return 1;
            }
            else if (cont == 2)
            {
                button.BackColor = Color.Red;
                return 1;
            }
            else if (cont == 3)
            {
                button.BackColor = Color.Blue;
                return 1;
            }
            else if (cont == 4)
            {
                button.BackgroundImage = Image.FromFile("C:/Users/Ale/Source/Repos/SmileDent/SmileDent/Images/codigo dientes/perdida.png");
                return 1;
            }
            else if (cont == 5)
            {
                button.BackgroundImage = Image.FromFile("C:/Users/Ale/Source/Repos/SmileDent/SmileDent/Images/codigo dientes/extraer.png");
                return 1;
            }
            else if (cont == 6)
            {
                button.BackColor = Color.Orange;
                button.BackgroundImage = null;
                return cont = -6;
            }
            return 0;
        }

    }
}
