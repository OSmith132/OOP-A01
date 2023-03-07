using System;
using System.Collections.Generic;



    class Test
    {

        public static void runTest() // Method to run tests on the Pack and Card classes
        {


            // Instantiates the pack object
            Pack Pack = new Pack();

            // Shows the number of cards in a pack
            Console.WriteLine(Pack.pack.Count);

            // Demonstrates the Fischer-Yates Shuffle and outputs the shuffled pack
            Console.WriteLine("Fischer-Yates Shuffle: " + Pack.shuffleCardPack(1));
            foreach (Card card in Pack.pack)
            {
                Console.WriteLine("Value = " + card.Value + " Suit = " + card.Suit);
            }


            // Demonstrates the Riffle Shuffle and outputs the shuffled pack
            Console.WriteLine("\n\nRiffle Shuffle: " + Pack.shuffleCardPack(2));
            foreach (Card card in Pack.pack)
            {
                Console.WriteLine("Value = " + card.Value + " Suit = " + card.Suit);
            }


            // Demonstrates the deal and dealCard functions of the Pack class
            Console.WriteLine("\n\nDeal one card:");
            Card card1 = Pack.deal();
            if (card1 != null) // deal method will return null if there are no cards left in pack
            {
                Console.WriteLine("Value = " + card1.Value + " Suit = " + card1.Suit);
            }
            else
            {
                Console.WriteLine("No cards left to be dealt");
            }


            // Demonstrates the deal and dealCard functions of the Pack class
            List<Card> cards = Pack.dealCard(15);
            Console.WriteLine("\n\nDeal 15 Cards using dealCard method");
            foreach (Card card2 in cards)
            {
                Console.WriteLine("Value = " + card2.Value + " Suit = " + card2.Suit);
            }


            // Demonstrates adding a card to the pack
            Pack.pack = new List<Card>(); // clears pack
            Pack.addCard(new Card(1, 1)); // adds new card
            Card card3 = Pack.deal();
            Console.WriteLine("\n\nAdding one new card:");
            Console.WriteLine("Value = " + card3.Value + " Suit = " + card3.Suit);


            // Demonstrates adding multiple cards to the pack
            Pack.pack = new List<Card>(); // clears pack
            for (int i = 1; i < 5; i++) // Adds cards to pack
            {
                for (int j = 1; j < 5; j++)
                {
                    Pack.pack.Add(new Card(j, i));
                }
            }
            List<Card> cards1= Pack.dealCard(16);
            Console.WriteLine("\n\nAdding 16 new cards:");
            foreach (Card card in cards1) 
            { 
                Console.WriteLine("Value = " + card.Value + " Suit = " + card.Suit);
            }

    }

    }
        

    

