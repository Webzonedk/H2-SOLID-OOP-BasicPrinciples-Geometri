using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Parallelogram : Square
    {
        #region Fields
        private double sideB;
        private double angle;
        #endregion



        #region Properties
        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }
        #endregion



        #region Constructors
        public Parallelogram(double sideA, double sideB, double angle) : base(sideA)
        {
            this.sideB = sideB;
            this.angle = angle;
        }
        #endregion



        #region Methods
        //Just at header to visualize what is being calculated
        public override void Header()
        {
            Console.WriteLine("Parrelelogram beregning");
        }

        //Calculating the circumference
        public override void CalculateCircum()
        {
            double tempResult = SideA * 2 + SideB * 2;
            double result = Math.Round(tempResult, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Omkredsen på parrelelogrammet er: {result} cm.");
        }

        //Calculating the square
        public override void CalculateSquare()
        {
            double sinusAngle = Math.Sin(angle);
            double tempRresult = SideA * SideB * sinusAngle;
            double result = Math.Round(tempRresult, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Arealet af parrelelogrammet er: {result} cm2.");
            Console.WriteLine();
        }
        #endregion

    }
}
