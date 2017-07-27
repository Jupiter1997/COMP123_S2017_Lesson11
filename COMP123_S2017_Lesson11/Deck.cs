using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter R. Vargas
 * Date: July 25, 2017
 * Description: This is Deck Class which inherits to Card collection
 * Version 0.3: Added deal1() methos to deal one card
 */
namespace COMP123_S2017_Lesson11
{
    public class Deck : CardList
    {
        // Private Instance Variable
        private Random _random;
        
        //Private Property
        private Random Random
        {
            get
            {
                return this._random;
            }
        }
        // Public Properties
     
        //Private Methods
        /// <summary>
        /// This is the private methos that add the cards in the deck list
        /// this method also initialize other class variable
        /// </summary>
        protected override void _initialize()
        {
            //initialize the random object
            this._random = new Random();

            //load the list with cards
            for (int suit = 0; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = 1; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
           
        }
        //Public Methods
        /// <summary>
        /// thisi the a overrides method
        /// </summary>
        /// <returns>return deck of cards</returns>
        public override string ToString()
        {
     
            string outputString = "";
            foreach (Card card in this)
            {
                outputString += card.Face +" of "+ card.Suit + "\n";
            }
            return outputString;

        }
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;
            for (int i = 0; i < this.Count; i++)
            {


                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);
                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
        }
        public Card Deal1()
        {
            Card firstCard = this[0];
            this.RemoveAt(0); // this removes the top card from the deck

            
            Console.WriteLine("Deck count" + this.Count); // test id remove works

            return firstCard;
        }
    }
}