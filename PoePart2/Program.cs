using System;
using System.Collections.Generic;
using System.Media;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGreetingSound();

            Chatbot bot = new Chatbot();

            // ASCII Art - Cybersecurity Shield with Lock
            Console.WriteLine(@"
   ____       _               ____            _   
  / ___|  ___| |_ _   _ _ __ | __ )  __ _  __| |  
  \___ \ / _ \ __| | | | '_ \|  _ \ / _` |/ _` |  
   ___) |  __/ |_| |_| | |_) | |_) | (_| | (_| |_ 
  |____/ \___|\__|\__,_| .__/|____/ \__,_|\__,_(_)
                       |_|                       
           [ CyberSecBot – Stay Safe Online ]
");

            Console.WriteLine("CyberSecBot: Hello! I'm here to help you stay safe online. Ask me anything about cybersecurity!");

            while (true)
            {
                Console.Write("You: ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput)) continue;

                if (userInput.ToLower() == "exit" || userInput.ToLower() == "bye" || userInput.ToLower() == "quit")
                {
                    Console.WriteLine("CyberSecBot: Stay safe online. Goodbye!");
                    break;
                }

                string response = bot.GetResponse(userInput);
                Console.WriteLine($"CyberSecBot: {response}");
            }
        }

        // ✅ Plays the "sound greeting.wav" file
        static void PlayGreetingSound()
        {
            try
            {
                string filePath = @"sound greeting.wav"; // Or @"C:\Path\To\sound greeting.wav"
                SoundPlayer player = new SoundPlayer(filePath);
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error playing sound: " + ex.Message);
            }
        }
    }

    // 🧠 Ensure this Chatbot class is defined in the same project or referenced properly
    class Chatbot
    {
        // Your Chatbot class implementation...
        public string GetResponse(string input)
        {
            return "Sample response (implement your logic)";
        }
    }
}
