# CSharpZoo

Simple ASP.NET exercise for creating animals with an interface and a factory design pattern. Provides 1 API GET method:

`/api/Animals/{name}` where name is one of (dog, cat, snake): creates a new instance of that animal based on name passed. Returns the created animal with the result of calling it's `Speak()` method.


