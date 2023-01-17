namespace TrainingAsignment1;

public class Class1
{
    static void Foobar(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 ==0 && i % 5 == 0)
            {
                Console.Write("foobar ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("bar ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("foo ");
            }
            else
            {
                Console.Write(i + " ");
            }
        }
    }
    
    public static void Main()
    {
        Foobar(15);
    }
}