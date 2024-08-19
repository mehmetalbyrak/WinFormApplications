using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{
    public class SpecialColors : Colors
    {
        public int SpecialBrightness { get; set; }

        private string colorType;

        public override string ColorType
        {
            get
            {
                return colorType;
            }
            set
            {
                if (value == "WHITE")
                {
                    colorType = value;
                }
            }
        }
    }
}
