using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    //An interface for the shapes with empty methods equal to those in the classes included within the Interface
    public interface IShape
    {
        public void Header();

        public void CalculateSideC();

        public void CalculateCircum();

        public void CalculateSquare();
    }
}
