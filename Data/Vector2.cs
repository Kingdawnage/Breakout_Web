namespace Breakout_Web.Data
{
    public class Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Length => (float)Math.Sqrt(X * X + Y * Y);
        public Vector2(float x, float y) { X = x; Y = y; }
        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X - v2.X, v1.Y - v2.Y);
        }
        public static Vector2 operator *(Vector2 v1, float f)
        {
            return new Vector2(v1.X * f, v1.Y * f);
        }
        public static Vector2 operator /(Vector2 v1, float f)
        {
            return new Vector2(v1.X / f, v1.Y / f);
        }
        public static Vector2 Normalize(Vector2 v)
        {
            return v / v.Length;
        }
        public static float DotProduct(Vector2 v1, Vector2 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public static Vector2 Rotate90(Vector2 vector2)
        {
            return new Vector2(-vector2.Y, vector2.X);
        }
    }
}
