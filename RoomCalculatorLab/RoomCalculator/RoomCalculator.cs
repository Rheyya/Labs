using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalculatorLab
{
    internal class RoomCalculator
    {
        public decimal Length { get; set; }
        public decimal Width { get; set; }

        public decimal CalculateArea()
        {
           decimal area = Length * Width;
            return area;
        }
        public decimal CalculatePerimeter()
        {
            decimal perimeter = 2 * (Length + Width);
            return perimeter;
        }

        public string ClassifyRoom()
        {
            decimal area = CalculateArea();
            if (area <= 250)
            {
                return "Small";
            }
            else if (area > 250 && area < 650)
            {
                return "Medium";
            }
            else
            {
                return "Large";
            }
        }
    }
}
