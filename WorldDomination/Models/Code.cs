using WorldDomination.Helpers;

namespace WorldDomination.Models
{
    public class Code
    {
        private readonly string _code;
        //public Country AssignedCountry { get; set; } = new Country();
        public Code(string code)
        {
            _code = code;
        }
        public Code()
        {
            _code = CodeGenerator.GetCode();
        }

        /*public bool AssignCountry(Country country)
        {
            if (this.AssignedCountry != null  todo: or if the given country is already assigned )
            {
                return false;
            }
            this.AssignedCountry = country;
            return true;
        }*/

        public override string ToString()
        {
            return _code;
        }
    }
}
