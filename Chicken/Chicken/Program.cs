using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken
{
    class Program
    {
        static void Main(string[] args)
        {
            int cock;//公鸡
            int hen;//母鸡
            int chick;//小鸡
            for (cock = 0; cock <= 100; cock++)
            {
                for (hen = 0; hen <= 100; hen++)
                {
                    for (chick = 0; chick <= 100; chick = chick + 3)
                    {
                        if ((5 * cock + 3 * hen + chick / 3 == 100) && (cock + hen + chick == 100))
                        {
                            Console.WriteLine("公鸡:{0}, 母鸡:{1}, 小鸡:{2}", cock, hen, chick);
                        }
                    }
                }
            }
            Console.Read();
        }
    }
}
