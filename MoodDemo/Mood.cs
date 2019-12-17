using System;
using System.Drawing;


namespace MoodDemo
{
    class Mood
    {
        AColor red, green, blue;

        public Mood(double rStart, double rIncrement, double gStart, double gIncrement, double bStart, double bIncrement)
        {
            red = new AColor(rStart, rIncrement);
            green = new AColor(gStart, gIncrement);
            blue = new AColor(bStart, bIncrement);
        }
        public Color Color
        {
            get
            {
                return Color.FromArgb(red.Value, green.Value, blue.Value);
            }
        }
        class AColor
        {
            double value, increment;
            public AColor(double value, double increment)
            {
                this.value = value;this.increment = increment;
            }
            public byte Value
            {
                get
                {
                    if (increment + value > 1 || increment + value < 0)
                        increment *= -1;
                    value += increment;
                    return (byte)(value * 256);
                }
            }
        }
    }
}
