using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示user程式已啟動
            Console.WriteLine("---程式啟動---");

            
            //用陣列args[0]的決定啟動的method
            string method = args[0];


            //將method的字轉成小寫
            string stringCpmpare = method.ToLower();


            //將參數args[1],args[2]設成path1,path2
            string path1 = args[1];
            string path2 = args[2];
            

            //變數method為"MoveFile"時使用此方法
            if (stringCpmpare == "movefile")
            {
                Method.MoveFile(path1, path2);
            }


            //變數method為"CopyFile"時使用此方法
            if (stringCpmpare == "copyfile") 
            {
                Method.CopyFile(path1, path2);
            }

            Console.WriteLine("---程式結束---");
        }
    }
}
