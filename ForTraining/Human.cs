using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTraining
{
    /// <summary>
    /// Шаблон NPC
    /// </summary>
    class NPC
    {
        private string name = string.Empty; // Имя NPC
        private string _fraction = string.Empty; // Фракция текст
        private int fraction = 0;
 // фракция в цифрах
        private int status = 0; // статус NPC 
        public int hp = 0; // Здоровье NPC

        /// <summary>
        /// Настройка NPC начальные его параметры
        /// </summary>
        /// <param name="name">Имя NPC</param>
        /// <param name="fraction">Фракция NPC</param>
        /// <param name="hp">Здоровье NPC</param>
        public virtual void ConfigNPC(string name, int fraction, int hp)
        {
            this.name = name;
            this.fraction = fraction;
            this.hp = hp;

            SetFraction(fraction);
        }
        
        /// <summary>
        /// Присвоить фракцию
        /// </summary>
        /// <param name="fraction">Номер фракции</param>
        private void SetFraction(int fraction)
        {
            if(fraction == 0)
            {
                this._fraction = "Нейтральный";
                this.status = 0;
            }
            else
            if (fraction == 1)
            {
                this._fraction = "За Альянс!";
                this.status = 1;
            }
            else
            if (fraction == 2)
            {
                this._fraction = "За Орду!";
                this.status = 2;
            }
        }

        /// <summary>
        /// Получить информацию об NPC
        /// </summary>
        public virtual void AboutNPC()
        {
            Console.WriteLine("Меня зовут: " + name);
            Console.WriteLine(_fraction);
            Console.WriteLine("Здоровье NPC: " + hp);
        }

    }

    /// <summary>
    /// Шаблон NPC человек
    /// </summary>
    class Human: NPC
    {
        public override void ConfigNPC(string name, int fraction, int hp)
        {
            base.ConfigNPC(name, fraction, hp);
        }
        public override void AboutNPC()
        {
            base.AboutNPC();
        }
    }

    /// <summary>
    /// Шаблон NPC Орк
    /// </summary>
    class Orc: NPC
    {
        public override void ConfigNPC(string name, int fraction, int hp)
        {
            base.ConfigNPC(name, fraction, hp);
        }
        public override void AboutNPC()
        {
            base.AboutNPC();
        }
    }

    /// <summary>
    /// Шаблон NPC Демон
    /// </summary>
    class Demon: NPC
    {
        public override void ConfigNPC(string name, int fraction, int hp)
        {
            base.ConfigNPC(name, fraction, hp);
        }
        public override void AboutNPC()
        {
            base.AboutNPC();
        }
    }
        
}
