using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Hand
    {
        public List<Card> hand = new List<Card>();


        public void AddCard(Card card) // Adds and card to the hand
        {
            hand.Add(card);
        }
        public void AddCards(List<Card> cards) // Adds a list of cards to the hand
    {
            hand.AddRange(cards);
        }

        public Card GetCardAt(int index) // Returns the card at a specified index
        {
            if (hand.Count > index)
            {
                return hand[index];
            }
            return null;
        }   
        
        public Card DealCard(int index) // Deals card at given index
        {
            if (hand.Count > index)
            {
                Card card = hand[index];
                hand.RemoveAt(index);
                return card;
            }
            return null;
            
        }

        


}

