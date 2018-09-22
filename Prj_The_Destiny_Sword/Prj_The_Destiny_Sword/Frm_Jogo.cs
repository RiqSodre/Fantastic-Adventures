using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_The_Destiny_Sword
{
    public partial class Frm_Jogo : Form
    {
        Timer timer = new Timer();
        int i = -1;
        string mensagem = "";

        public Frm_Jogo()
        {
            InitializeComponent();

            mensagem = "A história se inicia quando um jovem aventureiro decide que vai conquistar a espada do destino.";
            ExibeMensagem(mensagem);
        }

       public void ExibeMensagem(string msg)
        {
            timer.Stop();
            i = -1;
            lbl_Historia.Text = "";
            mensagem = msg;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tamanho = mensagem.Length;
            i += 1;
            if(i == tamanho)
            {
                timer1.Stop();
                i = -1;
            }
            else
            {
                lbl_Historia.Text = lbl_Historia.Text + mensagem;
            }
        }
    }
}
