using cSharpSamples.Shared.Entities;
using cSharpSamples.Shared.Entities.Fruits;
using cSharpSamples.Shared.Entities.Salads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSamples.Domain.Entities
{
    internal class FruitSalad : Entity, ISalad
    {
        private List<ISaladIngredient> _Engredients;
        public FruitSalad(List<ISaladIngredient> engredients) 
        { 
            _Engredients = engredients ?? new();
        }

        public void addIngredient(ISaladIngredient ingredient)
        {
            _Engredients.Add(ingredient);
        }

        public string getReceipe()
        {
            throw new NotImplementedException();
        }
    }
}
