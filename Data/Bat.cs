using System.Drawing;

namespace Breakout_Web.Data
{
    class Bat : GameObject
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Speed { get; set; }
        public float Width { get; set; }

        public override bool Update(float dT)
        {
            X += Speed * dT;
            return true;
        }
        //public override void Draw(Graphics g)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
