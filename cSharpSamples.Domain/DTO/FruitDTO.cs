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
    public class FruitDTO : IFruit
    {
        public string? FruitName { get; set; }

        public FruitType FruitType { get; set; }

        public FruitDTO(Fruit fruit) 
        {
            FruitName = fruit.FruitName;
            FruitType = fruit.FruitType;
        }
        
    }
}
