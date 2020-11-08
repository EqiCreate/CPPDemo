using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace TConsoleApp1
{
    class Program
    {

        static unsafe void Main(string[] args)
        {
            try
            {
                //IntPtr p= getfilememory(filepath);
                //string adr = Marshal.PtrToStringAnsi(p);
                //Console.WriteLine(adr);

                //TESTCsharp();

                //int res = add(1, 2);
                string filepath = "1.txt";
                //Console.WriteLine(res);

                //int hesum = simple_sum(3, 5);
                //Console.WriteLine(hesum);
                //float[] list = new float[10];
                bool dd;
                //for (int i = 1; i < 10; i++)
                //{
                //    list[i] += list[i - 1] + 1;
                //}
                //fixed (float * p= &list[0])
                //{ 
                //     dd = PassArrayTest(p,10);
                //}
                //dd = PassArrayTest(list, 10);
                //Console.WriteLine(dd);
                //float[][] list = new float[2][];
                //for (int i = 0; i < 2; i++)
                //{
                //    list[i] = new float[10];
                //}

                //float[,] list = new float[2, 10];
                //dd = Pass2DimensionArrayTest(list, 10);
                //Console.WriteLine(dd);
                //Console.WriteLine(list[1,1]);

                float[,] list = new float[2, 10];
                File2DimensionArrayTest(list,2,10, filepath);
                Console.WriteLine(list[1, 1]);
                Console.Read();
            }
            catch (Exception e)
            {
                throw;
            }
           
        }

        [DllImport("Dll1.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        extern static int add(int a, int b);
        [DllImport("Dll1.dll", EntryPoint = "getfilememory", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false)]
        extern static IntPtr getfilememory(string filepath);

        [DllImport("Dll1.dll", EntryPoint = "PassArrayTest", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false)]
        extern static bool PassArrayTest([Out, In]float[] list, int length);

        //[DllImport("Dll1.dll", EntryPoint = "PassArrayTest", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false)]
        //unsafe extern static bool PassArrayTest(float* list, int length);

        [DllImport("Dll1.dll", EntryPoint = "Pass2DimensionArrayTest", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false)]
        extern static bool Pass2DimensionArrayTest([Out, In]float[,] list, int length);

        //[DllImport("Dll1.dll", EntryPoint = "Pass2DimensionArrayTest", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false)]
        //extern static bool Pass2DimensionArrayTest([Out, In]float[][] list, int length);

        [DllImport("Dll1.dll", EntryPoint = "File2DimensionArrayTest", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false)]
        extern static bool File2DimensionArrayTest([Out, In]float[,] list, int row,int colum,string filepath);

        [DllImport("HE.dll", EntryPoint = "simple_sum", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false)]
        extern static int simple_sum(int a,int b);

        [DllImport("HE.dll", EntryPoint = "TESTCsharp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, ExactSpelling = false)]
        extern static void  TESTCsharp();
    }
}
