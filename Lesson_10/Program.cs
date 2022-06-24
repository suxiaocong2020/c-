using System;

namespace Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 打印1到100
            //int i = 0;
            //while (i < 100)
            //{
            //    ++i;
            //    console.writeline(i);
            //}
            #endregion

            #region 输出1到100之间所有整数和
            //int i = 0;
            //int add = 0;
            //while (i<100)
            //{
            //    ++i;
            //    add += i;

            //}
            //Console.WriteLine(add);


            //int add = 0;
            //for (int i = 0; i <= 100; ++i)
            //{
            //    add += i;
            //}
            //Console.WriteLine(add);
            #endregion

            #region 1到100被7整除之外的数的和
            //int i = 0;
            //int add = 0;
            //while (i<100)
            //{
            //    ++i;
            //    if (i % 7 == 0)
            //    {
            //        continue;
            //    }
            //    add += i;
            //}
            //Console.WriteLine(add);

            #endregion

            #region 判断输入是否为素数
            //for (; ; )
            //{
            //    try
            //    {
            //        Console.WriteLine("请输入一个数字");
            //        int inpu = int.Parse(Console.ReadLine());

            //        int i = 2;
            //        while (i < inpu)
            //        {
            //            if (inpu % i == 0)
            //            {
            //                break;
            //            }
            //            ++i;
            //        }
            //        if (i != inpu)
            //        {
            //            Console.WriteLine("不是质数");
            //        }
            //        if (i == inpu)
            //        {
            //            Console.WriteLine("是质数");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请正确输入");
            //    }

            //}

            #endregion

            #region 班级成绩平均数
            //for (; ; )
            //{
            //    try
            //    {
            //        Console.WriteLine("请输入班级人数");
            //        int nbPeople = int.Parse(Console.ReadLine());
            //        int i = 0;
            //        int scoreAdd = 0;
            //        while (i < nbPeople)
            //        {
            //            ++i;
            //            Console.WriteLine("号数" + i + ":的成绩为");
            //            int score = int.Parse(Console.ReadLine());
            //            scoreAdd += score;
            //        }
            //        Console.WriteLine("班级总成绩为：{0}\n班级平均分为：{1}", scoreAdd, scoreAdd / nbPeople);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入正确的数据");
            //    }
            //}
            #endregion

            #region 1到100累加值大于500时是第几个数
            //int add = 0;
            //int i = 0;
            //for (; i < 100;)
            //{
            //    ++i;
            //    add += i;
            //    if (add > 500)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("累加到第{0}位数时和大于500",i);
            #endregion

            #region 看唐老师视频100人 每月增长20% 几个月后人数达到1000
            //float tangPeople = 100;
            //int i = 0;
            //while (true)
            //{
            //    ++i;
            //    tangPeople *= 1.2f;
            //    if (tangPeople >= 1000)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("{0}个月后看唐老狮视频能达到1000人\n人数为{1}", i, (int)tangPeople);
            #endregion

            #region 斐波那契数列 1 1 2 3 5.....第二十位的是多少
            ////从第三项开始值为前两项相加
            //int n1 = 1;
            //int n2 = 1;
            ////构造一个可以执行二十次的循环
            //int i = 0;
            //int result = 0;
            //for (; i < 20;)
            //{
            //    ++i;
            //    if (i == 1)  //第一项为1固定不变
            //    {
            //        result = n1;
            //    }
            //    else if (i == 2)  //第二项为1固定不变
            //    {
            //        result = n2;
            //    }
            //    else
            //    {
            //        result = n1 + n2;  //第三项为前两项之和
            //        n1 = n2;           //第二项
            //        n2 = result;       //第三项
            //    }
            //}
            //Console.WriteLine(result);
            #endregion

            #region 找出100内所有素数
            ////从2开始取余 如果中途整除了 证明不是素数
            ////如果累加到和自己一样的数 证明是素数
            //int num = 2;
            //while (num < 100)
            //{
            
            //    int sushu = 2;
            //    while (sushu< num)
            //    {
            //        if (num % sushu == 0) 
            //        {
            //            break;
            //        }
            //        ++sushu;
            //    }
            //    if (sushu == num)
            //    {
            //        Console.WriteLine(num);
            //    }
            //    ++num;
            //}
            #endregion
        }
    }
}
