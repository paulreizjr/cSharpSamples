using cSharpSamples.Domain.Entities;
using cSharpSamples.Shared.Entities.Fruits;
using cSharpSamples.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSamples.Domain.DTO
{
    public class FruitDTO : IEngredient
    {
        public string IngredientName { get; set; }
        public IngredientType IngredientType { get; set; }
        public FruitType FruitType { get; set; }

        public FruitDTO(Fruit fruit) 
        {
            IngredientName = fruit.IngredientName;
            FruitType = fruit.FruitType;
        }
        
    }
}
