// See https://aka.ms/new-console-template for more information
using singleton_monostate.Patterns;

#region Singleton
Console.WriteLine($"### Singleton ###{Environment.NewLine}");

SingletonPattern singletonPattern1 = SingletonPattern.GetInstance();
singletonPattern1.AddItems("Singleton 01", "Singleton 02", "Singleton 03");

SingletonPattern singletonPattern2 = SingletonPattern.GetInstance();
singletonPattern2.AddItems("Singleton 04", "Singleton 05", "Singleton 06");

var singletonObjetosIguais = singletonPattern1.Equals(singletonPattern2);
var singletonObjetosMesmosItens = singletonPattern1.GetItems.Equals(singletonPattern2.GetItems);

Console.WriteLine("Singleton - Grupo 01");
Console.WriteLine($"{singletonPattern1.ToString()}{Environment.NewLine}");

Console.WriteLine("Singleton - Grupo 02");
Console.WriteLine($"{singletonPattern2.ToString()}{Environment.NewLine}");

Console.WriteLine($"Objetos iguais? : {(singletonObjetosIguais ? "Sim" : "Não")}");
Console.WriteLine($"Objetos possuem os mesmos itens? : {(singletonObjetosMesmosItens ? "Sim" : "Não")}");
#endregion

Console.WriteLine($"{Environment.NewLine}-----------------------------------------------------------{Environment.NewLine}");

#region Monostate
Console.WriteLine($"### Monostate ###{Environment.NewLine}");

MonostatePattern monostatePattern1 = new MonostatePattern();
monostatePattern1.AddItems("Monostate 01", "Monostate 02", "Monostate 03");

MonostatePattern monostatePattern2 = new MonostatePattern();
monostatePattern2.AddItems("Monostate 04", "Monostate 05", "Monostate 06");

var monostateObjetosIguais = monostatePattern1.Equals(monostatePattern2);
var monostateObjetosMesmosItens = monostatePattern1.GetItems.Equals(monostatePattern2.GetItems);

Console.WriteLine("Monostate - Grupo 01");
Console.WriteLine($"{monostatePattern1.ToString()}{Environment.NewLine}");

Console.WriteLine("Monostate - Grupo 02");
Console.WriteLine($"{monostatePattern2.ToString()}{Environment.NewLine}");

Console.WriteLine($"Objetos iguais? : {(monostateObjetosIguais ? "Sim" : "Não")}");
Console.WriteLine($"Objetos possuem os mesmos itens? : {(monostateObjetosMesmosItens ? "Sim" : "Não")}");
#endregion