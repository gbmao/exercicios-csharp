Random rnd = new Random();
int coin = rnd.Next(0, 2);

Console.WriteLine($"A Moeda deu: {(coin == 0 ? "Cara" : "coroa")}");

