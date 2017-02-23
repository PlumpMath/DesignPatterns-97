using System;

namespace BridgePattern
{
    public abstract class Bridge
    {
        private IDataObject data;
        protected string _name;

        protected Bridge(string name)
        {
            _name = name;
            data = new DataObject();
        }

        public IDataObject DataObject
        {
            get { return data; }
            set { data = value; }
        }

        public virtual void AddData()
        {
            data.Add("Default Data");
        }

        public virtual void ShowAll()
        {
            data.ShowAll();
        }

    }
    public class CustomerBridge : Bridge
    {
        public CustomerBridge(string name) : base(name)
        {
        }

        public override void AddData()
        {
            DataObject.Add("Samer Alkhatib");
            DataObject.Add("Johan Smith");
        }

        public override void ShowAll()
        {
            Console.WriteLine("-----------Customer-----------");
            base.ShowAll();
            Console.WriteLine("----------End Customer------------");
        }
    }

    public class TasksBridge : Bridge
    {
        public TasksBridge(string name) : base(name)
        {
        }

        public override void AddData()
        {
            DataObject.Add("Init Git Repo");
            DataObject.Add("Init Azure Web service");
        }

        public override void ShowAll()
        {
            Console.WriteLine("-----------Tasks----------");
            base.ShowAll();
            Console.WriteLine("---------End Tasks--------");
        }
    }
}