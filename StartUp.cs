namespace FunnyRandomSentencesGenerator
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Hi what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("Press [Enter] if you want to have a bit of fun.");

            Console.ReadLine();

            string[] names = { "Peter", "Michell", "Jane", "Steve", "Niko", "Nikol", "Aurora", "Kate", "Andrew" };
            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas", "Dupnitsa", "Mars" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes", "book", "smartphone" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "at home", "in the park", "at the gym", "at school" };

            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(details);

                Console.WriteLine($"{randomName} from {randomPlace} {randomAdverb} {randomVerb} {randomNoun} {randomDetail}.");
                Console.WriteLine("Press [Enter] to generate a new one.");

                Console.ReadLine();
            }
        }

        static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
    }
}