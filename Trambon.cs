using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Trambon: MusicTool
    {
        public Trambon() : base()
        {
            this.name = "трамбон";
            this.description = "медный духовой музыкальный инструмент, отличительной" +
                " особенностью которого является наличие передвижной кулисы," +
                " вместо обычно используемых вентилей, для получения хроматического звукоряда.";
        }

        public override string Sound()
        {
            string output = base.Sound();
            output += "\n- Диапазон тромбона — от G1 (соль контроктавы) до F² (фа второй октавы)" +
                " с пропуском звуков между Bb и E (си-бемоль контроктавы — ми большой октавы)." +
                " Этот промежуток (кроме ноты B, то есть си контроктавы) заполняется при наличии квартвентиля.";
            return output;

        }

        public virtual string Show()
        {
            return "Музыкальный инструмень называется  " + this.name;
        }
        public override string Desc()
        {

            return this.description;
        }

        public virtual string Histoty()
        {
            return "В античной культуре, также встречаются предшественник инструмента. В Древней Греции – сальпинкс, прямая труба из металла," +
                " в Риме — tuba directa, священная труба с низким звучанием. Во время раскопок Помпеи " +
                "(согласно историческим сведениям, древнегреческий город перестал существовать под пеплом вулкана Везувий в 79 году до нашей эры)," +
                " были найдены несколько инструментов из бронзы, похожих на тромбон, скорее всего это были трубы «большого» размера," +
                " которые находились в футлярах, имели золотые мундштуки и были украшены драгоценными камнями. " +
                " в переводе с итальянского языка «Trombone» переводится как «большая труба».";
        }

        public override string ToString()
        {
            return this.Sound() + this.Show() + "\n" + this.Desc() + "\n" + this.Histoty();
        }

    }  
}
