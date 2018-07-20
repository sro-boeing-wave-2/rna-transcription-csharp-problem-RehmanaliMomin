using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {

            /*
             *G -> C
            C -> G
            T -> A
            A -> U
            */

            char[] arr = nucleotide.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 'A':
                        arr[i] = 'U';
                        break;
                    case 'T':
                        arr[i] = 'A';
                        break;
                    case 'C':
                        arr[i] = 'G';
                        break;
                    case 'G':
                        arr[i] = 'C';
                        break;
                }
            }

            return new string(arr);



            //string s = nucleotide.Replace('A', 'U');
            //s = s.Replace('T', 'A');
            //s = s.Replace('C', 'G');
            //s = s.Replace('G', 'C');

            //foreach (char c in arr)
            //{
            //    switch (c)
            //    {
            //        case 'G':
            //        default:
            //            break;
            //    }
            //}
            

        }
    }
}
