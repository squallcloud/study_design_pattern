using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod001.Example
{
    class Coffee : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("フィルタでコーヒーをドリップ");
        }

        public override void brew()
        {
            Console.WriteLine("ミルクと砂糖を加える");
        }
    }
}
