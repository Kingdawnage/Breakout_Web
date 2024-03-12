using System.Drawing;

namespace Breakout_Web.Data
{
    public abstract class GameObject
    {
        public bool Deleted { get; set; }
        public virtual bool Update(float dT) { return false; }
        public virtual bool DetectAndResolveCollision(GameObject other) { return false; }
        public virtual void OnHit() { }
        //public abstract void Draw(Graphics g);
    }
}
