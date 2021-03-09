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
        //搬移檔案的Method
        #region MoveFile
        public static void MoveFile(string fromPath, string toPath)
        {
            //來源路徑沒有目標檔案時
            if (!File.Exists(fromPath))
            {
                Console.WriteLine($"檔案來源資料夾無此檔案: {fromPath}");
                return;
            }


            //請user確認是否執行
            Console.WriteLine($"是否將{fromPath}的檔案,搬移至{toPath}.請輸入: Y / N");
            string yes = Console.ReadLine().ToLower();


            //如果目標路徑已有相同檔案名稱時
            if (File.Exists(toPath))
            {
                Console.WriteLine("目標資料夾已存在相同檔案");
                return;
            }


            //user是否輸入Yes時
            //yes:執行程式
            //不是yes:結束程式
            if (yes == "y" || yes == "Y" || yes == "Yes" || yes == "yes" || yes == "YES")
            {
                //開始計時程式執行時間
                Stopwatch sw = new Stopwatch();
                sw.Start();

                //搬移檔案
                File.Move(fromPath, toPath);

                //停止計時
                sw.Stop();
                Console.WriteLine($"檔案搬移完成! 共使用{sw.ElapsedMilliseconds} 毫秒");
            }
            else
            {
                return;
            }


        }
        #endregion



        #region CopyFile
        //複製檔案的Method
        public static void CopyFile(string fromPath, string toPath)
        {
            //來源路徑沒有目標檔案時
            if (!File.Exists(fromPath))
            {
                Console.WriteLine($"檔案來源資料夾無此檔案: {fromPath}");
                return;
            }


            //請user確認是否執行
            Console.WriteLine($"是否將{fromPath}的檔案,複製至{toPath}.請輸入: Y / N");
            string yes = Console.ReadLine().ToLower();



            //如果目標路徑已有相同檔案名稱時
            if (File.Exists(toPath))
            {
                Console.WriteLine("目標資料夾已存在相同檔案");
                return;
            }


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
                Console.WriteLine($"檔案複製完成! 共使用{sw.ElapsedMilliseconds}毫秒");
            }
            else
            {
                return;
            }
        }
        #endregion



        #region ReadFile
        //讀取檔案的Method
        public static void ReadFile(string Path)
        {


            //來源路徑沒有目標檔案時
            if (!File.Exists(Path))
            {
                Console.WriteLine($"檔案來源資料夾無此檔案: {Path}");
                return;
            }


            //請user確認是否執行
            Console.WriteLine($"是否讀取{Path}檔案. 請輸入: Y / N");
            string yes = Console.ReadLine().ToLower();


            //user是否輸入Yes時
            //yes:執行程式
            //不是yes:結束程式
            if (yes == "y" || yes == "Y" || yes == "Yes" || yes == "yes" || yes == "YES")
            {
                //開始計時程式執行時間
                Stopwatch sw = new Stopwatch();
                sw.Start();

                //複製檔案
                Console.WriteLine(File.ReadAllText(Path));

                //停止計時
                sw.Stop();
                Console.WriteLine($"檔案讀取完成! 共使用{sw.ElapsedMilliseconds}毫秒");
            }
            else
            {
                return;
            }
        }
        #endregion


        #region DeleteFile
        //刪除檔案的Method
        public static void DeleteFile(string[] wantDeleteFile)
        {

            //將想刪除的檔案列出來讓user確認
            for (int j = 0; j < wantDeleteFile.Length; j++)
            {

                //因為執行程式的方式不同
                //如果用EXE方式開啟,陣列長度會少1
                //所以用一個變數o來做總比數的調整
                int o = 0;

                if (wantDeleteFile[0].ToLower() != "deletefile")
                {
                    o = 1;
                }

                //如果wantDeleteFile[j].ToLower()等於"deletefile"直接進入下一個循環
                if (wantDeleteFile[j].ToLower() == "deletefile")
                {
                    continue;
                }


                //判斷路徑(wantDeleteFile[j])是否存在檔案,有的話Console.WriteLine出來
                if (File.Exists(wantDeleteFile[j]))
                {
                    Console.WriteLine(wantDeleteFile[j]);
                }


                //判斷路徑(wantDeleteFile[j])是否存在檔案,
                //沒有的話Console.WriteLine出來,並結束程式
                if (!File.Exists(wantDeleteFile[j]))
                {
                    Console.WriteLine($"路徑{wantDeleteFile[j]}檔案不存在");
                    return;
                }

                //告知user總共會刪除幾筆檔案,並詢問是否執行
                if (j == wantDeleteFile.Length - 1)
                {
                    Console.Write($"是否刪除以上{j + o}筆資料. 請輸入 Y / N. ");
                }


            }

            //請user確認是否執行
            //接收user輸入的字串
            string yes = Console.ReadLine();


            //開始計時程式執行時間
            Stopwatch sw = new Stopwatch();
            sw.Start();


            //刪除檔案的迴圈
            if (yes == "y" || yes == "Y" || yes == "Yes" || yes == "yes" || yes == "YES")
            {
                int count = 0;
                //用迴圈把複數的檔案刪除
                for (int i = 0; i < wantDeleteFile.Length; i++)
                {

                    //如果wantDeleteFile[j].ToLower()等於"deletefile"直接進入下一個循環
                    if (wantDeleteFile[i].ToLower() == "deletefile")
                    {
                        continue;
                    }

                    //刪除檔案
                    File.Delete(wantDeleteFile[i]);
                    count += 1;

                }
                Console.Write($"檔案刪除完成!共刪除{count}筆檔案 ");
            }
            else
            {
                return;
            }

            //停止計時
            sw.Stop();
            Console.WriteLine($"共使用{sw.ElapsedMilliseconds}毫秒");
        }
        #endregion


        #region CreateFolder
        //新增資料夾
        public static void CreateFolder(string folderPath)
        {
            //判斷目標路徑是否有相同名稱的資料夾
            if (Directory.Exists(folderPath))
            {
                Console.WriteLine("目標路徑已有相同名稱的資料夾");
                return;
            }

            //請user確認是否執行
            Console.WriteLine($"新增資料夾至{folderPath}. 請輸入: Y / N. ");
            string yes = Console.ReadLine().ToLower();

            //開始計時程式執行時間
            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (yes == "y" || yes == "Y" || yes == "Yes" || yes == "yes" || yes == "YES")
            {


                //創建資料夾
                Directory.CreateDirectory(folderPath);


            }
            else
            {
                return;
            }

            //停止計時
            sw.Stop();
            Console.WriteLine($"共使用{sw.ElapsedMilliseconds}毫秒");

        }
        #endregion


        #region DeleteFolder
        //刪除資料夾
        public static void DeleteFolder(string[] wantDeleteFolder)
        {
            //將想刪除的資料夾列出來讓user確認
            for (int j = 0; j < wantDeleteFolder.Length; j++)
            {

                //因為執行程式的方式不同
                //如果用EXE方式開啟,陣列長度會少1
                //所以用一個變數o來做總比數的調整
                int o = 0;

                if (wantDeleteFolder[0].ToLower() != "deletefolder")
                {
                    o = 1;
                }

                //wantDeleteFolder[j].ToLower()等於"deletefolder"直接進入下一個循環
                if (wantDeleteFolder[j].ToLower() == "deletefolder")
                {
                    continue;
                }


                //判斷路徑(wantDeleteFolder[j])是否存在檔案,有的話Console.WriteLine出來
                if (Directory.Exists(wantDeleteFolder[j]))
                {
                    Console.WriteLine(wantDeleteFolder[j]);
                }


                //判斷路徑(wantDeleteFolder[j])是否存在檔案,
                //沒有的話Console.WriteLine出來,並結束程式
                if (!Directory.Exists(wantDeleteFolder[j]))
                {
                    Console.WriteLine($"路徑{wantDeleteFolder[j]}資料夾不存在");
                    return;
                }

                //告知user總共會刪除幾個資料夾,並詢問是否執行
                if (j == wantDeleteFolder.Length - 1)
                {
                    Console.Write($"是否刪除以上{j + o}個資料夾. 請輸入 Y / N. ");
                }
            }


            //請user確認是否執行
            //接收user輸入的字串
            string yes = Console.ReadLine();


            //開始計時程式執行時間
            Stopwatch sw = new Stopwatch();
            sw.Start();


            //刪除資料夾的迴圈
            if (yes == "y" || yes == "Y" || yes == "Yes" || yes == "yes" || yes == "YES")
            {
                int count = 0;
                //用迴圈把複數的資料夾刪除
                for (int i = 0; i < wantDeleteFolder.Length; i++)
                {

                    //wantDeleteFolder[j].ToLower()等於"deletefolder"直接進入下一個循環
                    if (wantDeleteFolder[i].ToLower() == "deletefolder")
                    {
                        continue;
                    }

                    //刪除資料夾
                    Directory.Delete(wantDeleteFolder[i]);
                    count += 1;

                }
                Console.Write($"檔案刪除完成!共刪除{count}資料夾 ");
            }
            else
            {
                return;
            }

            //停止計時
            sw.Stop();
            Console.WriteLine($"共使用{sw.ElapsedMilliseconds}毫秒");

        } 
        #endregion

    }
}
