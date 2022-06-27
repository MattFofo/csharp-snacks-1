internal class Program
{
    static void Main()
    {
        // Snack 3) - Calcola la somma e la media dei numeri da 2 a 10

        int somma = 0;

        for (int i = 2; i < 10; i++)
        {
            somma += i;
        }

        float media = somma / 8;

        Console.WriteLine(somma);
        Console.WriteLine(media);




        return;
        
         //Snack 3) -Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti
         
        

        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            
            if (i == 0)
            {
                Console.WriteLine("Scrivi un numero");
            } else
            {
                Console.WriteLine("scrivi un'altro numero");
            }

            int userNumber = int.Parse(Console.ReadLine());
            sum += userNumber;
        }

        Console.WriteLine("La somma dei numeri è: " + sum);

    }
}
