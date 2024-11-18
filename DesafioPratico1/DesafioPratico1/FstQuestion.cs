namespace DesafioPratico1;

class Challenge1
{
    public string GetName()
    {
        Console.WriteLine("Digite o seu nome:\n");
        string Name = Console.ReadLine();
        return Name;
    }
}
class Challenge2
{
    public string GetFirstName(){

        Console.WriteLine("Olá, digite o seu nome: \n");
        string FirstName = Console.ReadLine();
        return FirstName;
        }
    public string GetLastName()
    {
        Console.WriteLine("Digite seu Sobrenome:\n");
        string LastName = Console.ReadLine();
        return LastName;
    }
}
class Challenge3
{
    public void Math()
    {
        double a, b;
        Console.WriteLine("Digite o primeiro Número:\n");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nDigite o segundo Número:\n");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nA Soma de " + a + "+" + b + " é " + (a + b));
        Console.WriteLine("\nA subtração de " + a + "-" + b + " é " + (a - b));
        Console.WriteLine("\nA Multiplicação de " + a + "x" + b + " é " + (a * b));
        if (b == 0)
            Console.WriteLine("\nImpossível dividir por 0.");
        else
            Console.WriteLine("\nA Divisão de " + a + "/" + b + " é " + (a / b));
        Console.WriteLine("\nA Média de " + a + " e " + b + " é " + ((a + b)/2));
    }
}

