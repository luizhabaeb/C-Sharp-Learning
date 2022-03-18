using System;
using System.Collections.Generic;

List<string> list = new List<string>();

list.Add("Maria");
list.Add("Alex");
list.Add("Bob");
list.Add("Anna");
list.Insert(2, "Marco");

foreach (string obj in list)
{
    Console.WriteLine(obj);
}

Console.WriteLine("Tamanho da lista: " + list.Count);  // tamanho da lista

//Caso queira encontrar o PRIMEIRO elemento que comece com a letra 'A':
//Predicado é uma função que pega um valor e retorna V ou F conforme a lógica da função

string s1 = list.Find(Teste);
Console.WriteLine("Primeiro elemento que começa com 'A': " + s1);


static bool Teste(string s)     //função que retorna um booleano - recebe uma string s e retorna verdadeiro quando esse s tiver a primeira letra = 'A' 
{
    return s[0] == 'A';
}
