using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Marvin Jupiter R. Vargas
 * Date: July 25, 2017
 * Description: Making Playing Card 
 * Version 0.1 : Making of suit and faces
 */
namespace COMP123_S2017_Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
        }
    }
}
