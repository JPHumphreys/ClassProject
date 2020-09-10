
namespace ClassProject
{
    public class Seagull : Animal
    {
        public Seagull()
        {
            LegCount = 2;
        }
        public override int LegCount { get; set; }
        public override string Speak()
        {
            return "HEHWUICHIEH8HIEH";
        }
    }
}
