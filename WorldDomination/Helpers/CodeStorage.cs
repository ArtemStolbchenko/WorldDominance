using WorldDomination.Models;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace WorldDomination.Helpers
{
    public class CodeStorage
    {
        private List<Code> _codes;

        public CodeStorage()
        {
            _codes = new List<Code>();
        }
        public bool VerifyCode(string code)
        {
            return containsCode(code);
        }
       /* public bool TryRegisterCode()
        {
            string code;

            if (!containsCode(code))
            {
                Code _newCode = new Code(code);
                _codes.Add(new Code(code));
                return true;
            }
            return false;
        }*/
        private bool containsCode (string code) {
            if (_codes.Any(c => c.ToString() == code))
                return true;
            else return false;
        }
    }
}
