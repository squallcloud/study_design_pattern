using System;
using System.Collections.Generic;
using System.Text;

namespace Command001.Ex1
{
    //食塩水を作る実験のコマンドクラス
    public class MakeSaltWaterCommand : Command
    {
        public override void execute()
        {
            //食塩水を作る実験
            beaker.mix();
            //濃度をはかり、ノートに記述する
            Console.WriteLine("食塩水を作る実験");
            beaker.note();
        }
    }
}
