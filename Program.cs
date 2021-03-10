using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork1
{
    class Program
    {
        //程式進入點
        static void Main(string[] args)
        {
            //提示user程式已啟動
            Console.WriteLine("---程式啟動---");

            #region 程式開啟方式EXE or CMD
            //建立空字串變數
            string parameter1 = "";
            string stringCpmpare = "";
            string path1 = "";


            //用args陣列長度判定程式打開方式
            //如果用cmd打開args.Length會>0. 用EXE檔打開會=0
            if (args.Length == 0)
            {

                Console.WriteLine("請輸入參數一");
                parameter1 = Console.ReadLine();
            }
            else
            {
                //用陣列args[0]的決定啟動的method
                string method = args[0];

                //將method的字轉成小寫
                stringCpmpare = method.ToLower();

                //將參數args[1]設成path1
                path1 = args[1];
            }
            #endregion



            #region MoveFile
            //變數stringCpmpare或parameter1為"MoveFile"時使用此方法
            if (stringCpmpare == "movefile" || parameter1.ToLower() == "movefile")
            {
                if (args.Length != 0)
                {
                    string path2 = args[2];
                    Method.MoveFile(path1, path2);
                }
                else
                {
                    Console.WriteLine("請輸入參數二");
                    string parameter2 = Console.ReadLine();
                    Console.WriteLine("請輸入參數三");
                    string parameter3 = Console.ReadLine();
                    Method.MoveFile(parameter2, parameter3);
                }

            }
            #endregion


            #region copyFile
            //變數stringCpmpare或parameter1為"copyFile"時使用此方法
            if (stringCpmpare == "copyfile" || parameter1.ToLower() == "copyfile")
            {
                if (args.Length != 0)
                {
                    string path2 = args[2];
                    Method.CopyFile(path1, path2);
                }
                else
                {
                    Console.WriteLine("請輸入參數二");
                    string parameter2 = Console.ReadLine();
                    Console.WriteLine("請輸入參數三");
                    string parameter3 = Console.ReadLine();
                    Method.CopyFile(parameter2, parameter3);
                }

            }
            #endregion


            #region readFile
            //變數stringCpmpare或parameter1為"readFile"時使用此方法
            if (stringCpmpare == "readfile" || parameter1.ToLower() == "readfile")
            {
                if (args.Length != 0)
                {

                    //讀檔只需一個路徑故不使用path2
                    Method.ReadFile(path1);
                }
                else
                {
                    Console.WriteLine("請輸入參數二");
                    string parameter2 = Console.ReadLine();
                    Method.ReadFile(parameter2);
                }

            }
            #endregion


            #region deleteFile
            //變數stringCpmpare或parameter1為"deleteFile"時使用此方法
            if (stringCpmpare == "deletefile" || parameter1.ToLower() == "deletefile")
            {
                if (args.Length != 0)
                {
                    Method.DeleteFile(args);
                }
                else
                {
                    //用字串變數wantDeleteFile去接user輸入的字串
                    //並用Split以空格做切分,
                    //切分後放到字串陣列wantDeleteFilesArray,然後作為Method.DeleteFile的參數
                    Console.WriteLine("請輸入想刪除檔案的完整路徑,如為複數請以空格分開");
                    string wantDeleteFile = Console.ReadLine();
                    string[] wantDeleteFilesArray = wantDeleteFile.Split(' ');
                    Method.DeleteFile(wantDeleteFilesArray);
                }

            }
            #endregion

            #region CreateFolder
            //變數stringCpmpare或parameter1為"CreateFolder"時使用此方法
            if (stringCpmpare == "createfolder" || parameter1.ToLower() == "createfolder")
            {
                if (args.Length != 0)
                {
                    //新增資料夾只需一個路徑故不使用path2
                    Method.CreateFolder(path1);
                }
                else
                {
                    Console.WriteLine("請輸入參數二");
                    string parameter2 = Console.ReadLine();
                    Method.CreateFolder(parameter2);
                }
            }
            #endregion

            #region deletefolder
            //變數stringCpmpare或parameter1為"DeleteFolder"時使用此方法
            if (stringCpmpare == "deletefolder" || parameter1.ToLower() == "deletefolder")
            {
                if (args.Length != 0)
                {
                    Method.DeleteFolder(args);
                }
                else
                {
                    //用字串變數wantDeleteFile去接user輸入的字串
                    //並用Split以空格做切分,
                    //切分後放到字串陣列wantDeleteFilesArray,然後作為Method.DeleteFile的參數
                    Console.WriteLine("請輸入想刪除資料夾的完整路徑,如為複數請以空格分開");
                    string wantDeleteFolder = Console.ReadLine();
                    string[] wantDeleteFolderArray = wantDeleteFolder.Split(' ');
                    Method.DeleteFolder(wantDeleteFolderArray);
                }
            } 
            #endregion

            Console.WriteLine("---請按任意鍵結束程式---");
            Console.ReadLine();
        }
    }
}
