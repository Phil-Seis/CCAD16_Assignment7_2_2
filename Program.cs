/*Given a string s, reverse only all the vowels in the string and return it.
 * The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
 * Example 1:
    * Input: s = "hello"
    * Output: "holle"
 * Example 2:
    * Input: s = "avacado"
    * Output: "ovacada"
 * Example 3: 
    * Input: “intelligent”-à   i , e, i, e
    * Output: entillegint
*/

namespace CCAD16_Assignment7_2_2
{
    class ReverseVowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();

            string result = ReverseVowelsInString(s);

            Console.WriteLine($"Reversed vowels string: {result}");
        }

        static string ReverseVowelsInString(string s)
        {
            //Define the vowels (used upper and lower for ease)
            string vowels = "aeiouAEIOU";

            //Convert the string to a char array
            char[] chars = s.ToCharArray();

            // declare two pointers to make it less complex
            int left = 0;
            int right = chars.Length - 1;

            // while loop to traverse the string
            while (left < right)
            {
                // Move the left pointer forward until a vowel is found
                while (left < right && !vowels.Contains(chars[left]))
                {
                    left++;
                }

                // Move the right pointer backward until a vowel is found
                while (left < right && !vowels.Contains(chars[right]))
                {
                    right--;
                }

                // Swap the vowels at each pointer
                if (left < right)
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;

                    // Move pointers
                    left++;
                    right--;
                }
            }

            // Return the new string with swapped vowels
            return new string(chars);
        }
    }
}
