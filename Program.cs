﻿internal class Program
{
    static void Main()
    {
        //Snack11) Dare la possibilità di inserire due parole.
        //Verificare tramite una funzione che le due parole abbiano la stessa
        //lunghezza. Se hanno la stessa lunghezza, stamparle entrambe,
        //altrimenti stampare la più lunga delle due


        void CheckWordsLength(string word1, string word2)
        {
            if (word1.Length > word2.Length)
            {
                Console.WriteLine("La parola più lunga è: \x1b[1m{0}\x1b[0m, con \x1b[1m{1}\x1b[0m lettere ", word1, word1.Length);
            }
            else if (word1.Length < word2.Length)
            {
                Console.WriteLine("La parola più lunga è: \x1b[1m{0}\x1b[0m, con \x1b[1m{1}\x1b[0m lettere ", word2, word2.Length);
            } else
            {
                Console.WriteLine("la parola '\x1b[1m{0}\x1b[0m' e la parola \x1b[1m{1}\x1b[0m sono lunghe uguali, con \x1b[1m{2}\x1b[0m lettere", word1, word2, word1.Length);
            }
            
        }

        Console.WriteLine("inserisci una parola");
        string userWord1 = Console.ReadLine();

        Console.WriteLine("inserisci un'altra parola");
        string userWord2 = Console.ReadLine();

        CheckWordsLength(userWord1, userWord2);


        return;


        // Snack 6) - Chiedi all'utente un numero N. Crea N array, ognuno formato da 10 numeri casuali tra 1 e 100, e ogni volta che ne crei uno stampalo a schermo

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



        // Snack 4) - Calcola la somma e la media dei numeri da 2 a 10

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


        return;


        //snack 2)


        Console.WriteLine("inserisci un numero");
        string firstWord = Console.ReadLine();

        Console.WriteLine("inserisci un altro numero");
        string secondWord = Console.ReadLine();

        if (firstWord.Length > secondWord.Length)
        {

            Console.WriteLine(firstWord);

        }
        else if (secondWord.Length > firstWord.Length)
        {

            Console.WriteLine(secondWord);

        }
        else
        {
            Console.WriteLine("le due parole sono uguali");
        }




        return;



        //snack 1)

        Console.WriteLine("inserisci un numero");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("inserisci un altro numero");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {

            Console.WriteLine(firstNumber);

        } else if (secondNumber > firstNumber)
        {
            
            Console.WriteLine(secondNumber);

        } else
        {
            Console.WriteLine("i due numeri sono uguali");
        }

    }


}
