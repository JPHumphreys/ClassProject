
namespace ClassProject
{
    public abstract class Personel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string Postcode { get; set; }

        protected abstract string SecurityAnswer1 { get; set; }
        protected abstract string SecurityAnswer2 { get; set; }
        public abstract string GetSecurityAnswer1();
    }
}
