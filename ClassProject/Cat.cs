
namespace ClassProject
{
    public class Cat : Animal, IHousePet
    {
        public Cat()
        {
            LegCount = 4;
        }

        public Cat(int num)
        {
            LegCount = num;
        }

        public Cat(string ownerName)
        {
            OwnerName = ownerName;
        }

        public override int LegCount { get; set; }
        public string OwnerName { get ; set ; }
        bool IsMeowing { get; set; }

        public void AnnoyOwner()
        {
            System.Console.WriteLine("moo");
        }

        public override string Speak()
        {
            return "moo";
        }
    }
}
