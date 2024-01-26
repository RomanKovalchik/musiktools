using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Skripka : MusicTool
    {

        public Skripka() : base()
        {
            this.name = "Скрипка";
            this.description = "Представляет собой деревянный корпус со струнами и смычек";
        }

        public override string Sound()
        {
            string output = base.Sound();
            output += "\n- который некоторым действует на нервы;\n- который некоторым нравится";
            return output;

        }

        public virtual string Show()
        {
            return "Музыкальный инструмень называется  " + this.name;
        }

        public override string Desc() { 
        
        return this.description;    
        }

        public virtual string Histoty()
        {
            return "Скрипка, альт и виолончель были впервые изготовлены в начале 16 века в Италии." +
                " Самые ранние свидетельства их существования находятся на картинах Гауденцио Феррари " +
                "1530-х годов, хотя у инструментов Феррари было всего три струны. В Музыкальной академии," +
                " трактате, написанном в 1556 году Филибером Жамбом де Фером, дается четкое описание" +
                " скрипичного семейства во многом таким, каким мы знаем его сегодня.\r\n\r\nСкрипки," +
                " вероятно, произошли от ряда других струнных инструментов 15-16 веков, включая виель," +
                " ребек и лиру да браччо. История смычковых струнных инструментов в Европе восходит к 9" +
                " веку, когда появилась византийская лира (или лура, греческое: λύρα).";
        }


    }
}
