using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Violontchel: MusicTool
    {

        public Violontchel() : base()
        {
            this.name = "виолончель";
            this.description = "маленький контрабас», образованного от viola)" +
                " — смычковый музыкальный инструмент с 4-мя струнами, настроенными по квинтам";
        }

        public override string Sound()
        {
            string output = base.Sound();
            output += "\n- Строй струн виолончели: C, G, d, a («до», «соль» большой октавы, «ре», «ля» малой октавы)," +
                " то есть на октаву ниже альта. Диапазон виолончели, благодаря разработанной" +
                " технике игры на струне a, очень широк — от C («до» большой октавы) до a4 («ля» четвёртой октавы)" +
                " и выше. Ноты пишутся в басовом, теноровом и скрипичном ключах соответственно действительному звучанию";
            return output;

        }

        public virtual string Show()
        {
            return "Музыкальный инструмень называется  " + this.name;
        }

        public virtual string Histoty()
        {
            return "Появление виолончели относится к началу XVI века. Первоначально она применялась как басовый инструмент" +
                " для сопровождения пения (или исполнения на инструменте более высокого регистра)." +
                " Существовали многочисленные разновидности виолончели, отличавшиеся друг от друга размерами, " +
                "количеством струн, строем (чаще всего встречалась настройка на тон ниже современной).";
        }

        public override string ToString()
        {
            return this.Sound() + this.Show() + "\n" + this.Desc() + "\n" + this.Histoty();
        }



    }
}
