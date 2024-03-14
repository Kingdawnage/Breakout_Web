using System.Drawing;

namespace Breakout_Web.Data
{
    public abstract class Brick : GameObject
    {
        public Vector2 Position { get; set; }
        public Vector2 Size { get; set; }
        public float CornerRadius { get; set; }

        //protected void Draw(Graphics g, Brush brush)
        //{
        //    var cR = CornerRadius;
        //    var cR2 = cR * 2;
        //    var hS = Size * 0.5f;
        //    g.FillRectangle(brush, Position.X - hS.X, Position.Y - hS.Y + cR, Size.X, Size.Y - cR2);
        //    g.FillRectangle(brush, Position.X - hS.X + cR, Position.Y - hS.Y, Size.X - cR2, Size.Y);
        //    g.FillEllipse(brush, Position.X - hS.X, Position.Y - hS.Y, cR2, cR2);
        //    g.FillEllipse(brush, Position.X - hS.X, Position.Y + hS.Y - cR2, cR2, cR2);
        //    g.FillEllipse(brush, Position.X + hS.X - cR2, Position.Y - hS.Y, cR2, cR2);
        //    g.FillEllipse(brush, Position.X + hS.X - cR2, Position.Y + hS.Y - cR2, cR2, cR2);
        //}
    }
}
