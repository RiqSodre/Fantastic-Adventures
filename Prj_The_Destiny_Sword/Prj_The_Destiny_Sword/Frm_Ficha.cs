using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Prj_The_Destiny_Sword
{
    public partial class frm_Ficha : Form
    {
        Personagem personagem = new Personagem();
        Ficha atr = new Ficha();

        Raca[] racas;
        Classe[] classes;
        int count = 0;
        
        PictureBox[] photos = new PictureBox[9];

        public frm_Ficha()
        {
            InitializeComponent();

            racas = atr.RacaPersonagem();
            classes = atr.ClassePersonagem();

            //Combobox de raças.
            string[] nomesRacas = new string[racas.Length];

            for (int i = 0; i < racas.Length; i++)
                nomesRacas[i] = racas[i].nome;
            
            cb_Raca.DataSource = nomesRacas;

            //Combobox de classes.
            string[] nomesClasses = new string[classes.Length];

            for (int i = 0; i < classes.Length; i++)
                nomesClasses[i] = classes[i].nome;
            
            cb_Classe.DataSource = nomesClasses;

        }
        //Gera número aleatórios de um Dado - D6.
        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            randNum.Next();

            txt_VidaD.Text = randNum.Next(1, 6).ToString();
            txt_ManaD.Text = randNum.Next(1, 6).ToString();
            txt_ForcaD.Text = randNum.Next(1, 6).ToString();
            txt_DefesaD.Text = randNum.Next(1, 6).ToString();
            txt_IntD.Text = randNum.Next(1, 6).ToString();
            txt_AgilidadeD.Text = randNum.Next(1, 6).ToString();
            txt_SorteD.Text = randNum.Next(1, 6).ToString();

            count++;

            if (count == 1)
                btn_CalAtributos.Enabled = true;

            Desabilita();
        }
        //Gera uma combobox com todas as Raças existentes no jogo.
        private void cb_Raca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Raca selecionada = racas[cb_Raca.SelectedIndex];
            personagem.racaBase = selecionada;
            AtualizarAtributosPersonagem();
            Desabilita();
        }
        //Gera uma combobox com todas as Classes existentes no jogo.
        private void cb_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classe selecionada = classes[cb_Classe.SelectedIndex];
            personagem.classeBase = selecionada;
            AtualizarAtributosPersonagem();
            Desabilita();
        }
        //Método que atualiza os atributos bases.
        private void AtualizarAtributosPersonagem()
        {
            personagem.atributos = personagem.racaBase.atributos;
            
            personagem.atributos.vida += personagem.classeBase.atributos.vida;
            personagem.atributos.mana += personagem.classeBase.atributos.mana;
            personagem.atributos.forca += personagem.classeBase.atributos.forca;
            personagem.atributos.defesa += personagem.classeBase.atributos.defesa;
            personagem.atributos.inteligencia += personagem.classeBase.atributos.inteligencia;
            personagem.atributos.agilidade += personagem.classeBase.atributos.agilidade;
            personagem.atributos.sorte += personagem.classeBase.atributos.sorte;

            //Atualizando os campos.
            txt_VidaB.Text = personagem.atributos.vida.ToString();
            txt_ManaB.Text = personagem.atributos.mana.ToString();
            txt_ForcaB.Text = personagem.atributos.forca.ToString();
            txt_DefesaB.Text = personagem.atributos.defesa.ToString();
            txt_IntB.Text = personagem.atributos.inteligencia.ToString();
            txt_AgilidadeB.Text = personagem.atributos.agilidade.ToString();
            txt_SorteB.Text = personagem.atributos.sorte.ToString();
        }
        //Método gera o total dos atributos dos personagens.
        private void TotalAtributosPersonagem()
        {
            //Váriaveis de total.
            int t0, t1, t2, t3, t4, t5, t6;
            string totalV, totalM;
          
            //Vida.
            int vidaB = int.Parse(txt_VidaB.Text);
            int vidaD = int.Parse(txt_VidaD.Text);
            t0 = vidaB + vidaD;
            txt_VidaR.Text = t0.ToString();
            //Mana.
            int manaB = int.Parse(txt_ManaB.Text);
            int manaD = int.Parse(txt_ManaD.Text);
            t1 = manaB + manaD;
            txt_ManaR.Text = t1.ToString();
            //Força.
            int forcaB = int.Parse(txt_ForcaB.Text);
            int forcaD = int.Parse(txt_ForcaD.Text);
            t2 = forcaB + forcaD;
            txt_ForcaR.Text = t2.ToString();
            //Defesa.
            int defesaB = int.Parse(txt_DefesaB.Text);
            int defesaD = int.Parse(txt_DefesaD.Text);
            t3 = defesaB + defesaD;
            txt_DefesaR.Text = t3.ToString();
            //Inteligência.
            int intB = int.Parse(txt_VidaB.Text);
            int intD = int.Parse(txt_VidaD.Text);
            t4 = intB + intD;
            txt_IntR.Text = t4.ToString();
            //Agilidade.
            int agilidadeB = int.Parse(txt_AgilidadeB.Text);
            int agilidadeD = int.Parse(txt_AgilidadeD.Text);
            t5 = agilidadeB + agilidadeD;
            txt_AgilidadeR.Text = t5.ToString();
            //Sorte.
            int sorteB = int.Parse(txt_SorteB.Text);
            int sorteD = int.Parse(txt_SorteD.Text);
            t6 = sorteB + sorteD;
            txt_SorteR.Text = t6.ToString();

            //Barra de vida.
            totalV = txt_VidaR.Text;
            pb_Vida.Maximum = int.Parse(txt_VidaR.Text);
            pb_Vida.Value = int.Parse(txt_VidaR.Text);
            lbl_pbVida.Text = (txt_VidaR.Text + "/" + totalV);

            //Barra de mana.
            totalM = txt_ManaR.Text;
            pb_Mana.Maximum = int.Parse(txt_ManaR.Text);
            pb_Mana.Value = int.Parse(txt_ManaR.Text);
            lbl_pbMana.Text = (txt_ManaR.Text + "/" + totalM);

        }
        //Método que mostra a foto da Raça.
        private void cb_Raca_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_Classe_SelectedValueChanged(null, null);
        }
        //Método que mostra a foto da Classe.
        private void cb_Classe_SelectedValueChanged(object sender, EventArgs e)
        {
            //Humano.
            if (cb_Raca.SelectedIndex == 0)
            {
                if (cb_Classe.SelectedIndex == 0)
                    pb_Picture.BackgroundImage = Properties.Resources.human_warrior;
                else if (cb_Classe.SelectedIndex == 1)
                    pb_Picture.BackgroundImage = Properties.Resources.human_hunter;
                else if (cb_Classe.SelectedIndex == 2)
                    pb_Picture.BackgroundImage = Properties.Resources.human_rogue;
                else
                    pb_Picture.BackgroundImage = Properties.Resources.human_mage;
            }
            //Anão.
            if (cb_Raca.SelectedIndex == 1)
            {
                if (cb_Classe.SelectedIndex == 0)
                    pb_Picture.BackgroundImage = Properties.Resources.dwarf_warrior;
                else if (cb_Classe.SelectedIndex == 1)
                    pb_Picture.BackgroundImage = Properties.Resources.dwarf_hunter;
                else if (cb_Classe.SelectedIndex == 2)
                    pb_Picture.BackgroundImage = Properties.Resources.dwarf_rogue;
                else
                    pb_Picture.BackgroundImage = Properties.Resources.dwarf_mage;
            }
            //Elfo.
            if (cb_Raca.SelectedIndex == 2)
            {
                if (cb_Classe.SelectedIndex == 0)
                    pb_Picture.BackgroundImage = Properties.Resources.elf_warrior;
                else if (cb_Classe.SelectedIndex == 1)
                    pb_Picture.BackgroundImage = Properties.Resources.elf_hunter;
                else if (cb_Classe.SelectedIndex == 2)
                    pb_Picture.BackgroundImage = Properties.Resources.elf_rogue;
                else
                    pb_Picture.BackgroundImage = Properties.Resources.elf_mage;
            }
            //Orc.
            if(cb_Raca.SelectedIndex == 3)
            {
                if (cb_Classe.SelectedIndex == 0)
                    pb_Picture.BackgroundImage = Properties.Resources.orc_warrior;
                else if (cb_Classe.SelectedIndex == 1)
                    pb_Picture.BackgroundImage = Properties.Resources.orc_hunter;
                else if (cb_Classe.SelectedIndex == 2)
                    pb_Picture.BackgroundImage = Properties.Resources.orc_rogue;
                else
                    pb_Picture.BackgroundImage = Properties.Resources.orc_mage;
            }
        }
        //Calcula os atributos.
        private void btn_CalAtributos_Click(object sender, EventArgs e)
        {
            TotalAtributosPersonagem();
            Desabilita();
            btn_Jogo.Enabled = true;
        }
        //Desabilita botões.
        private void Desabilita()
        {
            if (count == 3)
            {
                btn_Jogo.Enabled = true;
                btn_Gerar.Enabled = false;
                btn_CalAtributos.Enabled = false;
                cb_Raca.Enabled = false;
                cb_Classe.Enabled = false;

                TotalAtributosPersonagem();
            }
        }
        //Carrega a tela do jogo.
        private void btn_Jogo_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_Nome.Text))
            {
                MessageBox.Show("Você ainda não tem um nome, viajante.","Espere um pouco...",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Frm_Jogo jogo = new Frm_Jogo();
                jogo.Show();
            }
        }
        //Método que fecha o formulário.
        private void frm_Ficha_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Ficha ficha = new frm_Ficha();
            Application.Exit();
        }
    }
}
