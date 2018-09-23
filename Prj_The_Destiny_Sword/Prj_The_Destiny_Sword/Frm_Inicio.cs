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

namespace Prj_The_Destiny_Sword
{
    public partial class Frm_Inicio : Form
    {
        public Frm_Inicio()
        {
            InitializeComponent();
            BackgroundSong(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Jogo ficha = new Frm_Jogo();
            ficha.Show();
            Hide();
            BackgroundSong(false);
        }

        private void BackgroundSong(bool play)
        {
            SoundPlayer background = new SoundPlayer(@"C:\Users\Lufus\Desktop\The-Destiny-Sword\Prj_The_Destiny_Sword\Prj_The_Destiny_Sword\Songs\background.wav");
            if (play == true)
            {
                background.PlayLooping();
                background.Play();
            }
            else
            {
                background.Stop();
            }
        }
    }
}
