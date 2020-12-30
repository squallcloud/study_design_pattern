using System;
using System.Collections.Generic;
using System.Text;

namespace Command001.Ex1
{
    //実験セット
    public class Beaker
    {
        private double m_water = 0; //水
        private double m_salt = 0; //食塩
        private bool m_melted = true; //食塩がすべて溶けたときtrue、溶け残ったときfalse

        //濃度
        public double Density => m_salt / (m_water + m_salt) * 100;

        //コンストラクタ
        public Beaker(double water, double salt)
        {
            m_water = water;
            m_salt = salt;

            //かき混ぜる
            mix();
        }

        //ビーカーに食塩を入れるメソッド
        public void addSalt(double salt)
        {
            m_salt += salt;
        }

        //ビーカーに水を入れるメソッド
        public void addWater(double water)
        {
            m_water += water;
        }
        //かき混ぜるメソッド
        public void mix()
        {
            const double kLimit = 26.4;

            //溶液をかき混ぜる
            //溶けたか溶け残ったかをセットする
            //常温での飽和食塩水の濃度は約26.4%
            if (Density < kLimit) {
                m_melted = true;
            } else {
                m_melted = false;
            }
        }
        //食塩の量を返すメソッド
        public double getSalt()
        {
            return m_salt;
        }
        //水の量を返すメソッド
        public double getWater()
        {
            return m_water;
        }
        //溶けたか溶け残ったか調べるメソッド
        public bool isMelted()
        {
            return m_melted;
        }
        //実験結果をノートに記録する
        public void note()
        {
            Console.WriteLine($"水：{m_water}g");
            Console.WriteLine($"食塩：{m_salt}g");
            Console.WriteLine($"濃度：{Density}%");
        }
    }
}
