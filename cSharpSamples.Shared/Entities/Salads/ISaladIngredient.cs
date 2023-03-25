using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSamples.Shared.Entities.Salads
{
    public interface ISaladIngredient
    {
        IIngredient Ingredient { get; set; }
        int Quantity { get; set; }
    }
}
