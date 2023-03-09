using System;
using System.Collections.Generic;


    class Pack
    {
        public static List<Card> PackOfCards = new List<Card>();

        static Pack()
        {

           for(int i=1; i<5; i++) // Adds cards to pack
           {
                for (int j = 1; j < 14; j++)
                {
                    PackOfCards.Add(new Card(j, i));
                }
           }

        }



        public static bool ShuffleCardPack(int typeOfShuffle)
        {

            // Guard Clause of more than 1 cards in a pack to shuffle
            if (PackOfCards.Count >= 2)
            {

                // Fischer-Yates shuffle
                if (typeOfShuffle == 1) 
                {

                    int endPointer = PackOfCards.Count - 1;
                    Random rand = new Random();

                    while (endPointer > 0){

                        int numRand = rand.Next(0, endPointer);
                        Card num1 = PackOfCards[numRand];
                        Card num2 = PackOfCards[endPointer];

                        PackOfCards[endPointer] = num1;
                        PackOfCards[numRand] = num2;
                        
                        endPointer--;
                    }

                return true;
                }


                // Card Riffle shuffle  
                else if (typeOfShuffle == 2) 
                {
                    List<Card> leftPack = new List<Card>();

                    // Divides the pack into two
                    for (int i = 0; i < PackOfCards.Count / 2; i++) 
                    {
                        leftPack.Add(PackOfCards[i]);
                    }

                    Card[] rightArray = PackOfCards.GetRange((PackOfCards.Count / 2) - 1, PackOfCards.Count - (PackOfCards.Count / 2)).ToArray();
                    List<Card> rightPack = new List<Card>(rightArray);

                    PackOfCards.Clear();

                    // Merges two packs together
                    for(int i=0; i < leftPack.Count; i++)
                    {
                        PackOfCards.Add(leftPack[i]);
                        PackOfCards.Add(rightPack[i]);
                    }

                    return true;
                }


                // no shuffle
                else
                {
                    return false;
                }

            }
            else
            {
                return false; // Returs true if the pack contains less than two cards
            }

        }


        public static Card Deal() // Deals one card from the pack (and removes it from the deck)
            {

                if (PackOfCards.Count > 0)
                {
                    Card card = PackOfCards[0];
                    PackOfCards.RemoveAt(0);
                    return card;
                }
                else {
                    return null; // returns null if there is no card to return
                }

            }


        public static void AddCard(Card card) // Returns a card to the pack (Additional Method)
        {
            PackOfCards.Add(card);
        }

        public static void AddCard(List<Card> cards) // Returns a list of card to the pack (Additional Method)
        {
            PackOfCards.AddRange(cards);
        }



        public static List<Card> DealCard(int amount) // Deals multiple cards from the deck
        {
            if(amount >= PackOfCards.Count) // Guard clause if user tries to deal more cards than is left in the pack -> will empty pack
            {
                amount = PackOfCards.Count;
            }

            List<Card> cards = new List<Card>();

            for(int i=0; i < amount; i++)
            {
                cards.Add(PackOfCards[0]);
                PackOfCards.RemoveAt(0);
            }
             
            return cards;
        }

    }

