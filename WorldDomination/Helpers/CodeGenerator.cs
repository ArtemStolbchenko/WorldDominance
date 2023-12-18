using System;

namespace WorldDomination.Helpers
{
    public static class CodeGenerator
    {
        private static List<string> codes = new List<string>();
        public static string GetCode()
        {
            string newCode;
            do
            {
                newCode = GenerateRandomCode();

            } while (codes.Contains(newCode));


            codes.Add(newCode);
            return newCode;
        }

        private static string GenerateRandomCode()
        {
            Random random = new Random();
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] codeArray = new char[6];

            for (int i = 0; i < codeArray.Length; i++)
            {
                codeArray[i] = characters[random.Next(characters.Length)];
            }

            return new string(codeArray);
        }
    }
}
