namespace cSharpSamples.Shared.Entities{
    public class Entity{
        public Guid Id { get; private set; }

        public Entity(){
            Id = Guid.NewGuid();
        }
    }
}