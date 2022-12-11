using Atributo.Attributes;


namespace Atributo.models
{
    [DisplayClass]
    [Tab]
    public abstract partial class Bread : IBread
    {
        protected string _name;
        protected int _price;
        protected string _description = "Description";
        [Tab]
        [Tab]
        [Tab]
        [DisplayProperty("Name: ")]
        public string Name { get { return _name; } }
        [Tab]

        [DisplayProperty("Price: ", color: ConsoleColor.Green)]
        public int Price
        {
            get { return _price; }
            set
            {
                if (value > 0) _price = value;
            }
        }
        public string Description { get { return _description; } }

        public Bread(string name, int price)
        {
            _price = price;
            _name = name;
        }


        private Bread(string name)
        {
            _price = 3;
            _name = name;
        }

        protected Bread(BreadType name, int price)
        {
            _price = price;
            _name = name.ToString();
        }

        internal Bread(BreadType name, int price, int taxes)
        {
            _price = price * taxes;
            _name = name.ToString();
        }

        [Obsolete("Use Print(int quantity). This will be removed on version 1.2")]
        public virtual void Print()
        {
            Console.WriteLine($"TITLE: {this._name}");
            //Console.WriteLine($"{this._name} has a value of {this._price}$");
        }

        public void Print(int quantity)
        {
            Console.WriteLine($"{quantity} {this._name}s has a value of {this._price * quantity}$");
            String.Format("{0} {1}s has a value of {2}$", quantity, this._name, this._price * quantity);
        }

        public static string[] GetBreadTypes()
        {
            string[] types = { BreadType.Baguette.ToString(), BreadType.Hamburger.ToString() };
            return types;
        }

        public abstract void Make();

        void IBread.Cook()
        {
            throw new NotImplementedException();
        }
    }

    public enum BreadType
    {
        Baguette,
        Hamburger,
        White
    }
}
