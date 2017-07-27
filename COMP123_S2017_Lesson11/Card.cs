using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter R. Vargas
 * Date: July 25, 2017
 * Description: This is the Card Class , using shufflign and dealing
 * Version 0.1 : Created Card Class
 */
namespace COMP123_S2017_Lesson11
{
    public class Card: ICloneable
    {
        // Private Instance Variable
        private Face _face;
        private Suit _suit;
        // Publiv Properties
        public Face Face
        {
            get
            {
                return this._face;
            }

            set
            {
                _face = value;
            }
        }
        public Suit Suit
        { get
            {
                return this._suit;
            }
          set
            {
                this._suit = value;
            }
        }
        //Constructers
        /// <summary>
        /// This the contructer Card the take 2 arguments 
        /// Face (face) Suit (suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        //Private Methods

        //Public Methods
        public object Clone()
        {
            return new Card(this._face, this._suit);
        }
    }
}