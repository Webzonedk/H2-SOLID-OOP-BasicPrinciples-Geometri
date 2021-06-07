using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Rectangle : Square
    {
        #region Fields
        private double sideB;
        #endregion



        #region Properties
        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        #endregion



        #region Constructors
        public Rectangle(double sideA, double sideB) : base(sideA)
        {
            this.sideB = sideB;
        }
        #endregion



        #region Methods
        //Just at header to visualize what is being calculated
        public override void Header()
        {
            Console.WriteLine("Rectangle beregning");
        }

        //Calculating the circumference
        public override void CalculateCircum()
        {
            double tempResult = SideA * 2 + SideB * 2;
            double result = Math.Round(tempResult, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Omkredsen på rektangelet er: {result} cm.");
        }

        //Calculating the square
        public override void CalculateSquare()
        {
            double tempResult = SideA * SideB;
            double result = Math.Round(tempResult, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Arealet af rektangelet er: {result} cm2.");
            Console.WriteLine();
        }
        #endregion

    }
}
