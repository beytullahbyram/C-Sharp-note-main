using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrisler
{
	internal class Program
	{
		static void Main(string[] args)
		{
            #region multidimensional array sample 1
            /**
			1111
			1212
			1212
			1111
			**/
            //int[] arr = new int[5];
            //int[,] arr2b = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //	for (int j = 0; j < 5; j++)
            //	{
            //		if (i == 0 || i == 4)
            //		{
            //			arr2b[i, j] = 1;
            //		}
            //		else
            //		{
            //			if(j % 2 != 0)
            //			{
            //				arr2b[i, j] = 2;

            //			}
            //			else
            //			{
            //				arr2b[i, j] = 1;

            //			}
            //		}

            //	}
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //	for (int j = 0; j < 5; j++)
            //	{
            //		Console.Write(arr2b[i, j]);

            //	}
            //	Console.WriteLine();
            //}
            //Console.ReadLine();

            #endregion

            #region Sample 2
            Console.Clear();
            Console.WriteLine("------------------");
            //Console.WriteLine("-----");
            //int[,] arr2b2 = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //	for (int j = 0; j < 5; j++)
            //	{
            //		if (i % 2 == 0 && j == 1 || j ==4)
            //		{
            //			arr2b2[i, j] = 1;

            //		}else if (i % 1 ==0 && j == 0 || j == 4)
            //                 {
            //			arr2b2[i, j] = 2;

            //                 }


            //	}
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //	for (int j = 0; j < 5; j++)
            //	{
            //		Console.Write(arr2b2[i, j]);

            //	}
            //	Console.WriteLine();
            //}
            //Console.ReadLine();

            #endregion

            #region Sample 3

            //Console.WriteLine("-----------------------");
            //int[,] arr2b3 = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //	for (int j = 0; j < 5; j++)
            //	{
            //		if(i == j || i+j==4)
            //                 {
            //			arr2b3[i, j] = 1;	
            //                 }	

            //	}
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //	for (int j = 0; j < 5; j++)
            //	{
            //		Console.Write(arr2b3[i, j]);

            //	}
            //	Console.WriteLine();
            //}
            //Console.ReadLine();

            #endregion

            #region Sample 4
            Console.Clear();
            Console.WriteLine("------------------");
            //int[,] matrix = new int[2,4];

            //for (int i = 0; i < 2; i++)
            //{

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("Enter number");
            //        int input = Convert.ToInt32(Console.ReadLine());
            //        matrix[i,j] = input;
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    int sum = 0;
            //    for (int j = 0; j <4 ; j++)
            //    {
            //        sum += matrix[i,j];
            //    }
            //    matrix[i,3] = sum;   
            //}


            //for (int i = 0; i < 2; i++)
            //{

            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(matrix[i, j]+ "");

            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            #endregion

            #region Sample 5
            /*
            5x5 Matrix'e random sayı atılsın
            Her sütun bazında en küçük ve en büyük sayı bulunsun
             */
            Console.Clear();
            Console.WriteLine("------------------");

            int[,] matrixRandom=new int[5,5];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrixRandom[i,j]= rand.Next(1, 10);
                }
            }

            Console.WriteLine("Print");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrixRandom[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Control");

            int[] big = new int[5];
            int[] small = new int[5];


            //Control big number
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(big[j] < matrixRandom[i,j])
                    {
                        big[j] = matrixRandom[i,j];
                    }
                    small[j] = big[j];

                }

            }
            //Control small number
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (small[j] > matrixRandom[i, j])
                    {
                        small[j] = matrixRandom[i, j];
                    }
                }

            }
            for (int i = 0; i < 5; i++) Console.WriteLine($"{i}. small {small[i]}  big {big[i]} ");  
            #endregion
            
            

        }
    }
}
