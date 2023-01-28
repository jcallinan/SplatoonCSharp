using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplatoonCSharp
{
    public enum InkColor
    {
        Pink,
        Orange,
        Green,
        Blue,
        Yellow
    }
    public class Player
    {
        //attributes
        public string Name { get; set; }
        public InkColor Color { get; set; } = InkColor.Pink;

        public void setInkColor()
        {
            //set InkColor to a random color
            Array colors = Enum.GetValues(typeof(InkColor));
            Random rand = new Random();
            this.Color = (InkColor)colors.GetValue(rand.Next(colors.Length));
        }
    }
}
