using cSharpSamples.Shared.Enums;

namespace cSharpSamples.Shared.Entities.Fruits{
    public interface IFruit{
        public string FruitName { get; set; }
        public FruitType FruitType { get; set; }
    }
}