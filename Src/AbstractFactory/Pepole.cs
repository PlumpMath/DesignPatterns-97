namespace AbstractFactory
{
    public interface IPepole
    {
        string GetName();
    }

    public class Villagers : IPepole
    {
        private readonly string _name;

        public Villagers()
        {
            _name = "Villagers Pepole";
        }

        public string GetName()
        {
            return $"{_name}";
        }
    }

    public class CityPeople : IPepole
    {
        private readonly string _name;

        public CityPeople()
        {
            _name = "City People";
        }

        public string GetName()
        {
            return $"{_name}";
        }
    }
}