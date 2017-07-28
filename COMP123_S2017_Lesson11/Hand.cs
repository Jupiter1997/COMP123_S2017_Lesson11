using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter R. Vargas
 * Date: July 27, 2017
 * Description: this is the hand class the inherits from CardList
 * Version 0.2 : Add Highest Cards method
 */
namespace COMP123_S2017_Lesson11
{
    public class Hand : CardList
    {
        //Private instance Variable;

        //Public property
        //Contructer

        //Private Method
        protected override void _initialize()
        {
            //this is empty
        }
        //public methods
        /// <summary>
        /// this method overrides the build in to string method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "This Hand Contains : \n";
            outputString += "+++++++++++++++++++++++++++++++++++++++++++++++++++\n";
            foreach (Card card in this)
            {
               outputString += card.Face + " of " + card.Suit + "\n";
             // outputString += card.ToString() + "\n";
            }
    
            return outputString;
        }
        public void HighestCards()
        {

            var sorted =
                from card in this
                orderby card.Face
                select card;
            Console.WriteLine("*****************************************************");
            Console.WriteLine("The highest cards in the hand is: "
                + sorted.Last().ToString() + " and "+ sorted.ElementAt(3));
            Console.WriteLine("*****************************************************");
        }
    }
}