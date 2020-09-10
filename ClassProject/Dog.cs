
namespace ClassProject
{
    public class Dog : Animal, IHousePet
    {
        public override int LegCount { get; set; }
        public string OwnerName { get; set; }

        public void AnnoyOwner()
        {
            System.Console.WriteLine("barf barf");
        }
        public override string Speak()
        {
            return "woof";
        }
    }
}
