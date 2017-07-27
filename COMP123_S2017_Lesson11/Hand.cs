using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter R. Vargas
 * Date: July 27, 2017
 * Description: this is the hand class the inherits from CardList
 * Version 0.1 : Created Hand Class
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
            throw new NotImplementedException();
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
            outputString += "+++++++++++++++++++++++++++++++++++++++++++++++++++";
            foreach (Card card in this)
            {
                outputString += card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }
    }
}