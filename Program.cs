Human froilan = new Human("Froilan", 5, 100, 5, 200);

Human aaron = new Human ("Aaron");


Wizard sherline = new Wizard("Sherline", 10, 200);

Console.WriteLine(froilan.Attack(aaron));

Console.WriteLine(sherline.Health);

Console.WriteLine(sherline.Attack(aaron));

Console.WriteLine(sherline.Heal(aaron));
