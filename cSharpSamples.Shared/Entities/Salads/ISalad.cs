using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSamples.Shared.Entities.Salads
{
    public interface ISalad
    {
        string getReceipe();
        void addIngredient(ISaladIngredient ingredient);
    }
}
