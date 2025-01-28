namespace Assignment10
{
    public class MathClass
    {
        public float x { get; set; }
        public float y { get; set; }

        public MathClass(float X, float Y)
        {
            this.x = X;
            this.y = Y; 
        }

        public float getAdd()
        {
            return x + y;
        }

        public float getQuotient()
        {
            return this.x / this.y;
        }

        public int Factorial(int z)
        {
            int fact = 1;
            for (int i = z; i > 0; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
