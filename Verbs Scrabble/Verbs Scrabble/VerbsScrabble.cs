using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Verbs_Scrabble
{
    public partial class VerbsScrabble : Form
    {
        public VerbsScrabble() => InitializeComponent();

        private void VerbsScrabble_Load(object sender, EventArgs e)
        {
            playMusic();
            inicio1.Show();
            categorias1.Hide();
            tutorial1.Hide();
            contacto1.Hide();
            creditos1.Hide();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            inicio1.Show();
            categorias1.Hide();
            tutorial1.Hide();
            contacto1.Hide();
            creditos1.Hide();
            verbsForm1.Hide();
        }

        private void btn_Tutorial_Click(object sender, EventArgs e)
        {
            inicio1.Hide();
            categorias1.Hide();
            tutorial1.Show();
            contacto1.Hide();
            creditos1.Hide();
            verbsForm1.Hide();
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            inicio1.Hide();
            categorias1.Hide();
            tutorial1.Hide();
            contacto1.Show();
            creditos1.Hide();
            verbsForm1.Hide();
        }

        private void btn_Credits_Click(object sender, EventArgs e)
        {
            inicio1.Hide();
            categorias1.Hide();
            tutorial1.Hide();
            contacto1.Hide();
            creditos1.Show();
            verbsForm1.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e) => Application.Exit();

        private void playMusic()
        {
            SoundPlayer sound = new SoundPlayer();
            bool play = true;

            if(play)
            {
                try
                {
                    sound.SoundLocation = Application.StartupPath + @"\Song\Before I Forget.wav";
                    sound.PlayLooping();
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se encontro la canción especificada en la ruta: "+e.Message, "Notificación", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    play = false;
                }
            }
        }
    }
}
