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
            var generate = PasswordGenerate.GeneratePassword(upper, lower, number, special, passwordLenght);
            Console.WriteLine("Here's your password:");
            Console.WriteLine(generate);

            //validate password
            if(generate.Length < 12) 
            {
                Console.WriteLine("invalid password! your password must have at least 12 characters, 1 upper, 1 number and 1 special character");
            } 

            if(upper = lower = number = special = false) 
            {
                Console.WriteLine("invalid password! your password must have at least 12 characters, 1 upper, 1 number and 1 special character");
            }

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

            foreach(char u in Upper) 
            {
                if (!charSet.Contains(Upper)) 
                {
                    Console.WriteLine("invalid password! your password must have at least 12 characters, 1 upper, 1 number and 1 special character");
                    break;
                }
            }

            foreach(char n in Numbers) 
            {
                if (!charSet.Contains(Numbers))
                {
                    Console.WriteLine("invalid password! your password must have at least 12 characters, 1 upper, 1 number and 1 special character");
                }
            }

            foreach(char s in specialChars) 
            {
                if (!charSet.Contains(specialChars)) 
                {
                    Console.WriteLine("invalid password! your password must have at least 12 characters, 1 upper, 1 number and 1 special character");
                }
            }

            return string.Join(null, password);
        }
    }
    
}