namespace NguyenNgoBaoThy_31231021131
{
    internal class ExerciseU8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            //1. Print the input string
            Console.WriteLine("Input string: " + input);

            //2. Find the length of the string without using library function
            int length = 0;
            foreach (char c in input) length++;
            Console.WriteLine("Length of the string: " + length);

            //3. Separate individual characters
            Console.WriteLine("Individual characters: ");
            foreach (char c in input) Console.WriteLine(c);

            //4. Print characters in reverse order
            Console.WriteLine("Characters in reverse order: ");
            for (int i = length - 1; i >= 0; i--) Console.WriteLine(input[i]);
            Console.WriteLine();

            //5. Count the total number of words
            int wordCount = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("Total words: " + wordCount);

            //6. Compare two strings without using library function
            Console.WriteLine("Enter another string to compare: ");
            string compareString = Console.ReadLine();
            bool areEqual = input.Length == compareString.Length;
            if (areEqual)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != compareString[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }
            Console.WriteLine("Strings are " + (areEqual ? "equal" : "not equal"));

            //7. Count alphabets, digits, and special characters
            int alphabetCount = 0, digitCount = 0, specialCharCount = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c)) alphabetCount++;
                else if (char.IsDigit(c)) digitCount++;
                else specialCharCount++;
            }
            Console.WriteLine($"Alphabets: {alphabetCount}, Digits: {digitCount}, Special Characters: {specialCharCount}");

            //8. Count vowels and consonants
            int vowelCount = 0, consonantCount = 0;
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c)) vowelCount++;
                else if (char.IsLetter(c)) consonantCount++;
            }
            Console.WriteLine($"Vowels: {vowelCount}, Consonants: {consonantCount}");

            //9. Check if a substring is present
            Console.WriteLine("Enter a substring to check: ");
            string substring = Console.ReadLine();
            bool isSubstringPresent = false;
            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                if (input.Substring(i, substring.Length) == substring)
                {
                    isSubstringPresent = true;
                    break;
                }
            }
            Console.WriteLine($"Substring is {(isSubstringPresent ? "present" : "not present")}");

            //10. Search for the position of a substring
            int position = -1;
            for (int i = 0; i <= input.Length; i++)
            {
                if (input.Substring(i, substring.Length) == substring)
                {
                    position = i;
                    break;
                }
            }
            Console.WriteLine($"Position of substring: {position}");

            //11. Check whether a character is an alphabet and its case
            Console.WriteLine("Enter a character to check: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(ch))
            {
                Console.WriteLine($"Character '{ch}' is an alphabet and is {(char.IsUpper(ch) ? "uppercase" : "lowercase")}");
            }

            //12. Count occurrences of a substring
            int substringCount = 0;
            for (int i = 0; i <= input.Length-substring.Length; i++)
            {
                if (input.Substring(i,substring.Length) == substring)
                {
                    substringCount++;
                }
            }
            Console.WriteLine($"Substring '{substring}' appears {substringCount} times");

            //13. Insert a substring before the first occurrence of another substring
            Console.WriteLine("Enter the substring to insert: ");
            string insertString = Console.ReadLine();
            int insertPosition = input.IndexOf(substring);
            if (insertPosition != -1)
            {
                input = input.Substring(0, insertPosition) + insertString + input.Substring(insertPosition);
            }
            Console.WriteLine("String after insertion: " + input);
        }
    }
}
