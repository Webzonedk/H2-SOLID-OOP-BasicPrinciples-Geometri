using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Shape1
    {

        #region fields
        private string name;

        #endregion

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Shape1(string name)
        {
            this.name = name;
        }

        public virtual double CalculateCircum()
        {
            double result = 0;
            return result;
        }
        public virtual double CalculateSquare()
        {
            double result = 0;
            return result;
        }

    }
}
