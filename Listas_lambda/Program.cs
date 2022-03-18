using System;
using System.Collections.Generic;

List<string> list = new List<string>();

list.Add("Maria");
list.Add("Alex");
list.Add("Eduarda");
list.Add("Bob");
list.Add("Anna");
list.Add("Alberto");
list.Add("Julia");
list.Add("Bruna");
list.Add("Adriano");
list.Insert(2, "Marco");

foreach (string obj in list)
{
    Console.WriteLine(obj);
}

Console.WriteLine("Tamanho da lista: " + list.Count);  // tamanho da lista

//ENCONTRAR PRIMEIRO OU ULTIMO ELEMENTO DA LISTA QUE SATISFAÇA UM "PREDICADO"
//Caso queira encontrar o PRIMEIRO elemento que comece com a letra 'A':
//Predicado é uma função que pega um valor e retorna V ou F conforme a lógica da função

string s1 = list.Find(x => x[0] == 'A');  //o objeto x => tal que x na posição [0] seja igual a palavra com inicio 'A' - EXPRESSÃO LAMBDA  - FUNÇÃO ANÔNIMA
Console.WriteLine("Primeiro elemento que começa com 'A': " + s1);
Console.WriteLine();

string s2 = list.FindLast(x => x[0] == 'A');  //último elemento como inicial 'A'
Console.WriteLine("Último elemento que começa com 'A': " + s2);
Console.WriteLine();


//ENCONTRAR PRIMEIRA OU ULTIMA POSIÇÃO DE ELEMENTO DA LISTA QUE SATISFAÇA UM PREDICADO
//Como agora será pela posição, será pelo numero INTEIRO

int pos1 = list.FindIndex(x => x[0] == 'B');
Console.WriteLine("Primeira posição com inicial B: " + pos1);
Console.WriteLine();

//FILTRAR A LISTA COM BASE EM UM PREDICADO - criar uma nova lista contendo apenas os elementos do filtro - que satisfaçam o predicado 
List<string> list2 = list.FindAll(x => x.Length == 5);
Console.WriteLine("------ Nomes com 5 caracteres ------");
foreach (string obj in list2)
    Console.WriteLine(obj);

// REMOVER ELEMENTOS DA LISTA - Remove, RemoveAll, RemoveAt, RemoveRange
list.Remove("Alex");
Console.WriteLine("------------------------------------");
Console.WriteLine("----- Após a remoção do 'Alex' -----");
foreach (string obj in list)
    Console.WriteLine(obj);


Console.WriteLine("------------------------------------");
Console.WriteLine(" Remoção dos nomes com iniciais 'M' ");
list.RemoveAll(x => x[0] == 'M');
foreach (string obj in list)
    Console.WriteLine(obj);

Console.WriteLine("------------------------------------");
Console.WriteLine("------- Remoção da posição 2 -------");
list.RemoveAt(2);
foreach (string obj in list)
    Console.WriteLine(obj);

Console.WriteLine("---------------------------------------");
Console.WriteLine("Remover 2 nomes partindo da posição 2: ");
list.RemoveRange(2, 2);
foreach (string obj in list)
    Console.WriteLine(obj);