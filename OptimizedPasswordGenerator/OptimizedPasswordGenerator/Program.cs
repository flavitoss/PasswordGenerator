namespace OptimizedPasswordGenerator
{
     class Program
    {

        private static bool upper, lower, number, special;
        private static int passwordLenght;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to password Generator v2!!!!!");
            Console.WriteLine("Select your password size: ");
            passwordLenght = Convert.ToInt32(Console.ReadLine());

            upper = lower = number = special = true;

            Console.WriteLine("Here's your password:");
            Console.WriteLine(PasswordGenerate.GeneratePassword(upper, lower, number, special, passwordLenght));
        }
    }
    public static class PasswordGenerate 
    {
        private static string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string Numbers = "0123456789";
        private static string specialChars = "!@#$%¨&*()";

        public static string GeneratePassword(
            bool useUpper, 
            bool useLower,
            bool useNumbers,
            bool useSpecial,
            int passwordSize ) 
        {
            Random random = new Random();
            string charSet = string.Empty;
            char[] password = new char[passwordSize];

            if (useUpper) charSet += Upper;
            if (useLower) charSet += Upper.ToLower();
            if (useNumbers) charSet += Numbers;
            if (useSpecial) charSet += specialChars;

            for(int i  = 0; i < passwordSize; i++) 
            {
                password[i] = charSet[random.Next(charSet.Length - 1)];
            }

            return string.Join(null, password);
        }
    }
    
}