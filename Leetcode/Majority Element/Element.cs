namespace Element
{
    public class Pidor
    {
        public static int MajorityElement(int[] array)
        {
            int a = array[0];
            int b = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (b == 0)
                {
                    a = array[i];
                    b = 1;
                }
                else if(array[i] == a)
                {
                    b++;
                }
                else
                {
                    b--;
                }
            }

            return a;
        }
    }
}