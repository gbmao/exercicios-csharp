/*Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

Console.WriteLine("A fortune teller whispers the following words:");


TellFortune();



void TellFortune()
{
if (luck > 75)
{
    Console.WriteLine(text[RandomTextNumber()] + " " + good[RandomTextNumber()]);
}
else if (luck > 25 )
{
    Console.WriteLine(text[RandomTextNumber()] + " " + neutral[RandomTextNumber()]);
}
else
{
    Console.WriteLine(text[RandomTextNumber()] + " " + bad[RandomTextNumber()]);    
}
}



int RandomTextNumber()
    {
        Random randomText = new Random();
        return randomText.Next(0, 4);
    }



*/

Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

TellFortune();

void TellFortune() 
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}