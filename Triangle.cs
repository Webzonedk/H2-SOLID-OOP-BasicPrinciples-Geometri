using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Triangle : IShape
    {
        #region Fields
        private double sideA;
        private double sideB;
        private double sideC;
        #endregion



        #region Properties
        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }


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

        #endregion



        #region Constructors
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        #endregion



        #region Methods

        //Just at header to visualize what is being calculated
        public void Header()
        {
            Console.WriteLine("Retvinklet trekant beregning");
        }

        //Calculating the third side to be able to calculate the circum
        public void CalculateSideC()//Virtual is not needed here as there is no inheritance from this class
        {
            double sideCPow = Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
            double tempResult = Math.Sqrt(sideCPow);
            double result = Math.Round(tempResult, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Hypotenusen på trekanten er via Pythagoras beregnet til at være: {result} cm.");
        }

        //Calculating the circumference
        public virtual void CalculateCircum()
        {
            double sideCPow = Math.Pow(SideA, 2) + Math.Pow(SideB, 2);//Calculating side c, using Pyhagoras
            SideC = Math.Sqrt(sideCPow);
            double tempResult = SideA + SideB + SideC;
            double result = Math.Round(tempResult, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Omkredsen på trekanten er: {result} cm.");
        }

        //Calculating the square
        public virtual void CalculateSquare()
        {
            double tempResult = 0.5 * SideA * SideB;
            double result = Math.Round(tempResult, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Arealet af trekanten er: {result} cm2.");
            Console.WriteLine();
        }
        #endregion
    }
}
