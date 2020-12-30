using System;
using System.Collections.Generic;
using System.Text;

namespace Command001.New
{
    //水を10gずつ加える実験のコマンドクラス
    public class AddWaterCommand : Command
    {
        public override void execute()
        {
            //水を10gずつ加えて飽和食塩水を作る実験をする場合
            //溶け残っている間は水を加える
            while (!beaker.isMelted())
            {
                beaker.addWater(10); //水を10g入れる
                beaker.mix(); //かき混ぜる
            }
            //実験結果をノートに記述する
            Console.WriteLine("水を10gずつ加える実験");
            beaker.note();
        }
    }
}
