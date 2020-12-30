using System;
using System.Collections.Generic;
using System.Text;

namespace Command001.Old
{
    class Beaker
    {
        private double water = 0; //水
        private double salt = 0; //食塩
        private bool melted; //食塩がすべて溶けたときtrue、溶け残ったときfalse

        public const int ADD_SALT = 1; //食塩を加えて、かき混ぜる場合
        public const int ADD_WATER = 2; //水を加えて、かき混ぜる場合
        public const int MAKE_SALT_WATER = 3; //食塩水を作る場合

        //コンストラクタ
        public Beaker(double water, double salt)
        {
            this.water = water;
            this.salt = salt;
            this.mix();//かき混ぜる
        }
        //各実験を行うメソッド
        public void experiment(int param)
        {
            if (param == ADD_SALT)
            {
                //食塩を1gずつ加えて飽和食塩水を作る実験をする場合
                //完全に溶けている間は食塩を加える
                while (isMelted())
                {
                    this.addSalt(1); //食塩を1g入れる
                    this.mix(); //かき混ぜる
                }
                //実験結果をノートに記述する
                Console.WriteLine("食塩を1gずつ加える実験");
                this.note();
            }
            else if (param == ADD_WATER)
            {
                //水を10gずつ加えて飽和食塩水を作る実験をする場合
                //溶け残っている間は水を加える
                while (!isMelted())
                {
                    this.addWater(10); //水を10g入れる
                    this.mix(); //かき混ぜる
                }
                //実験結果をノートに記述する
                Console.WriteLine("水を10gずつ加える実験");
                this.note();
            }
            else if (param == MAKE_SALT_WATER)
            {
                //食塩水を作る実験
                this.mix();
                //濃度をはかり、ノートに記述する
                Console.WriteLine("食塩水を作る実験");
                this.note();
            }
        }
        //ビーカーに食塩を入れるメソッド
        public void addSalt(double salt)
        {
            this.salt += salt;
        }
        //ビーカーに水を入れるメソッド
        public void addWater(double water)
        {
            this.water += water;
        }
        //かき混ぜるメソッド
        public void mix()
        {
            //溶液をかき混ぜる
            //溶けたか溶け残ったかをセットする
            //常温での飽和食塩水の濃度は約26.4%
            if ((this.salt / (this.salt + this.water)) * 100 < 26.4)
            {
                melted = true;
            }
            else
            {
                melted = false;
            }
        }
        //食塩の量を返すメソッド
        public double getSalt()
        {
            return salt;
        }
        //水の量を返すメソッド
        public double getWater()
        {
            return water;
        }
        //溶けたか溶け残ったか調べるメソッド
        public bool isMelted()
        {
            return melted;
        }
        //実験結果をノートに記録する
        public void note()
        {
            Console.WriteLine("水：" + water + "g");
            Console.WriteLine("食塩：" + salt + "g");
            Console.WriteLine("濃度：" + (salt / (water + salt)) * 100 + "%");
        }
    }
}
