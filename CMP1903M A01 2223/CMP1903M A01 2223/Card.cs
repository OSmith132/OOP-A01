

class Card
{

    private int _value;
    private int _suit;

    public int Value
    {

        get { return _value; }
        set
        {
            if (value > 0 && value < 14) // has to be a valid value
            {
                _value = value;
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
                }
            } 

    }


    public Card(int value, int suit)
    {

        if (value > 0 && value < 14) // has to be a valid value
        {
            _value = value;
        } 
        else 
        {
            _value = 1; // Defaults to 1 if no a valid value
        }



        if (suit > 0 && suit < 5) // has to be a valid suit
        {
            _suit = suit;
        }
        else 
        { 
           _suit = 1; // Defaults to 1 if no a valid suit
        }

    }

}

