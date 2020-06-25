using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFractCSharp_test1
{
    public class TFractException:Exception
    {
        public TFractException(string message) : base(message)
        {

        }
    }
}
