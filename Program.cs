

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero ("Анастачия", 90);
Hero artem = new Hero("Артем", 120);

yaroslav.Health = 75;

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");



Person jacket = new Person("Jacket","Hotline Miami", "Killer");
Person jason = new Person("Jason Voorhees","Dead by Daylight", "Killer");
Person darius = new Person("Darius","Party Hard", "Killer");

Console.WriteLine($"Имя: {jacket.Name}");
Console.WriteLine($"Игра: {jacket.Game}");
Console.WriteLine($"Роль: {jacket.Rol}");
Console.WriteLine($"Убийства: {jacket.Kill}");

Console.WriteLine();

Console.WriteLine($"Имя: {jason.Name}");
Console.WriteLine($"Игра: {jason.Game}");
Console.WriteLine($"Роль: {jason.Rol}");
Console.WriteLine($"Убийства: {jason.Kill}");

Console.WriteLine($"Имя: {darius.Name}");
Console.WriteLine($"Игра: {darius.Game}");
Console.WriteLine($"Роль: {darius.Rol}");
Console.WriteLine($"Убийства: {darius.Kill}");