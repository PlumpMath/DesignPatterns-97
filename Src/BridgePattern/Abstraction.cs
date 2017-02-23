namespace BridgePattern
{
    public interface IAbstraction
    {
        void ShowAll();
    }

    public class Abstraction : IAbstraction
    {
        private readonly Bridge _bridge;
        public Abstraction(Bridge bridge)
        {
            _bridge = bridge;
            _bridge.AddData();
        }
        public void ShowAll()
        {
            _bridge.ShowAll();
        }
    }
}