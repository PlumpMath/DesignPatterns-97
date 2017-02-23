namespace PrototypePattern
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class ColorPrototype : Prototype
    {
        public string Value { get; set; }

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }

}