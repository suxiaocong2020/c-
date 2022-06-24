using System;

namespace Lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 异常捕捉
            //异常捕捉
            //try
            //{
            //想要捕捉异常的代码
            //    string str = console.readline();
            //    int.parse(str);

            //}
            //catch
            //{
            //    console.writeline("请输入合法数字");
            //}
            #endregion

            #region 时间转换 练习
            // 987652 转为天时分秒
            int s = 987652 % 60;
            int m = (987652 / 60) % 60;
            int t = (987652 / 3600) % 24;
            int d = 987652 / (3600 * 24);
            //Console.WriteLine(d + "天\t" + t + "时\t" + m + "分\t" + s + "秒\t");

            //字符串拼接
            //string sba = string.Format("{0}天\t{1}时\t{2}分\t{3}秒\t", d, t, m, s);
            //Console.WriteLine(sba);
            
            //控制台默认调用
            Console.WriteLine("{0}天\t{1}时\t{2}分\t{3}秒\t",d,t,m,s);
            #endregion

            #region 三目运算符
            int a = 10;
            bool b = true;
            a=b ? 20 : 30;
            #endregion

            #region 绩效 练习
            int tang = 4000;
            Console.WriteLine("请输入唐老师的课程评级(A,B,C,D,E)");
            string lever = Console.ReadLine();
            switch (lever)
            {
                case "A":
                    tang += 500;
                    break;
                case "B":

                    break;
                case "C":
                    tang -= 300;
                    break;
                case "D":
                    tang -= 500;
                    break;
                case "E":
                    tang -= 800;
                    break;
                default:
                    Console.WriteLine("请输入有效评级(A,B,C,D,E)");
                    break;
                
            }
            Console.WriteLine("唐老师工资为:" + tang);
            #endregion

            #region 登录 练习
            string sxc = "suxiaocong";
            string poss = "12352";

            string inpna = "2";
            string inpps = "1";

            while (!(inpna==sxc&& inpps==poss))
            {
                Console.WriteLine("请玩家输入用户名");
                inpna = Console.ReadLine();
                Console.WriteLine("请玩家输入密码");
                inpps = Console.ReadLine();
                if (inpna != sxc || inpps != poss)
                {
                    Console.WriteLine("账户或密码输入错误 请重新输入");
                }

            }
            Console.WriteLine("suxiaocong登录成功");
            #endregion
        }
    }
}
