using System;

namespace isogram
{
    public class isogram
    {
        public static bool isIsogram(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            for (int i = 0; i<str.Length - 1; i++) {
                 if (arr[i] == arr[i + 1] && arr[i] != '-')
                        return false;
            }
            return true;
        }
    }
}
