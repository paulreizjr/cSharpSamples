using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSamples.Domain.Factories
{
    public abstract class Creator<T>
    {
        public abstract T MakeProduct(T type);
    }
}
