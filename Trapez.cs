using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Trapez : Square
    {
        #region Fields
        private double sideB;
        private double sideC;
        private double sideD;
        #endregion



        #region Properties

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }
        public double SideD
        {
            get { return sideD; }
            set { sideD = value; }
        }

        #endregion



        #region Constructors

        public Trapez(double sideA, double sideB, double sideC, double sideD) : base(sideA)
        {
            this.sideB = sideB;
            this.sideC = sideC;
            this.sideD = sideD;
        }
        #endregion



        #region Methods
        //Just at header to visualize what is being calculated
        public override void Header()
        {
            Console.WriteLine("Trapez beregning");
        }

        //Calculating the circumference
        public override void CalculateCircum()
        {
            double tempResult = SideA + SideB + SideC + SideD;
            double result = Math.Round(tempResult, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Omkredsen på trapezzen er: {result} cm.");
        }

        //Calculating the square
        public override void CalculateSquare()//Be aware that the wrong numbers will give a 0 or NaN (10, 5, 9, 4) (10, 6, 9, 4) Validation is needed to make it work proberly
        {
            double s = (SideA + SideB - SideC + SideD) / 2;
            double h = 2 / (SideA - SideC) * Math.Sqrt(s * (s - SideA + SideC) * (s - SideB) * (s - SideD));
            double tempResult = 0.5 * (SideA + SideC) * h;
            double result = Math.Round(tempResult, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Arealet af trapezzen er: {result} cm2.");
            Console.WriteLine();
        }
        #endregion
    }
}
