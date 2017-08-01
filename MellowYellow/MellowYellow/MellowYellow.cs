using System;
using System.Collections.Generic;
using System.Linq;

namespace MellowYellow
{
    class MellowYellow
    {
        /// <summary>
        /// LINQ練習
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Question1();

            Question2();

            //引数は４パターン試してね！ 
            var ret3a = Question3("りん");
            foreach (var a in ret3a)
                Console.Write(a);
            var ret3b = Question3("み%");
            foreach (var b in ret3b)
                Console.Write(b);
            var ret3c = Question3("%お");
            foreach (var c in ret3c)
                Console.Write(c);
            var ret3d = Question3("%づき%");
            foreach (var d in ret3d)
                Console.Write(d);

            Console.WriteLine();

            IEnumerable<string> cute = new[] { "まゆ", "ちえり", "ゆかり", "きょうこ", "さえ" };

            var ret4a = Divide(cute, 2);

            foreach (var r in ret4a)
                Console.WriteLine(string.Join(",", r));

            // LiPPS ?
            var LiPPS = new[] { "しき", "しゅうこ", "かなで", "高田純次", "みか" };

            foreach (var r in LiPPS)
                Console.WriteLine(string.Join(",", r));
        }


        /// <summary>
        /// 問題1 : 難易度 DEBUT
        /// -----------------------------------
        /// [入力] : { "水本", "椎名", "中野" }
        /// [出力] : { "水本ちゃん", "椎名ちゃん", "中野ちゃん" }
        /// [説明] : 全部に「ちゃん」を付けてね！
        /// </summary>
        public static void Question1()
        {
            //input datas
            var datas = new[] { "水本", "椎名", "中野" };
            //do something(LINQ)

        }

        /// <summary>
        /// 問題2 : 難易度 DEBUT
        /// -----------------------------------
        /// [入力] : { "うづき", "りん", "みお", "みく", "なお" };
        /// [出力] : { "みお", "なお" }
        /// [説明] : "_お"っていう名前だけ取得してね！
        /// </summary>
        public static void Question2()
        {
            //input datas
            var datas = new[] { "うづき", "りん", "みお", "みく", "なお" };
            
            //do something(LINQ)

        }

        /// <summary>
        /// 問題3 : 難易度 REGULER
        /// -----------------------------------
        /// [入力] : LIKE検索文字列
        /// [説明] : LIKE検索を実装しよう！
        ///          入力が「みお」の場合→ {"みお"}（完全一致）
        ///          入力が「み%」の場合→ {"みお","みく"}（前方一致）
        ///          入力が「%お」の場合→ {"みお","なお"}（後方一致）
        ///          入力が「%づき%」の場合→ {"うづき"}（部分一致）
        ///          ※それぞれ、IEnumerable型で返して下さい！
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private static IEnumerable<string> Question3(string value)
        {
            //data sources
            var datas = new[] { "うづき", "りん", "みお", "みく", "なお" };

            //最後はreturnしてmainで実行結果確かめて

            return null;
        }

        /// <summary>
        /// 問題4 難易度 : REGULER
        /// -----------------------------------
        /// [説明] : 列挙を「分割」してみよう。結構難しいぞ！
        /// [入力] : datas = {"まゆ","ちえり","ゆかり","きょうこ","さえ"},
        ///          value = 2 （区切る単位の数）
        /// [出力] : { {"まゆ,"ちえり"},
        ///            {"ゆかり","きょうこ"},
        ///            {"さえ"}
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static IEnumerable<IEnumerable<string>> Divide(IEnumerable<string> datas, int value)
        {
            //中身は自由に作ってみよう！どんな形でもよいです。

            return null;
        }
    }
    public static class Extension
    {
        //作ったDivideを
        //①Extensionsクラスに切り出して、IEnumerableの拡張メソッドにする
        //②ジェネリック（<T>）型に対応させ、string以外の型でも処理できるようにする
        // 返却する最後の列挙数が指定したvalue数に満たない場合、
        // 切り捨てを行う処理を追加する。
        // （例えば、今回の例でいうと{"さえ"}の個数は指定したvalue（２個）に満たないので、
        //  切り捨てることとする）


        /// <summary>
        /// 問題5 難易度 : REGULER+
        /// 対象のシーケンスを分割、余りは切り捨て
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="datas"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IEnumerable<IEnumerable<T>> Divide<T>(this IEnumerable<T> datas, int value)
        {
            return null;
        }
    }
}
