using System;
namespace Zoo.Models
{
    public class AniAmal
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string AnimalClass { get; set; }
        public string AnimalOrder { get; set; }

        
    }
    public interface IAnimal
    {
        string Name { get; set; }
        string Speak();

    }

    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public Dog()
        {
            Name = "dog";
        }
        public string Speak()
        {

            return "woof";
        }
    }
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public Cat()
        {
            Name = "cat";
        }
        public string Speak()
        {
            return "meow";
        }
    }
    public class Snake : IAnimal
    {
        public string Name { get; set; }
        public Snake()
        {
            Name = "snake";
        }
        public string Speak()
        {
            return "hiss";
        }
    }
}
