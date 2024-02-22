using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman");
            Console.WriteLine("The rules are simple. Guess the video game character, or the man will hang.");
            Console.WriteLine("Happy hanging! :)");
            Console.WriteLine(" ");



            //Notes: This is where you define/initialize the variables (define is the name, initialize is setting the data for the variable.)
            //Notes: creating an array of words that will be called for the hangman game
            string[] Games = new string[] { "mario", "zelda", "link" };

            //Notes: this int variable will set the number of guesses the player can have to 6
            int Guesses = 6;

            //Notes: This is the variable that initializes the random number generator
            Random rand = new Random();
            //Notes: this int variable called GameSelector which calls the random variable above and calls whatever number is selected, to call all of the games in the array, use Games.Length. 
            int GameSelector = rand.Next(Games.Length);

            //Notes: This string variable called Selected game is how the console will read which game is going to be selected
            string SelectedGame = Games[GameSelector];

            //Notes: This char array variable called answerbook is how the console what is being typed
            char[] answerBook = new char[SelectedGame.Length];
            //Gameplay loop starts below
            
            //Notes: This for is saying that the answer book index will add an extra underscore until the word is completed
            for (int answerBookIndex = 0;  answerBookIndex < answerBook.Length; answerBookIndex ++)
            {
                answerBook[answerBookIndex] = '_';
                
            }
       
            

            while (true)
            {
                for (int answerBookIndex = 0; answerBookIndex < answerBook.Length; answerBookIndex++)
                {
                    Console.Write(answerBook[answerBookIndex]);
                }
                Console.WriteLine();
                string playerinput = Console.ReadLine().ToLower();
                
                //Notes: "if the player input is not nothing and the first character the player inputs is also in the selected game in the array"
                if (playerinput != null && SelectedGame.Contains(playerinput[0]))
                {
                    Console.WriteLine("correct!");
                    int currentIndex = SelectedGame.IndexOf(playerinput[0]);
                    answerBook[currentIndex] = playerinput[0];
                }
                else
                {

                    Console.WriteLine("incorrect");
                    Guesses--;
                    Console.Write(Guesses);
                    //Code: when the input is wrong a portion of the stick person will appear until it is completed
                }
                if (answerBook.Contains('_') == false)
                {
                    Console.WriteLine("The man survives another round");
                    //Console.WriteLine("Play again?");
                    //Code: maybe another if statement in this statement that says if the players input is yes it will choose another word
                }
                //Code: another if statement that says if guess < 6 the console will say you killed him.
                if (Guesses == 0)
                {
                    Console.WriteLine("The Man has been hanged, you should feel bad");
                }
            }

            

           
            

            //use dictionary method for word hints
            
            
            //string word = Array[select];
        }
    }
}
