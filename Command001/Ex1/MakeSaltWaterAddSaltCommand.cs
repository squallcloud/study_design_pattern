using System;
using System.Collections.Generic;
using System.Text;

namespace Command001.Ex1
{
    //実験コマンドクラス
    public class MakeSaltWaterAddSaltCommand : Command
    {
        //実験リスト
        private List<Command> commands = new List<Command>();
        //実験を実行するメソッド
        public override void execute()
        {
            //実験リストの実行
            foreach (var cmd in commands)
            {
                cmd.execute();
            }
            //実験結果をノートに記述する
            Console.WriteLine("食塩水を作り、それに食塩を1gずつ加えて飽和食塩水を作る実験");
            beaker.note();
        }
        //実験リストに追加するメソッド
        public void addCommand(Command command)
        {
            commands.Add(command);
        }
    }
}
