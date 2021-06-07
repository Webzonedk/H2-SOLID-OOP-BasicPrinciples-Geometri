using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square : IShape
    {
        #region Fields
        private double sideA;
        #endregion



        #region Properties
        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }
        #endregion



        #region Constructors
        public Square(double sideA)
        {
            this.sideA = sideA;
        }
        #endregion



        #region Methods
        //Just at header to visualize what is being calculated
        public virtual void Header()
        {
            Console.WriteLine("Kvadrat beregning");
        }

        //Needs to be here as it is in the Interface But is unused here, and when it is here, then it is not needed in the inherited classes
        public void CalculateSideC()
        {
        }

        //Calculating the circumference
        public virtual void CalculateCircum()
        {
            double result = SideA * 4;
            Console.WriteLine($"Omkredsen på kvadratet er: {result} cm.");
        }

        //Calculating the square
        public virtual void CalculateSquare()
        {
            double result = SideA * SideA;
            Console.WriteLine($"Arealet af kvadratet er: {result} cm2.");
            Console.WriteLine();

        }
        #endregion
    }
}
