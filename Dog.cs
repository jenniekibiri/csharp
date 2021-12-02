//inherit from Animal
namespace CSharp
{
    public class Dog : Animal
    {
        public Dog(String name, int age, string voice) : base(name, age,voice)
        {
            //constructor chaining
            Console.WriteLine("Dog constructor");
        }
    }
}