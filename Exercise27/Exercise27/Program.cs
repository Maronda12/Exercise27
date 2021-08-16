using System;

namespace Exercise27
{
    class Program
    {
        static void Main(string[] args)
        {

            bool goOn = true;
            while (goOn == true)
            {


                Console.WriteLine("Please enter some text.");

                string text = Console.ReadLine();


                int vowels = 0;
                int consonant = 0;



                //Checks for both Vowels/Consonants but only print Consonants
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u' || text[i] == 'A' || text[i] == 'E' || text[i] == 'I' || text[i] == 'O' || text[i] == 'U')
                    {
                        vowels++;
                    }

                    else
                    {
                        consonant++;
                    }
                }
                Console.WriteLine("The total number of constant is: {0}", consonant);

                goOn = GetContinue(); // Calls Continue Method
            }

            }
            public static bool GetContinue()
            {
                Console.WriteLine("Would you like to continue? y/n");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    return true;
                }
                else if (answer == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("I didn't understand that, please try again");

                    return GetContinue();
                }
            }


        
    }




}

        
    
    

