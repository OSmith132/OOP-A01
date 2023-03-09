

using System;

class Card
{

    private int _value; // Example of encapsulation
    private int _suit;
    private string _name;

    public int Value
    {

        get { return _value; }
        set
        {
            if (value > 0 && value < 14) // has to be a valid value
            {
                _value = value;
                ChangeName();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(_value), "value must be in the range 1 to 13");
            }
        }

    }

    public int Suit 
    { 

        get { return _suit; } 
        set { 
                if (value > 0 && value < 5) // has to be a valid suit
                {
                    _suit = value;
                    ChangeName();
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(_suit), "suit must be in the range 1 to 4");
                }
            } 

    }

    public string Name
    {
        get { return _name; }
    }


    public Card(int value, int suit)
    {

        if (value > 0 && value < 14) // has to be a valid value
        {
            _value = value;
        } 
        else 
        {
            throw new ArgumentOutOfRangeException(nameof(_value), "value must be in the range 1 to 13");
        }



        if (suit > 0 && suit < 5) // has to be a valid suit
        {
            _suit = suit;
        }
        else 
        {
            throw new ArgumentOutOfRangeException(nameof(suit), "suit must be in the range 1 to 4");
        }


        ChangeName();

    }

    private void ChangeName() // to change the _name value of a card
    {
        string valueName;
        string suitName;

        switch(_value){

            case 1:
                valueName = "Ace";
                break;

            case 2:
                valueName = "Two";
                break;

            case 3:
                valueName = "Three";
                break;

            case 4:
                valueName = "Four";
                break;

            case 5:
                valueName = "Five";
                break;

            case 6:
                valueName = "Six";
                break;

            case 7:
                valueName = "Seven";
                break;

            case 8:
                valueName = "Eight";
                break;

            case 9:
                valueName = "Nine";
                break;

            case 10:
                valueName = "Ten";
                break;

            case 11:
                valueName = "Jack";
                break;

            case 12:
                valueName = "Queen";
                break;

            case 13:
                valueName = "King";
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(_value), "Card value must be in the range 1 to 13");
        }

        switch (_suit)
        {
            case 1:
                suitName = "Spades";
                break;

            case 2:
                suitName = "Clubs";
                break;

            case 3:
                suitName = "Hearts";
                break;

            case 4:
                suitName = "Diamonds";
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(_suit), "Card suit must be in the range 1 to 4");
        }

        _name = valueName + " of " + suitName; // names the card accordingly
    }

}

