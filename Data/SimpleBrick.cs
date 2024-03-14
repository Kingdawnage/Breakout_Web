namespace Breakout_Web.Data
{
    public class SimpleBrick : Brick
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
