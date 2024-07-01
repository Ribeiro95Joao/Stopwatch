
//Cronometro
Menu();
    
    
  
  
  static void Menu()
{
    Console.Clear();
    Console.WriteLine("Digite 'S' para segundos (10s = 10 segundos)");
    Console.WriteLine("Digite 'M' para minutos (2m = 2 minutos)");
    Console.WriteLine("Digite '0' para sair");
    Console.WriteLine("Informe um tempo para contagem.");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));

    if (type == 'm')
    {
        time = time * 60;
    }

    if (time == 0)
    {
        System.Environment.Exit(0);
    }

    Start(time);


}

static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Stopwatch finalizado.");
    Thread.Sleep(2500);
    Menu();
}


