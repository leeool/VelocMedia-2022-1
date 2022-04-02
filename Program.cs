double dist, tempo;

Console.Write("Insira a distância percorrida (m): ");
dist = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o tempo gasto (s): ");
tempo = Convert.ToDouble(Console.ReadLine());

double velcmedia = dist / tempo;

Console.WriteLine($"\nA velocidade média é de {velcmedia:N2} m/s");

