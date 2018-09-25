//////////////////////////////////////////
//                                      //
// >nome-do-projeto: The Emerald Sword  //
// >author: Ricardo Henrique Sodré      //
// >github: github.com/RiqSodre         //
// >data: 17/09/2018                    //
//                                      //
//////////////////////////////////////////

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
using System.Media;

namespace Prj_The_Destiny_Sword
{
    public partial class Frm_Jogo : Form
    {
        Ficha player = new Ficha();
        Personagem personagem = new Personagem();

        Monstro monstro = new Monstro();
        Inimigo inimigo = new Inimigo();

        //Vetores.
        Raca[] racas;
        Classe[] classes;
        Tipo[] monstros;
    
        //Váriaveis contadoras.
        int contGeral = 0;
        int contCalculo = 0;

        bool op1 = false;
        bool op2 = false;

        public Frm_Jogo()
        {
            InitializeComponent();

            racas = player.RacaPersonagem();
            classes = player.ClassePersonagem();
            monstros = monstro.TipoInimigo();

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

            ThemeSong(true);
            Botoes(false);
        }
        //Gera número aleatórios de um Dado - D6.
        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            if (contGeral == 0)
                MessageBox.Show("Você pode girar os dados de atributos apenas três vezes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Random randNum = new Random();
            randNum.Next();

            txt_VidaD.Text = randNum.Next(1, 6).ToString();
            txt_ManaD.Text = randNum.Next(1, 6).ToString();
            txt_ForcaD.Text = randNum.Next(1, 6).ToString();
            txt_DefesaD.Text = randNum.Next(1, 6).ToString();
            txt_IntD.Text = randNum.Next(1, 6).ToString();
            txt_AgilidadeD.Text = randNum.Next(1, 6).ToString();
            txt_SorteD.Text = randNum.Next(1, 6).ToString();

            contGeral++;

            if (contGeral == 1)
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

            ////INIMIGOS
            inimigo.atrInimigo = inimigo.tipoInimigo.atrTipo;

            inimigo.atrInimigo.vida += inimigo.tipoInimigo.atrTipo.vida;
            inimigo.atrInimigo.forca += inimigo.tipoInimigo.atrTipo.forca;
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
            if (cb_Raca.SelectedIndex == 3)
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
            if (contCalculo == 0)
                MessageBox.Show("Calcule seus atributos sempre que rolar os dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            TotalAtributosPersonagem();
            Desabilita();
            btn_Jogo.Enabled = true;
            contCalculo++;
        }
        //Desabilita botões.
        private void Desabilita()
        {
            if (contGeral == 3)
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
            string nomePlayer = txt_Nome.Text.ToUpper();

            if (String.IsNullOrEmpty(txt_Nome.Text))
            {
                MessageBox.Show("Você ainda não tem um nome.", "Espere um pouco...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Botoes(true);

            btn_Gerar.Enabled = false;
            btn_CalAtributos.Enabled = false;
            txt_Nome.Enabled = false;
            cb_Classe.Enabled = false;
            cb_Raca.Enabled = false;

            MessageBox.Show(string.Format("Você, um {0} muito habilidoso, estava indo em direção a cidade principal do continente de Calah, era uma longa caminhada com seu cavalo que estava exausto, no céu um portal se abre, de lá algo misterioso e verde cai, e você não sabe se é uma ilusão da sua cabeça ou algo real. A curiosidade é maior que a missão anteriormente dada, e você segue até onde o item caira, um antigo castelo que hoje é apenas ruinas e histórias. Com um grande assobio seu cavalo começa a correr até o local da queda e sua aventura se inicia!", cb_Classe.SelectedItem), "Vamos lá", MessageBoxButtons.OK);

            lbl_Historia.Text = string.Format("Com sua montaria muito cansada, vocês chegam ao objetivo com sucesso. Seu cavalo vai até a fonte para saciar a sede,você desce dele e fica em frente de um castelo enorme, feito em sua parte que restou de pedras, possuia também alguns detalhes de plantas trepadeiras, que de certa forma, desvaloriza o castelo. O que mais chama atenção, de fato, é a porta de madeira, com detalhes e batente de prata(talvez por conta da superstição de que monstro temem prata); olhando atentamente, você vê uma das janelas de umas das torres aberta, porém, para chegar lá, é necessário mais agilidade que o normal; A sua intuição diz que você deve explorar mais, todavia os mistérios que te aguardam são igualmente interessantes.");

            btn_Jogo.Enabled = false;
        }
        //Método que fecha o formulário.
        private void frm_Ficha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Jogo ficha = new Frm_Jogo();
            Application.Exit();
        }
        //Botão Ataque.
        private void btn_Atacar_Click(object sender, EventArgs e)
        {
            //    int atk = 5, result;
            //    string totalV = txt_VidaR.Text;

            //    result = pb_Vida.Value - atk;

            //    if (result <= 0)
            //    {
            //        pb_Vida.Value = 0;
            //        MessageBox.Show("Você morreu!", "Game Over", MessageBoxButtons.OK);
            //        btn_Atacar.Enabled = false;
            //    }
            //    else if (result <= 1)
            //    {
            //        pb_Vida.Value = result;
            //        ModifyProgressBarColor.SetState(pb_Vida, 2);
            //    }
            //    else
            //    {
            //        pb_Vida.Value = result;
            //    }

            //    lbl_pbVida.Text = (result.ToString() + "/" + totalV);
            MessageBox.Show("Ainda não funciona.", "Opa..", MessageBoxButtons.OK);
        }
        //BackgroundSong.
        private void ThemeSong(bool play)
        {
            SoundPlayer songtheme = new SoundPlayer(@"C:\Users\Lufus\Desktop\The-Destiny-Sword\Prj_The_Destiny_Sword\Songs\theme.wav");
            if (play == true)
            {
                songtheme.PlayLooping();
                songtheme.Play();
            }
            else
            {
                songtheme.Stop();
            }
        }
        //Escolhas
        private void btn_Escolha_Click(object sender, EventArgs e)
        {
            int agility = int.Parse(txt_AgilidadeR.Text);

            //Resultado OPÇÃO 1.
            if (op1 == true)
            {
                if(agility < 5)
                {
                    lbl_Historia.Text = "Você tentou escalar as gigantes paredes do castelo mas sua agilidade não foi o suficiente";
                    pb_Vida.Value = 0;
                    lbl_pbVida.Text = ("0/" + txt_VidaR.Text);
                    MessageBox.Show("Você morreu.", "GAME OVER", MessageBoxButtons.OK);
                }
                else
                {
                    Luta(inimigo);
                }
                btn_op1.Enabled = false;
                btn_op2.Enabled = false;
            }
            //Resultado OPÇÃO 2.
            if (op2 == true)
            {
                int luck = int.Parse(txt_SorteR.Text);
                
                if(luck < 6)
                {
                    lbl_Historia.Text = "Você escolheu examinar a área ao redor do castelo e se deparou com alguns Esqueletos que estavam de guardas no local. Sua sorte não estava ao seu favor e eles acabaram te vendo, desesperado pelo grande número de guardas-esqueletos ao teu redor você tenta correr, mas tropeça em uma pedra que estava no caminho. Ao cair, você visualiza os esqueletos se aproximando com espadas e escudos. Você morreu.";
                }
                else
                {
                    lbl_Historia.Text = "Você teve uma sorte absurda em examinar o castelo enquanto os guardas estavam de férias. A porta que leva a entrada da sala de Esmeralda estava destrancada, e você consegue entrar sem nenhum problema. Você entra em um enorme salão e lá esta a Espada de Esmeralda. Você completou sua missão.";
                }
                btn_op1.Enabled = false;
                btn_op2.Enabled = false;
            }
        }
        //OPÇÃO 1.
        private void btn_op1_Click(object sender, EventArgs e)
        {
            lbl_Historia.Text = "Escalar e entrar pela janela.";
            op1 = true;
            op2 = false;
        }
        //OPÇÃO 2.
        private void btn_op2_Click(object sender, EventArgs e)
        {
            lbl_Historia.Text = "Examinar ao redor do castelo.";
            op2 = true;
            op1 = false;
        }
        //Função Luta.
        private int Luta(Inimigo monster) {
            int dano = int.Parse(txt_ForcaR.Text);
            
            
            inimigo.atrInimigo.vida -= dano;

            if (inimigo.atrInimigo.vida <= 0)
            {
                lbl_Historia.Text = string.Format("Você usa toda sua agilidade e habilidade para escalar as paredes do castelo. Sua escalada é impressionantemente rápida e eficaz. Você chega até a janela aberta e entra. Ao entrar você se deparara com um esqueleto munido de uma espada e um escudo simples. Então vocês começam a lutar. A batalha foi rápida e silenciosa, você conseguiu destruilo em questão de segundos. Ele nem ao menos notou sua presença enquanto você estrava pela janela. Você adentrou o local como uma luz na escuridão, e com um único ataque eliminou seu oponente. O Esqueleto morreu.");
                return 1;
            }
            personagem.atributos.vida -= inimigo.atrInimigo.forca;
            if(personagem.atributos.vida <= 0)
            {
                lbl_Historia.Text = "O esqueleto percebeu sua presença e andou em tua direção para lhe atacar. Você ficou estranhamente assustado ao ver aquela criatura esqueletica se aproximando. Você não conseguiu se segurar e manter suas forças para passar pela janela, seus braços fraquejaram e você caiu da janela do castelo. Você morreu.";
                return 1;
            }
            else
            {
                return Luta(inimigo);
            }
        }
        //Magia.
        private void btn_Magia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda não funciona.", "Opa..", MessageBoxButtons.OK);
        }

        //Habilita/Desabilita botão.
        private void Botoes(bool estado)
        {
            if(estado == true)
            {
                btn_Atacar.Enabled = true;
                btn_Magia.Enabled = true;
                btn_Escolha.Enabled = true;
                btn_op1.Enabled = true;
                btn_op2.Enabled = true;
            }
            else
            {
                btn_Atacar.Enabled = false;
                btn_Magia.Enabled = false;
                btn_Escolha.Enabled = false;
                btn_op1.Enabled = false;
                btn_op2.Enabled = false;
            }
        }
    }

    //Modifica a cor da progressbar.
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
