using System;
using System.Collections.Generic;

namespace Geometri
{
    class Program
    {

        static void Main(string[] args)
        {
            //Just adding a bit of space and a welcome message
            StandardMessages.Velcome();

            //The first three squares All is instantiated with the interface as type
            IShape square1 = new Square(5);
            square1.Header();
            square1.CalculateCircum();
            square1.CalculateSquare();

            IShape square2 = new Square(10);
            square2.Header();
            square2.CalculateCircum();
            square2.CalculateSquare();

            IShape square3 = new Square(15);
            square3.Header();
            square3.CalculateCircum();
            square3.CalculateSquare();

            //instantiating and running the rectangle
            IShape rectangle = new Rectangle(5, 10);
            rectangle.Header();
            rectangle.CalculateCircum();
            rectangle.CalculateSquare();

            //instantiating and running the parrelelogram
            IShape parrelelogram = new Parallelogram(5, 10, 20);
            parrelelogram.Header();
            parrelelogram.CalculateCircum();
            parrelelogram.CalculateSquare();

            //instantiating and running the trapez
            IShape trapez = new Trapez(10, 4, 9, 4);
            trapez.Header();
            trapez.CalculateCircum();
            trapez.CalculateSquare();

            //instantiating and running the triangle
            IShape triangle = new Triangle(10, 4, 0);
            triangle.Header();
            triangle.CalculateSideC();
            triangle.CalculateCircum();
            triangle.CalculateSquare();




            //And the short way to show it
            //Creating a list called shapes adding all the IShapes
            List<IShape> shapes = new List<IShape>();
            shapes.Add(square1);
            shapes.Add(square2);
            shapes.Add(square3);
            shapes.Add(rectangle);
            shapes.Add(parrelelogram);
            shapes.Add(trapez);
            shapes.Add(triangle);

            //Just adding a bit of space and a welcome message
            StandardMessages.Velcome();


            //Looping through all shapes in the list running the respective methods in each class
            foreach (IShape shape in shapes)
            {
                shape.Header();
                shape.CalculateSideC();
                shape.CalculateCircum();
                shape.CalculateSquare();
            }

            //Just adding the usual end button
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();
        }
    }
}
