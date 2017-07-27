using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter R. Vargas
 * Date: July 25, 2017
 * Description: This is is the abstarct Card List Super class, it inherits a build-in generic collection and 
 * the Card class
 * Version 0.1 : Created CardList Class
 */
namespace COMP123_S2017_Lesson11
{
    public abstract class CardList: List<Card>

    {
         //Private Instance Variable

        //Private Properties

        //Contructers
        public CardList()
        {
            this._initialize();
        }

        //Private Method
        protected abstract void _initialize();
        //Public Method
    }
}