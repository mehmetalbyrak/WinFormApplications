using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{

    public class Colors
    {

        // public string ColorType { get; set; }
        // public int ColorBrightness { get; set; }

        public Colors(string colorType, int colorBrightness)
        {
            ColorType = colorType;
            ColorBrightness = colorBrightness;
        }

        public Colors()
        {
            
        }

        private string colorType { get; set; }
        private int colorBrightness { get; set; }

        public virtual string ColorType
        {
            get
            {
                return colorType;
            }

            set
            {
                switch (value.ToUpper())
                {
                    case "YELLOW":
                        colorType = value;
                        break;
                    case "BLACK":
                        colorType = value;
                        break;
                    case "BLUE":
                        colorType = value;
                        break;
                    default:
                        MessageBox.Show("Bad Color :d ");
                        return;
                }
                colorType = value;
            }
        }

        public int ColorBrightness
        {
            get
            {
                return colorBrightness;
            }

            set
            {
                if (value >= 5 && value <= 10)
                {
                    colorBrightness = value;
                }
                else
                {
                    MessageBox.Show(" wtf :d bad brightness ");
                    return;
                }

                colorBrightness = value;
                
            }
        }

        public string DescribeColor()
        {
            return $"\r\nMy color is {ColorType} \r\nThe brightness is " +
                $"{ColorBrightness.ToString()}";
        }

        public string CompareColors()
        {
            const int DEFAULT_BRIGHTNESS = 5;

            if (colorBrightness == DEFAULT_BRIGHTNESS)
            {
                return $"\r\nThe color of {colorType} has the default brightness of {DEFAULT_BRIGHTNESS}";
            }else if (colorBrightness < DEFAULT_BRIGHTNESS)
            {
                return $"\r\nThe color of {colorType} is less bright than default {DEFAULT_BRIGHTNESS}";
            }
            else
            {
                return $"\r\nThe color of {colorType} is more bright than default {DEFAULT_BRIGHTNESS}";
            }
        }

    }
}
