﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            //get a random number from 1 to 4
            int value = random.Next(1, 5);
            //if it's 1 return the string Spades
            if (value == 1) return "Spades";
            //if it's 2 return the string Hearts
            if (value == 2) return "Hearts";
            //if it's 3 return the string Clubs
            if (value == 3) return "Clubs";
            //if we haven't returned yet, return the string Diamonds
            return "Diamonds";
        }

        private static string RandomValue()
        {
            //returns a card value based on the random value generated
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 2) return "Two";
            if (value == 3) return "Three";
            if (value == 4) return "Four";
            if (value == 5) return "Five";
            if (value == 6) return "Six";
            if (value == 7) return "Seven";
            if (value == 8) return "Eight";
            if (value == 9) return "Nine";
            if (value == 10) return "Ten";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
