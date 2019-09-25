# CSharpZoo

Simple ASP.NET exercise for creating animals with an interface and a factory design pattern. Provides 2 API GET methods:

`/api/Animals/{name}` where name is one of (dog, cat, snake): creates a new instance of that animal based on name passed and returns it.

`api/Animals/{name}/speak` calls the Speak() method of that animal
