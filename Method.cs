using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace HomeWork1
{
    class Method
    {
        public static void MoveFile(string fromPath, string toPath)
        {
            //來源路徑沒有目標檔案時
            if(!File.Exists(fromPath))
            {
                Console.WriteLine($"檔案來源資料夾無此檔案: {fromPath}");
                return;
            }


            //請user確認是否執行
            Console.WriteLine($"是否將{fromPath}的檔案,搬移至{toPath}.請輸入: Y / N");
            string yes = Console.ReadLine();


            //如果目標路徑已有相同檔案名稱時
            if(File.Exists(toPath))
            {
                Console.WriteLine("目標資料夾已存在相同檔案");
                return;
            }


            //user是否輸入Yes時
            //yes:執行程式
            //不是yes:結束程式
            if(yes == "y" || yes == "Y" || yes == "Yes" || yes == "yes" || yes == "YES")
            {
                //開始計時程式執行時間
                Stopwatch sw = new Stopwatch();
                sw.Start();

                //搬移檔案
                File.Move(fromPath, toPath);

                //停止計時
                sw.Stop();
                Console.WriteLine($"檔案搬移成功! 共使用{sw.ElapsedMilliseconds}秒");
            }
            else
            {
                return;
            }

            
        }

        public static void CopyFile(string fromPath, string toPath)
        {
            //來源路徑沒有目標檔案時
            if (!File.Exists(fromPath))
            {
                Console.WriteLine($"檔案來源資料夾無此檔案: {fromPath}");
                return;
            }


            //如果目標路徑已有相同檔案名稱時
            if (File.Exists(toPath))
            {
                Console.WriteLine("目標資料夾已存在相同檔案");
                return;
            }


            //請user確認是否執行
            Console.WriteLine($"是否將{fromPath}的檔案,複製至{toPath}.請輸入: Y / N");
            string yes = Console.ReadLine();


            //user是否輸入Yes時
            //yes:執行程式
            //不是yes:結束程式
            if (yes == "y" || yes == "Y" || yes == "Yes" || yes == "yes" || yes == "YES")
            {
                //開始計時程式執行時間
                Stopwatch sw = new Stopwatch();
                sw.Start();

                //複製檔案
                File.Copy(fromPath, toPath);

                //停止計時
                sw.Stop();
                Console.WriteLine($"檔案搬移成功! 共使用{sw.ElapsedMilliseconds}秒");
            }
            else
            {
                return;
            }


            
        }
    }
}
