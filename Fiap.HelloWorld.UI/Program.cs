// See https://aka.ms/new-console-template for more information
using Fiap.HelloWorld.UI.Models;
using Fiap.HelloWorld.UI.Models2;

Console.WriteLine("Hello, World!");
Aluno aluno = new Aluno();
Animal animal = new Animal();

animal.Raca = "Vira lata";
animal.Nome = "Popo";


aluno.Nome = "Lucas";
aluno.Idade = 23;

Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Idade); 
Console.WriteLine(animal.Nome);
Console.WriteLine(animal.Raca); 


