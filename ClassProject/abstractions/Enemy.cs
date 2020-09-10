
namespace ClassProject
{
    public class Enemy : Entity
    {
        protected override int Health { get; set; }
        protected override int pos_X { get; set; }
        protected override int pos_Y { get; set; }

        protected override void Test()
        {

        }

        public override void Shoot()
        {
            throw new System.NotImplementedException();
        }

        public override void Jump()
        {
            throw new System.NotImplementedException();
        }
    }
}
