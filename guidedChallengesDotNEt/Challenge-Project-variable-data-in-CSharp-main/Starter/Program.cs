using System;

// ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;
string[] multiplesDogCharacteristic = new string[0];


// array used to store runtime data
string[,] ourAnimals = new string[maxPets, 7];

// sample data ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "lion";
            suggestedDonation = "";

            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;

    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
    }
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

// top-level menu options
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }

            Console.WriteLine("\r\nPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // #1 Display all dogs with a multiple search characteristics

            string dogCharacteristic = "";

            while (dogCharacteristic == "")
            {
                // #2 have user enter multiple comma separated characteristics to search for
                Console.WriteLine($"\r\nEnter one or more(separated by coma) desired dog characteristic to search for");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristic = readResult.ToLower().Trim();
                    Console.WriteLine();
                }
                // transformando o input em array
                multiplesDogCharacteristic = dogCharacteristic.Split(",");

                // limpando possiveis "espaços"
                for (int i = 0; i < multiplesDogCharacteristic.Length; i++)
                {
                    multiplesDogCharacteristic[i] = multiplesDogCharacteristic[i].Trim().ToLower();
                    // Console.WriteLine(multiplesDogCharacteristic[i]);
                }
                //deixando em ordem
                Array.Sort(multiplesDogCharacteristic);


            }
            bool noMatchesCharacteristic = true;
            bool noMatchesDog = true;
            string dogDescription = "";

            // #4 update to "rotating" animation with countdown
            string[] searchingIcons = { " 3", " 2", " 1", " 0" };
            string[] rotatingIcon = { "/", "--", "\\", "|" };
            // loop ourAnimals array to search for matching animals
            for (int i = 0; i < maxPets; i++)
            {

                if (ourAnimals[i, 1].Contains("dog"))
                {
                    noMatchesCharacteristic = true;

                    // retirando o "nickname" a fim de melhorar visualização
                    string rawName = ourAnimals[i, 3];
                    string dogName = rawName.Replace("Nickname: ", "");

                    // Search combined descriptions and report results
                    dogDescription = ourAnimals[i, 4] + "\r\n" + ourAnimals[i, 5];

                    //for (int j = 2; j > -1; j--)
                    //{
                    // #5 update "searching" message to show countdown 
                    for (int k = 0; k < multiplesDogCharacteristic.Length; k++)
                    {
                        foreach (string icon in searchingIcons)
                        {
                            foreach (string icon2 in rotatingIcon)
                            {
                                Console.Write($"\rsearching... {multiplesDogCharacteristic[k].PadRight(10)} {icon2.PadRight(3)} {icon}");
                                Thread.Sleep(250);
                                Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                            }
                        }

                        //                            }
                        //}
                        if (dogDescription.Contains(" " + multiplesDogCharacteristic[k] +" "))
                        {
                            // #3b update message to reflect term 
                            // #3c set a flag "this dog" is a match
                            Console.WriteLine($"\nOur dog {dogName} is a {multiplesDogCharacteristic[k]} match!");
                            noMatchesCharacteristic = false;
                            noMatchesDog = false;

                        }
                    }
                    // #3d if "this dog" is match write match message + dog description
                    if (noMatchesCharacteristic == false)
                    {
                        Console.WriteLine($"{ourAnimals[i, 3]} ({ourAnimals[i, 0]})");
                        Console.WriteLine($"{ourAnimals[i, 4]}");
                        Console.WriteLine($"{ourAnimals[i, 5]}");
                    }


                    // #3a iterate submitted characteristic terms and search description for each term

                    /* if (dogDescription.Contains(multiplesDogCharacteristic[i]))
                     {
                         // #3b update message to reflect term 
                         // #3c set a flag "this dog" is a match
                         Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");

                         noMatchesDog = false;
                     }*/


                }
            }

            if (noMatchesDog)
            {
                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
            }

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        default:
            break;
    }

} while (menuSelection != "exit");
