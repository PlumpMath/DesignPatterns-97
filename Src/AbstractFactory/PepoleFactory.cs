namespace AbstractFactory
{
    public enum PepoleType
    {
        Villagers = 1,
        CityPeople = 2
    }
    public class PepoleFactory
    {
        private IPepole _pepole;
        public IPepole GetPepole(PepoleType type)
        {
            switch (type)
            {
                case PepoleType.Villagers:
                    _pepole = new Villagers();
                    break;
                case PepoleType.CityPeople:
                    _pepole = new CityPeople();
                    break;
                default:
                    _pepole = new Villagers();
                    break;
            }

            return _pepole;
        }
    }
}