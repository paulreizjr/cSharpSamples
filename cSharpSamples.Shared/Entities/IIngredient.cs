using cSharpSamples.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSamples.Shared.Entities
{
    public interface IIngredient
    {
        public string IngredientName { get; set; }
        public IngredientType IngredientType { get; set; }
    }
}
