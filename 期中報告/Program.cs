using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中報告
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "banana";//建立了一個名為 original 的字串變數，並將它的初始值設為 "banana"。
            //original 現在存儲的值是 "banana"。
            string copy = string.Copy(original); //建立了一個名為 copy 的字串變數，並通過 string.Copy 方法將 original 的值複製給它。
            //現在 copy 儲存的值也是 "banana"。
            original = "orange";//這行將字串變數 original 的值改為 "orange"。
            Console.WriteLine(original);//印出original
            Console.WriteLine(copy);//印出copy

            string str2 = "Programming";//建立了一個名為 str 的字串變數，並將它的初始值設為 "Programming"。
            bool result2 = str2.StartsWith("Pro");//這行使用 StartsWith 方法來檢查 str 是否以 "Pro" 開頭。
            //StartsWith 方法會返回一個布林值（bool），如果 str 以 "Pro" 開頭，result 將為 true；否則，它將為 false。
            string output = result2 ? "字串以 'Pro' 開頭" : "字串不以 'Pro' 開頭";//這行使用條件運算符（?）來根據 result 的值決定 output 的內容。
            //如果 result 為 true，則 output 被賦值為 "字串以 'Pro' 開頭"；如果 result 為 false，則 output 被賦值為 "字串不以 'Pro' 開頭"。
            Console.WriteLine(output); //這行將 output 的值輸出到控制台。

            string str = "HelloWorld";//建立了一個名為 str 的字串變數，並將它的初始值設為 "HelloWorld"。
            bool result = str.EndsWith("World");//這行使用 EndsWith 方法來檢查 str 是否以 "World" 結尾。
            //EndsWith 方法會返回一個布林值（bool），如果 str 以 "World" 結尾，result 將為 true；否則，它將為 false。

            Console.ReadLine();//這行使程序暫停，等待使用者輸入，以便窗口不會立即關閉
        }
    }
}
