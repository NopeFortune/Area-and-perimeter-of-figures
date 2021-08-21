using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class SquareException : Exception
    {
        public SquareException(string message) : base(message)
        {

        }
    }
}
