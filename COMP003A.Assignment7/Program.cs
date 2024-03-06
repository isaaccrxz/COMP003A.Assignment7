/*
 * Author: Isaac Cruz
 * Course: COMP003A
 * Purpose: Basic Data Structors
 */
namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a single letter.");
            Console.ReadLine();
            

            Console.WriteLine("Insert a single word.");
            Console.ReadLine();

            List<string> names = new List<string>();
            char userInput = default;

            do
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Press any key to add more or (e) to exit.");
                Console.ReadLine(); 
                int userinput;
            }
            while (false);
        }

        void SectionSeparator()
        {
            string parameter;
        }

        void CharacterCounter(char characterInput, string word)
        {
            int count = 0;
            count += word.Length;
            characterInput = char.ToUpper(characterInput);
            word = word.ToLower();

        }

        void IsPalindrom(string word)
        {
            bool itWorked = true;
            itWorked = false;
            // come back to this
        }

        void TraverseList(List<string> list)
        {
            Console.WriteLine(list.Count);
        }


    }
}
