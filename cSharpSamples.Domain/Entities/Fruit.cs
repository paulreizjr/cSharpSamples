using cSharpSamples.Shared.Entities;
using cSharpSamples.Shared.Enums;
using cSharpSamples.Shared.Entities.Fruits;
using cSharpSamples.Domain.DTO;

namespace cSharpSamples.Domain.Entities
{
    public class Fruit : Entity, IFruit, IEquatable<Fruit>
    {
        private string? _FruitName;
        private FruitType _FruitType;

        public Fruit(string? FruitName, FruitType FruitType)
        {
            _FruitName = FruitName;
            _FruitType = FruitType;
        }

        public string FruitName { get => _FruitName ?? string.Empty; set => _FruitName = value; }
        public FruitType FruitType { get => _FruitType; set => _FruitType = value; }


        //Overloading just equality operators is not enough. Under different circumstances, all of the following can be called:
        //1. object.Equals and object.GetHashCode
        //2. IEquatable<T>.Equals (optional, allows avoiding boxing)
        //3. operator == and operator != (optional, allows using operators)

        public bool Equals(Fruit? other)
        {
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(other, this)) return true;
            return string.Equals(_FruitName, other.FruitName);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return true;
            return Equals(obj as Fruit);
        }

        public override int GetHashCode()
        {
            return _FruitName?.GetHashCode() ?? 0;
        }

        public static bool operator ==(Fruit left, Fruit right)
        {
            return left.FruitName == right.FruitName && left.FruitType == right.FruitType;
        }

        public static bool operator !=(Fruit left, Fruit right)
        {
            return left.FruitName != right.FruitName || left.FruitType != right.FruitType;
        }



        public static implicit operator FruitDTO(Fruit fruit)
        {
            return new FruitDTO(fruit);
        }

        public static explicit operator String(Fruit fruit) 
        { 
            return fruit.FruitName;
        }

        public override string ToString()
        {
            return this.FruitName;
        }

    }
}