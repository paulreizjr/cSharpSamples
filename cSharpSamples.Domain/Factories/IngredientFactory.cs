using cSharpSamples.Domain.Entities;
using cSharpSamples.Shared.Entities;
using cSharpSamples.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSamples.Domain.Factories
{
    public static class IngredientFactory<T> where T : IIngredient
    {
        public static T MakeProduct()
        {
            return Activator.CreateInstance<T>();
        }

        public static T MakeProduct(string? IngredientName, FruitType FruitType)
        {
            var ret = Activator.CreateInstance(typeof(T), IngredientName, FruitType) ?? MakeProduct();
            return (T)ret;
        }
    }
}
