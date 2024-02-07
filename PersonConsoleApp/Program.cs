// See https://aka.ms/new-console-template for more information
using PersonLib.model;

Console.WriteLine("Hello, World!");

try
{
    Person person = new Person();

    person.Id = 1001;
    person.Name = null;


    person.Id = 999;
}
catch(ArgumentException ex)
{

    Console.WriteLine(ex.Message);
}
