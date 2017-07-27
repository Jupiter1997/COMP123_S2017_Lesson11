using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Marvin Jupiter R. Vargas
 * Date: July 25, 2017
 * Description: Making Playing Card 
 * Version 0.2 : Call out hand to deal 5 card
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
            Console.WriteLine("Shuffled Deck: \n");
            Console.WriteLine(deck.ToString());
            Hand hand = new Hand();

            //hand.Add(deck.Deal1());
            //Console.WriteLine(hand.ToString());
            //Console.WriteLine();
            //hand.Add(deck.Deal1());
            //Console.WriteLine(hand.ToString());

            hand = deck.Deal5();
            Console.WriteLine(hand.ToString());



        }
    }
}
