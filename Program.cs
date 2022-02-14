// See https://aka.ms/new-console-template for more information

string[] names = new string[4];

names[0] = "Dennis";
names[1] = "Sven";
names[2] = "Marie";
names[3] = "Christian";

Console.WriteLine("Hallo " + names[2] + "!");



string[,] products = new string[3, 2];

products[0, 0] = "Smartphone";
products[0, 1] = "Elektro";

products[1, 0] = "Fleisch";
products[1, 1] = "Lebensmittel";

products[2, 0] = "Seife";
products[2, 1] = "Pflegeprodukte";

Console.WriteLine("Im Verkaufsbereich " + products[0, 1] + " haben wir ein " + products[0, 0] + " im Angebot");

Console.ReadKey();
