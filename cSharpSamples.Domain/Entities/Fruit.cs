using cSharpSamples.Shared.Entities;
using cSharpSamples.Shared.Enums;
using cSharpSamples.Shared.Entities.Fruits;
using cSharpSamples.Domain.DTO;

namespace cSharpSamples.Domain.Entities
{
    public class Fruit : Entity, IEngredient, IEquatable<Fruit>
    {
        private string? _IngredientName;
        private IngredientType _IngredientType = IngredientType.Fruit;
        private FruitType _FruitType;

        public Fruit() { }  

        public Fruit(string? IngredientName, FruitType FruitType)
        {
            _IngredientName = IngredientName;
            _FruitType = FruitType;
        }

        public string IngredientName { get => _IngredientName ?? string.Empty; set => _IngredientName = value; }
        public IngredientType IngredientType { get; set; }
        public FruitType FruitType { get => _FruitType; set => _FruitType = value; }


        //Overloading just equality operators is not enough. Under different circumstances, all of the following can be called:
        //1. object.Equals and object.GetHashCode
        //2. IEquatable<T>.Equals (optional, allows avoiding boxing)
        //3. operator == and operator != (optional, allows using operators)

        public bool Equals(Fruit? other)
        {
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(other, this)) return true;
            return string.Equals(_IngredientName, other.IngredientName);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return true;
            return Equals(obj as Fruit);
        }

        public override int GetHashCode()
        {
            return IngredientName?.GetHashCode() ?? 0;
        }

        public static bool operator ==(Fruit left, Fruit right)
        {
            return left.IngredientName == right.IngredientName && left.FruitType == right.FruitType;
        }

        public static bool operator !=(Fruit left, Fruit right)
        {
            return left.IngredientName != right.IngredientName || left.FruitType != right.FruitType;
        }



        public static implicit operator FruitDTO(Fruit fruit)
        {
            return new FruitDTO(fruit);
        }

        public static explicit operator String(Fruit fruit) 
        { 
            return fruit.IngredientName;
        }

        public override string ToString()
        {
            return this.IngredientName;
        }

    }
}