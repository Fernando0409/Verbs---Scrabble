using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verbs_Scrabble
{
    public partial class Inicio : UserControl
    {
        public Inicio() => InitializeComponent();

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if(txtNickName.Text == "")
            {
                MessageBox.Show("Ingresa un valor en el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNickName.Focus();
            }
            else
            {
                txtNickName.Text = "";
                txtNickName.Focus();

                VerbsScrabble.inicio1.Hide();
                VerbsScrabble.categorias1.Show();
            }
        }
    }
}
