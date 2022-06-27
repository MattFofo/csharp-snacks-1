internal class Program
{
    static void Main()
    {
        // Snack 5) - Chiedi all'utente un numero N. Crea N array, ognuno formato da 10 numeri casuali tra 1 e 100, e ogni volta che ne crei uno stampalo a schermo

        Console.WriteLine("Scrivi un numero");
        int anotherGuyNumber = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int[] arrayNumbers = new int[10];

        for (int i = 0; i < anotherGuyNumber; i++)
        {
            
            for (int j = 0; j < arrayNumbers.Length; j++)
            {
                arrayNumbers[j] = rnd.Next(1, 101);
            }

            for (int k = 0; k < arrayNumbers.Length; k++)
            {
                if (k == arrayNumbers.Length - 1)
                {
                    Console.Write(arrayNumbers[k]);
                } else
                {
                    Console.Write(arrayNumbers[k] + "-");
                }
                
            }

            Console.WriteLine();
        }


        return;


        // Snack 5) - Chiedi all'utente un numero. Se è pari stampalo, se è dispari stampa il successivo

        Console.WriteLine("Scrivi un numero");
        int guyNumber = int.Parse(Console.ReadLine());

        if (guyNumber % 2 == 0)
        {
            Console.WriteLine(guyNumber);
        } else
        {
            Console.WriteLine(guyNumber + 1);

        }

        return;



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
