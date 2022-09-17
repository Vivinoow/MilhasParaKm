double milhas, kms;

Console.Write("Entre coma a medida (em milhas):");
milhas = Convert.ToDouble(Console.ReadLine());

kms = milhas *1609;

Console.WriteLine($"{kms:N3}Km");
