using System;

namespace RomanNumberEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Programu ");

            int arabNumber = 1666;
            char[] romanArray = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            int[] arabArray = { 1000, 500, 100, 50, 10, 5, 1 };

            char[] stringRoman = new char[20];

            int putNumber = arabNumber;
            Console.WriteLine("putNumber wynosi: " + putNumber);


            //for (int startLoop = putNumber; startLoop == 0;) //pętla która będzie się  wyknywała aż startLoop bedzie == 0, czyli jeśli liczba np. 1000 jest w arabNumber.
            while(putNumber!=0)
            {
                for (int o=0; o<arabArray.Length;o++) //petla która przechodzi przez każdy znak 1000, 500, 
                {

                    while(arabArray[o] <= putNumber) //tutaj będe spradzał czy sama liczba jest wieksza od tej rzymskiego odpowiednika 1000,500, 100. Chyba będe musiał zrobic jeszcze jedną rzecz która będzie zwiększała jakiś char albo pozycję chara do którego będe zapisywał znaki bo np. moze byc 3 III a nie 1 raz więc np. jakis char a la char abc [o+p] gdy bp. p = 3 albo cos takiego
                    {
                        if (arabArray[o] <= putNumber)
                        {
                            stringRoman[o] = romanArray[o];
                            Console.WriteLine("\n"+"Nowa liczba dodana to: ");
                            Console.WriteLine(stringRoman[o]);

                        }
                        putNumber =putNumber-arabArray[o];
                        Console.WriteLine("Odejmuje wartosc: " + arabArray[o]);
                        Console.WriteLine(putNumber);



                    }



                }



            }

            Console.WriteLine(stringRoman);


            Console.ReadLine();
            Console.Write("Koniec Programu");
            Console.ReadLine();
        }
    }
}


//https://www.codewars.com/kata/51b62bf6a9c58071c600001b/train/csharp


//Algorytm taki
//Biore liczbe, sprawdzam czy miesci sie w niej 1000, 500, 100, 50, 10, 5, 1
//jak się mięści to odejmuje tą wartośc która się mieści od łównej liczby i do stringa/string array dodaje odpowiednia liczbe.

//stwarzam 2 arraye jeden z znakami rzymskimi a drugi z odpowiadającymi mu wartościami. I w ten sposób mniej pętli będzie bo będą się zmieniać tylko znaki a nie każda osobana pętla do osobnego znaku.


//1666 uses each Roman symbol in descending order: MDCLXVI.