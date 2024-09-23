// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Collections;
using ConceptOfGenerics;

//NonGenericClass data = new NonGenericClass();
//data.Print<int>(24);
//data.Print<string>("Kobe");
//data.Print("Bean");
//data.Print(8);
/*
 * Generic, tip açısından güvenlidir. Belirtilen tipte veriyi kabul eder. Derleme zamanı hatası verir zaten.
 * Generic sayesinde boxing-unboxing yapmaya gerek kalmaz. Tip bağımlı olduğu için performans avantajı sağlar.
 */

//GenericClass<int> genericClass = new GenericClass<int>();
//genericClass.Id = 10; // yukardaki veri tipine göre type alıyor
//genericClass.FirstName = "Jax";
//genericClass.LastName = "Teller";

//GenericClass<Guid> genericClass1 = new GenericClass<Guid>();
//genericClass1.Id = Guid.NewGuid();
//genericClass1.FirstName = "Kemal";
//genericClass1.LastName = "Atatürk";

//Console.WriteLine($"Id: {genericClass.Id}\nFull Name: {genericClass.FirstName} {genericClass.LastName}");
//Console.WriteLine(new string('+', 60));
//Console.WriteLine($"Id: {genericClass1.Id}\nFull Name: {genericClass1.FirstName} {genericClass1.LastName}");

//GenericMethod<string> teams = new GenericMethod<string>();
//teams.addData(0, "Galatasaray");
//teams.addData(1, "Fenerbahçe");
//teams.addData(2, "Beşiktaş");
//teams.addData(3, "Trabzonspor");
//teams.addData(4, "Bursaspor");

//for (int i = 0; i < teams.arr.Length; i++)
//{
//    Console.WriteLine($"Team Id: {i} - Team Name: {teams.GetData(i)}");
//}

//Console.WriteLine(new string('/', 50));

//GenericMethod<int> averageAge = new GenericMethod<int>();
//averageAge.addData(0, 25);
//averageAge.addData(1, 24);
//averageAge.addData(2, 27);
//averageAge.addData(3, 26);
//averageAge.addData(4, 26);

//for (int i = 0; i < averageAge.arr.Length; i++)
//{
//    Console.WriteLine($"Age Id: {i} - Average Age: {averageAge.GetData(i)}");
//}

KeyAndValuePair<int, string> user = new KeyAndValuePair<int, string>();
user.Id = 1;
user.Name = "Anthony Soprano";
user.BirthDate = new DateOnly(1964, 10, 11);
Console.WriteLine($"Id: {user.Id}\nFull Name: {user.Name}\nBirth Date: {user.BirthDate}");

//////

DictionaryEntry dicEnt = new DictionaryEntry();
