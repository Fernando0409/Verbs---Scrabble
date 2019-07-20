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
    public partial class Contacto : UserControl
    {
        public Contacto()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == ""  || txtSugerence.Text == "")
            {
                MessageBox.Show("Se detecto que uno de los campos se encuentran vacios, rellenelos", "Notificación",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
            }
            else
            {
                txtEmail.Text = "";
                txtSugerence.Text = "";
                MessageBox.Show("Gracias por tu comentario, trabajamos contantemente para tu satisfaccion",
                    "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}