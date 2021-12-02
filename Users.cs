namespace CSharp
{
    class Users
    {
        private int _age;
        public string name;
                public string Name="yyu";

        public int Age
        {
            get { return _age; }

            set { _age = value; }
        }
        public Users(String name)
        {
            this.name = name;
 

        }
        public void Add()
        {
                        Console.WriteLine("User added" + this._age);


            Console.WriteLine("User added" + name);

        }
    }
}