namespace hijulia
{
    public class alphabetChecker
    {
        static bool checkLetters(string input)
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            List<char> used = new List<char>();
            int total = 0;

            string input2 = input.ToUpper();
            for (int i = 0; i < input.Length; i++)
            {
                if (alphabet.Contains(input2[i]) && !used.Contains(input2[i]))
                {
                    used.Add(input2[i]);
                    total++;
                }
            }
            if (total == 26)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(new alphabetChecker().checkLetters(input));
        }


    }
}
