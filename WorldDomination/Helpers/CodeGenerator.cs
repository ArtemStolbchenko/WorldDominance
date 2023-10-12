namespace WorldDomination.Helpers
{
    public static class CodeGenerator
    {
        private static List<string> codes = new List<string>();
        public static string GetCode()
        {
            Random random = new Random();
            string newCode;
            int i = 0;
            do
            {
                newCode = $"Get stick bugged {++i} {random.Next(15)} ";

            } while (codes.Contains(newCode));


            codes.Add(newCode);
            return newCode;
        }
        
    }
}
