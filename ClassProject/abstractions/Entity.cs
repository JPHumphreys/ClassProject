
namespace ClassProject
{
    public abstract class Entity
    {
        protected abstract int Health { get; set; }
        protected abstract int pos_X { get; set; }
        protected abstract int pos_Y { get; set; }

        protected abstract void Test();

        public abstract void Jump();
        public abstract void Shoot();
    }
}
