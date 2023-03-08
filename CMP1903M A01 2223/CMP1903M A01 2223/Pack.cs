using System;
using System.Collections.Generic;


    class Pack
    {
        public static List<Card> pack = new List<Card>();

        static Pack()
        {

           for(int i=1; i<5; i++) // Adds cards to pack
           {
                for (int j = 1; j < 14; j++)
                {
                    pack.Add(new Card(j, i));
                }
           }

        }



        public static bool ShuffleCardPack(int typeOfShuffle)
        {

            // Guard Clause of more than 1 cards in a pack to shuffle
            if (pack.Count >= 2)
            {

                // Fischer-Yates shuffle
                if (typeOfShuffle == 1) 
                {

                    int endPointer = pack.Count - 1;
                    Random rand = new Random();

                    while (endPointer > 0){

                        int numRand = rand.Next(0, endPointer);
                        Card num1 = pack[numRand];
                        Card num2 = pack[endPointer];

                        pack[endPointer] = num1;
                        pack[numRand] = num2;
                        
                        endPointer--;
                    }

                return true;
                }


                // Card Riffle shuffle  
                else if (typeOfShuffle == 2) 
                {
                    List<Card> leftPack = new List<Card>();

                    // Divides the pack into two
                    for (int i = 0; i < pack.Count / 2; i++) 
                    {
                        leftPack.Add(pack[i]);
                    }

                    Card[] rightArray = pack.GetRange((pack.Count / 2) - 1, pack.Count - (pack.Count / 2)).ToArray();
                    List<Card> rightPack = new List<Card>(rightArray);

                    pack.Clear();

                    // Merges two packs together
                    for(int i=0; i < leftPack.Count; i++)
                    {
                        pack.Add(leftPack[i]);
                        pack.Add(rightPack[i]);
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

                if (pack.Count > 0)
                {
                    Card card = pack[0];
                    pack.RemoveAt(0);
                    return card;
                }
                else {
                    return null; // returns null if there is no card to return
                }

            }


        public static void AddCard(Card card) // Returns a card to the pack (Additional Method)
        {
            pack.Add(card);
        }

        public static void AddCard(List<Card> cards) // Returns a list of card to the pack (Additional Method)
        {
            pack.AddRange(cards);
        }



        public static List<Card> DealCard(int amount) // Deals multiple cards from the deck
        {
            if(amount >= pack.Count) // Guard clause if user tries to deal more cards than is left in the pack -> will empty pack
            {
                amount = pack.Count;
            }

            List<Card> cards = new List<Card>();

            for(int i=0; i < amount; i++)
            {
                cards.Add(pack[0]);
                pack.RemoveAt(0);
            }
             
            return cards;
        }

    }

