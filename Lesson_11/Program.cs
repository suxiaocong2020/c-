using System;

namespace Lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #region 1~100所有偶数的和
            //int add = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        add += i;
            //    }
            //}
            //Console.WriteLine(add);
            #endregion

            #region 找出100~999之间的水仙花数、
            ////例：153 = 1x1x1 + 5x5x5 + 3x3x3
            //int A;
            //int B;
            //int C;
            //for (int i = 100; i < 999; i++)
            //{
            //    string ABC =  i.ToString();
            //    A = int.Parse( ABC.Substring(0, 1));
            //    B = int.Parse(ABC.Substring(1, 1));
            //    C = int.Parse(ABC.Substring(2));
            //    if ( i == A*A*A+B*B*B+C*C*C)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////-------------------------------------------

            //for (int i = 100; i < 999; i++)
            //{
            //    //用余数来取个十百位对应的数
            //    int A = i / 100;    //百位数
            //    int B = i % 100/10; //十位数
            //    int C = i % 10;     //个位数
            //    if (i == A * A * A + B * B * B + C * C * C)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            #endregion

            #region 打印九九乘法表
            //for (int x = 1; x <= 9; x++)
            //{
            //    for (int y = 1; y <= 9; y++)
            //    {
            //        Console.Write("{0}x{1}={2}\t",y,x,x*y);
            //        if (y>=x)
            //        {
            //            break;
            //        }
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 10*10空心方阵
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 1)
            //    {
            //        Console.WriteLine("**********");
            //    }
            //    else if (i == 10)
            //    {
            //        Console.WriteLine("**********");
            //    }
            //    else
            //    {
            //        Console.WriteLine("*        *");
            //    }
            //}
            #endregion

            #region 输出10*10三角形方阵
            //string add = "";
            //string sanjiao = "*";
            //for (int i = 1; i <=10; i++)
            //{
            //    add += sanjiao;
            //    Console.WriteLine(add);

            //}

            ////----------------------------------
            ///
            //for (int i = 1; i <=10; i++) 
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 输出10*10空心方阵

            ////           *
            ////          ***
            ////         *****
            ////        *******
            ////       *********
            ////      ***********
            ////     *************
            ////    ***************
            ////   *****************
            ////  *******************
            //for (int i = 1; i <=10; i++)  //行
            //{
            //    //列
            //    for (int n = 1; n <= 10-i; n++) //打印空格使得三角形对齐
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= 2*i-1 ; j++)  //高中学的等差数列 2n-1 [1,3,5,7,9,11....]
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //二级你噢俄海军哦i额黑iohj21
            #endregion

        }
    }
}
