using System;
using System.Collections.Generic;



    class Test
    {

        public static void runTest() // Method to run tests on the Pack and Card classes
        {



            // Shows the number of cards in a pack
            Console.WriteLine("Number of cards in the pack: " + Pack.PackOfCards.Count);

            // Demonstrates the Fischer-Yates Shuffle and outputs the shuffled pack
            Console.WriteLine("\nFischer-Yates Shuffle: " + Pack.ShuffleCardPack(1));
            foreach (Card card in Pack.PackOfCards)
            {
                Console.WriteLine("Value = " + card.Value + " Suit = " + card.Suit);
            }


            // Demonstrates the Riffle Shuffle and outputs the shuffled pack
            Console.WriteLine("\n\nRiffle Shuffle: " + Pack.ShuffleCardPack(2));
            foreach (Card card in Pack.PackOfCards)
            {
                Console.WriteLine("Value = " + card.Value + " Suit = " + card.Suit);
            }


            // Demonstrates the deal and dealCard functions of the Pack class
            Console.WriteLine("\n\nDeal one card:");
            Card card1 = Pack.Deal();
            if (card1 != null) // deal method will return null if there are no cards left in pack
            {
                Console.WriteLine("Value = " + card1.Value + " Suit = " + card1.Suit);
            }
            else
            {
                Console.WriteLine("No cards left to be dealt");
            }


            // Demonstrates the deal and dealCard functions of the Pack class
            List<Card> cards = Pack.DealCard(15);
            Console.WriteLine("\n\nDeal 15 Cards using dealCard method");
            foreach (Card card2 in cards)
            {
                Console.WriteLine("Value = " + card2.Value + " Suit = " + card2.Suit);
            }


            // Demonstrates adding a card to the pack
            Pack.PackOfCards = new List<Card>(); // clears pack
            Pack.AddCard(new Card(1, 1)); // adds new card
            Card card3 = Pack.Deal();
            Console.WriteLine("\n\nAdding one new card:");
            Console.WriteLine("Value = " + card3.Value + " Suit = " + card3.Suit);


            // Demonstrates adding multiple cards to the pack
            Pack.PackOfCards = new List<Card>(); // clears pack
            for (int i = 1; i < 5; i++) // Adds cards to pack
            {
                for (int j = 1; j < 5; j++)
                {
                    Pack.PackOfCards.Add(new Card(j, i));
                }
            }
            List<Card> cards1= Pack.DealCard(16);
            Console.WriteLine("\n\nAdding 16 new cards:");
            foreach (Card card in cards1) 
            { 
                Console.WriteLine("Value = " + card.Value + " Suit = " + card.Suit);
            }


            Hand hand = new Hand();

            // Demonstrates adding a card to the hand and dealing it from the hand
            hand.AddCard(new Card(1, 1));
            Card card4 = hand.DealCard(0);
            Console.WriteLine("\n\n\nCard in hand: Value = " + card4.Value + " Suit = " + card4.Suit);


            // Demonstrates adding multiple cards to the hand
            for (int i = 1; i < 5; i++) 
            {
                for (int j = 1; j < 5; j++)
                {
                    hand.AddCard(new Card(j, i)); // adds 16 cards to the hand
                }
            }

            Console.WriteLine("\n\nAdding 16 new cards to hand:");
            foreach (Card card in hand.HandOfCards)
            {
                Console.WriteLine("Value = " + card.Value + " Suit = " + card.Suit);
            }


            // Demonstrates getting a card from the hand at a given index
            Card card5 = hand.GetCardAt(3);
            Console.WriteLine("\n\nCard in hand at 3rd index: Value = " + card5.Value + " Suit = " + card5.Suit);



            // Demonstrates the naming of a Card
            foreach (Card card in hand.HandOfCards)
            {
                Console.WriteLine("Value = " + card.Value + " Suit = " + card.Suit + " Name = " + card.Name);
            }
    }       

}
        

    

