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
        public int vida_monstro;
        public int forca_monstro;
    }

    //Monstro.
    public struct Monstro
    {
        public string nome_monstro;
        public AtributosMonstro atr_monstro;
    }

    //Todos os Monstros.
    class Monstros
    {
        //Vetor com todos os tipos de monstros.
        public Monstro[] Monsters()
        {
            Monstro lobos = new Monstro();
            Monstro hienas = new Monstro();

            Monstro troll = new Monstro();
            Monstro umber = new Monstro();

            Monstro wyrvern = new Monstro();
            Monstro drag = new Monstro();

            lobos.nome_monstro = "Lobos da montanha";
            lobos.atr_monstro.vida_monstro = 7;
            lobos.atr_monstro.forca_monstro = 3;
    
            hienas.nome_monstro = "Hienas da colina";
            hienas.atr_monstro.vida_monstro = 7;
            hienas.atr_monstro.forca_monstro = 2;

            troll.nome_monstro = "Troll";
            troll.atr_monstro.vida_monstro = 8;
            troll.atr_monstro.forca_monstro = 2;

            umber.nome_monstro = "Umber";
            umber.atr_monstro.vida_monstro = 8;
            umber.atr_monstro.forca_monstro = 3;

            wyrvern.nome_monstro = "Wyrvern";
            wyrvern.atr_monstro.vida_monstro = 9;
            wyrvern.atr_monstro.forca_monstro = 4;

            drag.nome_monstro = "Dragão de Esqueletos";
            drag.atr_monstro.vida_monstro = 10;
            drag.atr_monstro.forca_monstro = 4;

            Monstro[] monsters = new Monstro[6];
            monsters[0] = lobos;
            monsters[1] = hienas;
            monsters[2] = troll;
            monsters[3] = umber;
            monsters[4] = wyrvern;
            monsters[5] = drag;

            return monsters;
        }
    }
}
