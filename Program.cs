Console.WriteLine("-- Projétil --\n");

Console.Write("Entre com a velocidade, em m/s..: ");
Double velocidadeInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Entre com o ângulo, em graus....: ");
double AnguloGrau = Convert.ToDouble(Console.ReadLine());

double AnguloRadiano = AnguloGrau * (Math.PI / 180);
const double Gravidade = 9.80665;

double altura = (Math.Pow(velocidadeInicial * Math.Sin(AnguloRadiano), 2)) / (2 * Gravidade);
double alcance = (Math.Pow(velocidadeInicial, 2) * Math.Sin(2 * AnguloRadiano)) / Gravidade;

Console.WriteLine($"\nAlcance........: {alcance:N2} m");
Console.WriteLine($"Altura máxima..: {altura:N2} m");