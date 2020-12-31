using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod001.Example
{
    class Tea : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("紅茶を浸す");
        }

        public override void brew()
        {
            Console.WriteLine("レモンを加える");
        }
    }
}
