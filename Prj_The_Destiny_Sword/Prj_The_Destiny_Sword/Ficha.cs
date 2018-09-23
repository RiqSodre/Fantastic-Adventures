using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_The_Destiny_Sword
{
    //Struct Atributos.
    public struct Atributos
    {
        public int vida;
        public int mana;
        public int forca;
        public int defesa;
        public int inteligencia;
        public int agilidade;
        public int sorte;
    }

    //Strtuc de Raça.
    public struct Raca
    {
        public string nome;
        public Atributos atributos;
    }

    //Struct de Classe.
    public struct Classe
    {
        public string nome;
        public Atributos atributos;
    }

    //Strtuc de Atributos base.
    public struct Personagem
    {
        public Classe classeBase;
        public Raca racaBase;
        public Atributos atributos;
    }

    //Ficha dos Personagens.
    public class Ficha
    {
        //Função com vetor de Raças dos Personagens.
        public Raca[] RacaPersonagem()
        {
            Raca human = new Raca();
            Raca dwarf = new Raca();
            Raca elf = new Raca();
            Raca orc = new Raca();

            #region Human
            human.nome = "Humano";
            human.atributos.vida = 3;
            human.atributos.mana = 2;
            human.atributos.forca = 2;
            human.atributos.defesa = 2;
            human.atributos.inteligencia = 3;
            human.atributos.agilidade = 2;
            human.atributos.sorte = 3;
            #endregion

            #region Dwarf
            dwarf.nome = "Anão";
            dwarf.atributos.vida = 2;
            dwarf.atributos.mana = 2;
            dwarf.atributos.forca = 3;
            dwarf.atributos.defesa = 2;
            dwarf.atributos.inteligencia = 3;
            dwarf.atributos.agilidade = 1;
            dwarf.atributos.sorte = 1;
            #endregion

            #region Elf
            elf.nome = "Elfo";
            elf.atributos.vida = 3;
            elf.atributos.mana = 2;
            elf.atributos.forca = 1;
            elf.atributos.defesa = 1;
            elf.atributos.inteligencia = 3;
            elf.atributos.agilidade = 3;
            elf.atributos.sorte = 2;
            #endregion

            #region Orc
            orc.nome = "Orc";
            orc.atributos.vida = 3;
            orc.atributos.mana = 2;
            orc.atributos.forca = 1;
            orc.atributos.defesa = 1;
            orc.atributos.inteligencia = 1;
            orc.atributos.agilidade = 3;
            orc.atributos.sorte = 2;
            #endregion
            
            Raca[] raca = new Raca[4];
            raca[0] = human;
            raca[1] = dwarf;
            raca[2] = elf;
            raca[3] = orc;

            return raca;
        }

        //Função com vetor de Classes dos Personagens.
        public Classe[] ClassePersonagem()
        {
            Classe warrior = new Classe();
            Classe hunter = new Classe();
            Classe rogue = new Classe();
            Classe mage = new Classe();

            #region Warrior
            warrior.nome = "Guerreiro";
            warrior.atributos.vida = 2;
            warrior.atributos.mana = 1;
            warrior.atributos.forca = 2;
            warrior.atributos.defesa = 2;
            warrior.atributos.inteligencia = 2;
            warrior.atributos.agilidade = 2;
            warrior.atributos.sorte = 2;
            #endregion

            #region Hunter
            hunter.nome = "Caçador";
            hunter.atributos.vida = 2;
            hunter.atributos.mana = 2;
            hunter.atributos.forca = 4;
            hunter.atributos.defesa = 2;
            hunter.atributos.inteligencia = 1;
            hunter.atributos.agilidade = 2;
            hunter.atributos.sorte = 2;
            #endregion

            #region Rogue
            rogue.nome = "Ladino";
            rogue.atributos.vida = 1;
            rogue.atributos.mana = 2;
            rogue.atributos.forca = 2;
            rogue.atributos.defesa = 2;
            rogue.atributos.inteligencia = 2;
            rogue.atributos.agilidade = 3;
            rogue.atributos.sorte = 2;
            #endregion

            #region Mage
            mage.nome = "Mago";
            mage.atributos.vida = 1;
            mage.atributos.mana = 3;
            mage.atributos.forca = 1;
            mage.atributos.defesa = 1;
            mage.atributos.inteligencia = 3;
            mage.atributos.agilidade = 3;
            mage.atributos.sorte = 2;
            #endregion

            Classe[] classe = new Classe[4];
            classe[0] = warrior;
            classe[1] = hunter;
            classe[2] = rogue;
            classe[3] = mage;

            return classe;
        }
    }
}
