using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_The_Destiny_Sword
{
    //Atributos dos Monstros.
    public struct AtributosMonstro
    {
        public int vida;
        public int forca;
    }

    public struct Tipo
    {
        public string nome;
        public AtributosMonstro atrTipo;
    }

    //Monstro.
    public struct Inimigo
    {
        public Tipo tipoInimigo;
        public AtributosMonstro atrInimigo;
    }

    //Todos os Monstros.
    public class Monstro
    {
        //Vetor com todos os tipos de monstros.
        public Tipo[] TipoInimigo()
        {
            Tipo wolf = new Tipo();
            Tipo skeleton = new Tipo();
            Tipo troll = new Tipo();
            Tipo liche = new Tipo();
            Tipo griffin = new Tipo();
            Tipo dragon = new Tipo();

            wolf.nome = "Lobo grande";
            wolf.atrTipo.vida = 7;
            wolf.atrTipo.forca = 3;
            skeleton.nome = "Esqueleto";
            skeleton.atrTipo.vida = 8;
            skeleton.atrTipo.forca = 2;
            troll.nome = "Troll";
            troll.atrTipo.vida = 8;
            troll.atrTipo.forca = 2;
            liche.nome = "Liche";
            liche.atrTipo.vida = 8;
            liche.atrTipo.forca = 3;
            griffin.nome = "Grifo Real";
            griffin.atrTipo.vida = 9;
            griffin.atrTipo.forca = 4;
            dragon.nome = "Dragão de Esmeralda";
            dragon.atrTipo.vida = 10;
            dragon.atrTipo.forca = 4;

            Tipo[] monsters = new Tipo[6];
            monsters[0] = wolf;
            monsters[1] = skeleton;
            monsters[2] = troll;
            monsters[3] = liche;
            monsters[4] = griffin;
            monsters[5] = dragon;

            return monsters;
        }
    }
}
