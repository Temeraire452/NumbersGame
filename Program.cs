namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            Random random = new Random(); // Väljer ett slumpmässigt nummer mellan 1-20
            int number = random.Next(1, 20);

            int numberTry = 0; // Håller koll på antalet försök
            bool rightAnswer = false; 

            while (numberTry < 5) // Loop för max 5 försök
            {
                Console.WriteLine("Gissa på ett nummer mellan 1-20: ");
                String guess = Console.ReadLine();
                int userAnswer = Convert.ToInt32(guess);

                numberTry++;

                if (CheckGuess(userAnswer, number)) // Kollar om numret stämmer med funktionen
                {
                    rightAnswer = true;
                    break; // Avslutar loopen om rätt number skrivits
                }
                else
                {
                    if (userAnswer > number) // Om fel nummer skrivits meddelas användaren om det är för högt/lågt
                    {
                        Console.WriteLine("Tyvärr, du gissade för högt!");
                    }
                    else
                    {
                        Console.WriteLine("Tyvärr, du gissade för lågt!");
                    }
                }
            }

            if (rightAnswer) // Skriver ett meddelande för rätt svar och ett annat om man använt alla 5 försök
            {
                Console.WriteLine("Wohoo! Du klarade det!");
            }
            else
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
            }

        }

        static bool CheckGuess(int guess, int number) // Funktion för att se om numret är rätt/fel
        {
            return guess == number;
        }
    }
}