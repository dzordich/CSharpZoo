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
        long Id { get; set; }
        string Name { get; set; }
        string Speak();

    }

    public class Dog : IAnimal
    {
        public long Id { get; set; }
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
        public long Id { get; set; }
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
        public long Id { get; set; }
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


    abstract class AbstractAnimalFactory

    {
        public abstract IAnimal CreateDog();
        public abstract IAnimal CreateCat();
        public abstract IAnimal CreateSnake();
    }

    class AnimalFactory : AbstractAnimalFactory

    {
        public override IAnimal CreateDog()
        {
            return new Dog();
        }
        public override IAnimal CreateCat()
        {
            return new Cat();
        }
        public override IAnimal CreateSnake()
        {
            return new Snake();
        }
    }

    public class Factory
    {
        public IAnimal CreateAnimal(string name)
        {
            AbstractAnimalFactory f = new AnimalFactory();
            if(name == "dog")
            {
                return f.CreateDog();
            }
            if(name == "cat")
            {
                return f.CreateCat();
            }
            if(name == "snake")
            {
                return f.CreateSnake();
            }
            throw new System.ArgumentException("Invalid animal name. Must be dog, cat, or snake");
        }

    }
}

