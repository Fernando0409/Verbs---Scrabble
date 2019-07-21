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
    public partial class Categorias : UserControl
    {
        private int category = 0;

        public Categorias()
        {
            InitializeComponent();
        }

        private void btnInfinitive_Click(object sender, EventArgs e)
        {
            category = 1;

            VerbsScrabble.verbsForm1.Show();
            VerbsScrabble.categorias1.Hide();
            VerbsScrabble.inicio1.Hide();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            category = 2;

            VerbsScrabble.verbsForm1.Show();
            VerbsScrabble.categorias1.Hide();
            VerbsScrabble.inicio1.Hide();
        }

        private void btnPP_Click(object sender, EventArgs e)
        {
            category = 3;

            VerbsScrabble.verbsForm1.Show();
            VerbsScrabble.categorias1.Hide();
            VerbsScrabble.inicio1.Hide();
        }

        public int getCategory() => category;
    }
}
