using System;
using System.Collections.Generic;
using System.Text;

namespace Command001.Ex1
{
    //食塩を1gずつ加える実験のコマンドクラス
    public class AddSaltCommand : Command
    {
        public override void execute()
        {
            //食塩を1gずつ加えて飽和食塩水を作る実験をする場合
            //完全に溶けている間は食塩を加える
            while (beaker.isMelted())
            {
                beaker.addSalt(1); //食塩を1g入れる
                beaker.mix(); //かき混ぜる
            }
            //実験結果をノートに記述する
            Console.WriteLine("食塩を1gずつ加える実験");
            beaker.note();
        }
    }
}
