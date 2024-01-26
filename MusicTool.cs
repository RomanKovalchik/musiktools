using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class MusicTool
    {
        protected string name;
        protected string description;

       

        public virtual string Sound(){ 
            return "Данный музыкальный инструмент создает следующий звук: ";
        }

        public virtual string Show()
        {
            return "Музыкальный инструмень называется  ";
        }

        public virtual string Desc()
        {
            return "Инструмент включает следующие элементы: ";
        }

        public virtual string Histoty()
        {
            return "";
        }

    }
}
