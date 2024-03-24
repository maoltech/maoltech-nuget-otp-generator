namespace maoltech_otp_generator
{
    public class Maoltech_Otp_Generator
    {
        private readonly string[] types = {
            "numeric", "alphanumeric", "alphabetic"
        };

        private readonly string[] characters = {
            "0123456789",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        };

        private readonly Random random = new Random();

        public string GenerateToken(int length, string type)
        {
            // Validate type
            if (Array.IndexOf(types, type) == -1)
            {
                throw new ArgumentException("Invalid token type");
            }

            string selectedCharacters = characters[Array.IndexOf(types, type)];

            // Generate token
            char[] token = new char[length];
            for (int i = 0; i < length; i++)
            {
                token[i] = selectedCharacters[random.Next(selectedCharacters.Length)];
            }

            return new string(token);
        }
    }
}
