using System;
namespace Zoo.Models
{
    public interface IAnimalTest
    {
        string Speak();
    }

    
    public class Cow : IAnimalTest
    {
        public string Speak()
        {
            return "mooo";
        }
    }
}
