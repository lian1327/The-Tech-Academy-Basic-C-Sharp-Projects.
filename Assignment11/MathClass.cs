namespace Assignment11
{
    public class MathClass
    {
        public int x {get; set; }
        public int y {get; set; }

        public MathClass(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        public int getAdd()
        {
            return this.x + this.y;
        }

        public int getSub()
        {
            return this.x - this.y;
        }

        public int getAddFloat(float n1, float n2)
        {
            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);
            return num1 + num2;
        }

        public int getSubFloat(float n1, float n2)
        {
            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);
            return num1 - num2;
        }

        public int getFactorialFloat(float n1)
        {
            int fact = 1;
            int z = Convert.ToInt32(n1);
            
            for (int i = z; i<=1; i--)
            {
                fact = fact * i;
            }

            return fact;
        }

    }
}