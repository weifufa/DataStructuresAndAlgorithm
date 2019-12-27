using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    //enum Color { 红桃 = -1, 黑桃 = -2, 梅花 = -3,方块= -1 }//花色
    //enum Point { A, two, three, four, five, six, seven, eghit, nine, ten, J, Q, K }//点数
    //struct Poker
    //{
    //    //扑克
    //    private string p1, p2;
    //    public Poker(string p1, string p2)
    //    {
    //        this.p1 = p1;
    //        this.p2 = p2;
    //    }
    //    public void Printp()
    //    {
    //        Console.Write("{0},{1}", this.p1, this.p2);
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            var Point = new string[]
     {
                              "A", "2", "3", "4", "5", "6", "7", "8", "9", "10","J", "Q", "K",
     };
            var Color = new string[]
            {
                              "红桃", "黑桃", "方片", "梅花",
            };
            var list = Enumerable.Range(0, 52) //生成52张牌
                    .OrderBy(p => Guid.NewGuid()); //随机乱序
            var n = 0;
            foreach (var x in list)
            {
                Console.Write("{0}{1} ", Color[(int)(x / 13)], Point[x % 13]);
                if ((++n) % 13 == 0) Console.WriteLine(" ");
            }
            Console.Read();
            //Poker po = new Poker();
            //ArrayList myPoker = new ArrayList();
            //ArrayList Person1 = new ArrayList();
            //ArrayList Person2 = new ArrayList();
            //ArrayList Person3 = new ArrayList();
            //ArrayList Person4 = new ArrayList();
            //Random r = new Random();
            //for (int i = -4; i <= -1; i++)
            //{
            //    //外循环扑克花色
            //    for (int j = 0; j <= 12; j++)
            //    {
            //        //外层循环扑克点数
            //        myPoker.Add(new Poker(
            //            Enum.GetName(typeof(Color), i),
            //            Enum.GetName(typeof(Point), j)));
            //    }

            //}
            //Console.WriteLine("打印所有扑克牌:");

            //for (int i = 0; i < 52; i++)
            //{//打印52张生成的扑克牌  
            //    Poker poAll = (Poker)myPoker[i];
            //    poAll.Printp();
            //}
            ////开始发牌，一个人一个人的发，每发一张牌得从myPoker中RemoveAt掉扑克牌，Count数减小；第一个人Add到一张牌。  
            //for (int i = 0; i < 13; i++)
            //{
            //    int te = r.Next(0, myPoker.Count);
            //    Person1.Add(myPoker[te]);
            //    myPoker.RemoveAt(te);
            //}
            //for (int i = 0; i < 13; i++)
            //{
            //    int te = r.Next(0, myPoker.Count);
            //    Person2.Add(myPoker[te]);
            //    myPoker.RemoveAt(te);
            //}
            //for (int i = 0; i < 13; i++)
            //{
            //    int te = r.Next(0, myPoker.Count);
            //    Person3.Add(myPoker[te]);
            //    myPoker.RemoveAt(te);
            //}
            //for (int i = 0; i < 13; i++)
            //{
            //    int te = r.Next(0, myPoker.Count);
            //    Person4.Add(myPoker[te]);
            //    myPoker.RemoveAt(te);
            //}

            //Console.WriteLine();
            //Console.WriteLine("打印第一个人的扑克牌：");
            //for (int i = 0; i < 13; i++)
            //{
            //    Poker po1 = (Poker)Person1[i];
            //    po1.Printp();
            //}
            //Console.WriteLine();
            //Console.WriteLine("打印第二个人的扑克牌：");
            //for (int i = 0; i < 13; i++)
            //{
            //    Poker po2 = (Poker)Person2[i];
            //    po2.Printp();
            //}
            //Console.WriteLine();
            //Console.WriteLine("打印第三个人的扑克牌：");
            //for (int i = 0; i < 13; i++)
            //{
            //    Poker po3 = (Poker)Person3[i];
            //    po3.Printp();
            //}
            //Console.WriteLine();
            //Console.WriteLine("打印第四个人的扑克牌：");
            //for (int i = 0; i < 13; i++)
            //{
            //    Poker po4 = (Poker)Person4[i];
            //    po4.Printp();
            //}
            //Console.WriteLine();
            //Console.Read();
        }
    }
}
