Console.WriteLine("Ra dagijda tqveni shenadzeni:");

int Tanxa = int.Parse(Console.ReadLine());



if (Tanxa <= 100 )
{
    Console.WriteLine($"Tqveni danaxarji ar eqvemdebareba fasdaklebas. Gadasaxdelia {Tanxa}");
}
else if (Tanxa >= 101 && Tanxa <= 500)
{
    Console.WriteLine($"Tqven gekutvniT 10% fasdakleba. Gadasaxdelia {Tanxa-(Tanxa/10)}  ");
}
else if (Tanxa >= 500)
{
    Console.WriteLine($"Tqven gekutvnit 20% fasdakleba. Gadasaxdelia { Tanxa - (Tanxa / 5)}");
}

else
{
    Console.WriteLine("Tqven sheiyvanet araswori kodi");
}


Console.ReadLine();