using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {

            Promedio nota = new Promedio();

            nota.nombre = txt_nombre.Text;
            nota.numeroCuenta = Convert.ToInt32(txt_numerocuenta.Text);
            nota.nota1 = Convert.ToInt32(txt_nota1.Text);
            nota.nota2 = Convert.ToInt32(txt_nota2.Text);
            nota.nota3 = Convert.ToInt32(txt_nota3.Text);
            nota.nota4 = Convert.ToInt32(txt_nota4.Text);


            MessageBox.Show(nota.nombrecuenta());
            MessageBox.Show(nota.nota());

        }


    }

}
