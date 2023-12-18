namespace WorldDomination.Helpers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection.Emit;
    using System.Reflection.Metadata.Ecma335;
    using WorldDomination.Databases;
    using WorldDomination.Models;
    public class CodeManager
    {
        private readonly AppDbContext _dbContext;
        public CodeManager(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Verify(string code)
        {
            List<string> codes = _dbContext.CodesString;
            return codes.Contains(code);
        }
        public string GetCode()
        {
            Code newCode = new Code();
            _dbContext.Add(newCode);
            _dbContext.SaveChanges();

            return newCode.ToString();
        }
    }
}
