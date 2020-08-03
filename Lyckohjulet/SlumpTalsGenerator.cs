using System;
using System.Collections.Generic;
using System.Text;

namespace Lyckohjulet
{
    public class SlumpTalsGenerator
    {
        Random slumpaTal = new Random();

        public int slumpatTal { get  {return slumpaTal.Next(1,11); }
        }
    }
}
