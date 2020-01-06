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
            //       var Point = new string[]
            //{
            //                         "A", "2", "3", "4", "5", "6", "7", "8", "9", "10","J", "Q", "K",
            //};
            //       var Color = new string[]
            //       {
            //                         "红桃", "黑桃", "方片", "梅花",
            //       };
            //       var list = Enumerable.Range(0, 52) //生成52张牌
            //               .OrderBy(p => Guid.NewGuid()); //随机乱序
            //       var n = 0;
            //       foreach (var x in list)
            //       {
            //           Console.Write("{0}{1} ", Color[(int)(x / 13)], Point[x % 13]);
            //           if ((++n) % 13 == 0) Console.WriteLine(" ");
            //       }
            //       Console.Read();


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
            //    }
            //}


            string[] cardColor = { "方块", "梅花", "红桃", "黑桃" };
            int[] cardXia = {
                    44,48,0,4,8,12,16,20,24,28,32,36,40,
                    45,49,1,5,9,13,17,21,25,29,33,37,41,
                    46,50,2,6,10,14,18,22,26,30,34,38,42,
                    47,51,3,7,11,15,19,23,27,31,35,39,43
            };
            string[] cardWang = { "大王", "小王" };
            int[] wangXia = { 52, 53 };
            var cardList = new List<Card>();
            int colorIndex = 0;
            int tempValue = 0;
            for (int i = 0; i < cardXia.Length; i++)//有点数牌
            {
                if (i % 13 == 0 && i != 0)//判断花色牌数，达到13取下一个花色
                {
                    colorIndex++;
                }

                Char a;
                tempValue = i % 13;
                switch (tempValue)
                {
                    case 0:
                        a = 'A';
                        break;
                    case 9:
                        a = '十';
                        break;
                    case 10:
                        a = 'J';
                        break;
                    case 11:
                        a = 'Q';
                        break;
                    case 12:
                        a = 'K';
                        break;
                    default:
                        a = (Char)(tempValue + (int)'1');
                        break;
                }
                Card vm = new Card//初始化赋值卡牌属性
                {
                    value = a,
                    color = cardColor[colorIndex],
                    xia = cardXia[i]
                };
                cardList.Add(vm);
            }
            for (int i = 0; i < cardWang.Length; i++)  //无点数牌====王
            {
                Card vm = new Card
                {
                    color = cardWang[i],
                    xia = wangXia[i]
                };
                cardList.Add(vm);
            }
            List<Card> ShuffleCardEnd = ShuffleCard(cardList);
            /////斗地主四人打牌51张分配，一次性发完个人的牌，留最后3张底牌
            List<Card> one = new List<Card>();
            List<Card> tow = new List<Card>();
            List<Card> three = new List<Card>();
            List<Card> four = new List<Card>();
            List<Card> glide = new List<Card>();
            for (int i = 0; i < ShuffleCardEnd.Count; i++)
            {

                if (i < 13)
                {
                    Card vm = new Card()
                    {
                        color = ShuffleCardEnd[i].color,
                        value = ShuffleCardEnd[i].value,
                        xia = ShuffleCardEnd[i].xia
                    };
                    one.Add(vm);
                }
                else if (i < 26)
                {
                    Card vm = new Card()
                    {
                        color = ShuffleCardEnd[i].color,
                        value = ShuffleCardEnd[i].value,
                        xia = ShuffleCardEnd[i].xia
                    };
                    tow.Add(vm);
                }
                else if (i < 39)
                {
                    Card vm = new Card()
                    {
                        color = ShuffleCardEnd[i].color,
                        value = ShuffleCardEnd[i].value,
                        xia = ShuffleCardEnd[i].xia
                    };
                    three.Add(vm);
                }

                else if (i < 51)
                {
                    Card vm = new Card()
                    {
                        color = ShuffleCardEnd[i].color,
                        value = ShuffleCardEnd[i].value,
                        xia = ShuffleCardEnd[i].xia
                    };
                    four.Add(vm);
                }
                else
                {
                    Card vm = new Card()
                    {
                        color = ShuffleCardEnd[i].color,
                        value = ShuffleCardEnd[i].value,
                        xia = ShuffleCardEnd[i].xia
                    };
                    glide.Add(vm);
                }

            }
            //输出
            Console.WriteLine("发牌每人得到：");
            Console.Write("one手上的牌是：");
            ShowCard(one);
            Console.Write("tow手上的牌是：");
            ShowCard(tow);
            Console.Write("three手上的牌是：");
            ShowCard(three);
            Console.Write("four手上的牌是：");
            ShowCard(four);
            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.Write("低牌是：");
            ShowCard(glide);
            Console.WriteLine();
            Console.WriteLine("各自手上排序后：");
            Console.Write("one手上的牌是：");
            ShowCards(one);
            Console.Write("tow手上的牌是：");
            ShowCards(tow);
            Console.Write("three手上的牌是：");
            ShowCards(three);
            Console.Write("four手上的牌是：");
            ShowCards(four);
            Console.ReadLine();
        }
        /// <summary>
        /// 随机洗牌
        /// </summary>
        /// <param name="cardList"></param>
        /// <returns></returns>
        public static List<Card> ShuffleCard(List<Card> cardList)
        {
            Random random = new Random();
            int tempIndex = 0;
            Card temp = null;
            for (int i = 0; i < 54; i++)
            {
                tempIndex = random.Next(54);
                temp = cardList[tempIndex];
                cardList[tempIndex] = cardList[i];
                cardList[i] = temp;
            }

            return cardList;
        }
        /// <summary>
        /// 显示数组元素
        /// </summary>
        /// <param name="cardList"></param>
        static void ShowCard(List<Card> cardList)
        {
            for (int i = 0; i < cardList.Count; i++)
            {


                Console.Write(cardList[i].color + "" + cardList[i].value + " ");
                if (i % 12 == 0 && i != 0)
                {
                    Console.WriteLine("\n");
                }
            }

        }
        /// <summary>
        /// 冒泡排序后显示
        /// </summary>
        /// <param name="cardList"></param>
        static void ShowCards(List<Card> cardList)
        {
            Card aa = null;

            for (int j = 0; j < cardList.Count; j++)
            {
                for (int i = 0; i < cardList.Count - 1; i++)
                {

                    if (cardList[i].xia > cardList[i + 1].xia)
                    {
                        aa = cardList[i];
                        cardList[i] = cardList[i + 1];
                        cardList[i + 1] = aa;

                    }

                }
            }
            for (int i = 0; i < cardList.Count; i++)//显示排序好的卡牌
            {

                Console.Write(cardList[i].color + "" + cardList[i].value + " ");

            }
            Console.WriteLine("\n");
        }


    }

    public class Card
    {
        public char value;//卡牌点数
        public string color;//卡牌花色
        public int xia;//卡牌下标
    }
}
