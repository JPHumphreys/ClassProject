
namespace ClassProject.abstractions
{
    public class Customer : Personel
    {
        protected override string SecurityAnswer1 { get; set; }
        protected override string SecurityAnswer2 { get; set; }

        private float BankBalance { get; set; }

        public override string GetSecurityAnswer1()
        {
            throw new System.NotImplementedException();
        }
    }
}
