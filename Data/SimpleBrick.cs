using System.Drawing;

namespace Breakout_Web.Data
{
    class SimpleBrick : Brick
    {
        //public override void Draw(Graphics g)
        //{
        //    Draw(g, Brushes.Blue);
        //}

        public override void OnHit()
        {
            Deleted = true;
        }
    }
}
