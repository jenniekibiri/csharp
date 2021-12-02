namespace CSharp{
     public class Animal: IAnimal{
         private string _name;
            private int _age;
            private string _voice;

            public String Name{
                get{
                    return _name;
                    
                }
                set{
                    _name=value;
                }
            }
            public int Age{
                 get{
                     return _age;

                 }
                 set{
                     _age=value;
                 }
            }
            public String Voice{
                get{
                    return _voice;
                }
                set{
                    _voice=value;
                }
            }
             public Animal(String name,int age , string voice){
                 _name = name;
                 _age = age;
                 _voice = voice;
             }
             public void Speak(){
                 Console.WriteLine("I am {0} and im {1} i {2} to communicate" , _name,_age,_voice);
             }
                public void Move(){
                 Console.WriteLine("I am {0} and im {1} i {2} to communicate" , _name,_age,_voice);
             }
     }
}