namespace Prefix
{
    public class Ivan
    {
        public static string CommonPrefix(string[] strs)
        {
            string prefix = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[i][j] != strs[0][j])
                    {
                        return prefix;
                    }
                }

                prefix += strs[0][i];
            }

            return prefix;
        }
    }
}