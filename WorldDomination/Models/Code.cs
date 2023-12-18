using System.ComponentModel.DataAnnotations;
using WorldDomination.Helpers;

namespace WorldDomination.Models
{
    public class Code
    {
        [Key]
        public int Id { get; set; }
        public string code { get; set; }
        //public Country AssignedCountry { get; set; } = new Country();
        public Code(string code)
        {
            this.code = code;
        }
        public Code()
        {
            code = CodeGenerator.GetCode();
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
            return code;
        }
    }
}
