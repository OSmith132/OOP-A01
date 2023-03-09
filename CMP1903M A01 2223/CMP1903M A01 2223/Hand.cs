
using System.Collections.Generic;

    class Hand
    {
        public List<Card> HandOfCards = new List<Card>();


        public void AddCard(Card card) // Adds and card to the hand
        {
            HandOfCards.Add(card);
        }
        public void AddCards(List<Card> cards) // Adds a list of cards to the hand
    {
            HandOfCards.AddRange(cards);
        }

        public Card GetCardAt(int index) // Returns the card at a specified index
        {
            if (HandOfCards.Count > index)
            {
                return HandOfCards[index];
            }
            return null;
        }   
        
        public Card DealCard(int index) // Deals card at given index
        {
            if (HandOfCards.Count > index)
            {
                Card card = HandOfCards[index];
                HandOfCards.RemoveAt(index);
                return card;
            }
            return null;
            
        }


}

