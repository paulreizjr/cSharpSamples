using cSharpSamples.Shared.Enums;

namespace cSharpSamples.Shared.Entities.Fruits{
    public interface IEngredient : IIngredient{
        public FruitType FruitType { get; set; }
    }
}