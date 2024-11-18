namespace DesafioPratico1;
class Program
{
    static void Main()
    {
        Challenge1 Name = new Challenge1();
        Challenge2 Result = new Challenge2();
        Challenge3 Math = new Challenge3();
        Console.WriteLine("Questão 1 \n");
        Console.WriteLine("Olá, " + Name.GetName() + ". Seja muito bem-vindo!\n");
        Console.WriteLine("\nQuestão 2\n");
        Console.WriteLine("\nNome Completo: " + string.Concat(Result.GetFirstName()," ",Result.GetLastName()));
        Console.WriteLine("\nQuestão 3\n");
        Math.Math();
    }
}
