using System;
using System.IO;

namespace CopyMyShell
{
    class MainClass
    {

        public static void CopyMyFile(string sourceDirPath,string saveDirPath){
            try
            {
                if (!Directory.Exists(saveDirPath))
                {
                    Directory.CreateDirectory(saveDirPath);
                }
                string[] files = Directory.GetFiles(sourceDirPath);
                foreach (string file in files)
                {
                    string pFilePath = saveDirPath + "\\" + Path.GetFileName(file);
                    if (File.Exists(pFilePath))
                        continue;
                    File.Copy(file, pFilePath, true);
                }

                string[] dirs = Directory.GetDirectories(sourceDirPath);
                foreach (string dir in dirs)
                {
                    CopyMyFile(dir, saveDirPath + "\\" + Path.GetFileName(dir));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("失败");

            }
        }

        public static void Main(string[] args)
        {

            var str = System.Environment.UserName;
            Console.WriteLine(str);
            var str2 = "/users/" + str + "/library/developer/xcode/userdata/CodeSnippets";
            Console.WriteLine(str2);

            var str3 = "/Users/dongdongqi/Desktop/人脸识别.html";

            //CopyMyFile(path, save);


            if (File.Exists(str3))
            {
                File.Copy(str3,"/Users/dongdongqi/Desktop/123123",true);
            }

                //CopyMyFile(str3,"/Users/dongdongqi/Desktop/123123");


            DirectoryInfo folder = new DirectoryInfo(str2);


            foreach (FileInfo file in folder.GetFiles("*.codesnippet"))
            {
                Console.WriteLine(file.FullName);

                //var path = file.FullName;
                //var save = "/Users/dongdongqi/Desktop/123123";

                //CopyMyFile(path, save);


                //if (File.Exists(path))
                //{
                //    File.Copy(path,save,true);
                //}
                //var pLocalFilePath = file.FullName;//要复制的文件路径
                //string pSaveFilePath = "/Users/dongdongqi/Desktop/123123";//指定存储的路径
                //if (File.Exists(pLocalFilePath))//必须判断要复制的文件是否存在
                //{
                //    File.Copy(pLocalFilePath, pSaveFilePath, true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
                //}
            }


            //string pLocalFilePath = "";//要复制的文件路径
            //string pSaveFilePath = "/Users/dongdongqi/Desktop/123123";//指定存储的路径
            //if (File.Exists(pLocalFilePath))//必须判断要复制的文件是否存在
            //{
            //    File.Copy(pLocalFilePath, pSaveFilePath, true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
            //}


            ////var files = Directory.GetFiles(str2, "*.txt");

            ////foreach (var file in files)
            //    //Console.WriteLine(file);


            ////1.获取模块的完整路径。 
            //string path1 = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            //Console.WriteLine(path1);

            ////2.获取和设置当前目录(该进程从中启动的目录)的完全限定目录 
            //string path2 = System.Environment.CurrentDirectory;
            //Console.WriteLine(path2);

            ////3.获取应用程序的当前工作目录 
            //string path3 = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine(path3);

            //4.获取程序的基目录 
            string path4 = System.AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(path4);

            ////5.获取和设置包括该应用程序的目录的名称 
            //string path5 = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            //Console.WriteLine(path5);

            //////6.获取启动了应用程序的可执行文件的路径 
            ////string path6 = System.Windows.Forms.Application.StartupPath;
            ////Console.WriteLine(path6);

            //////7.获取启动了应用程序的可执行文件的路径及文件名 
            ////string path7 = System.Windows.Forms.Application.ExecutablePath; 
            ////Console.WriteLine(path7);
            //string path6 = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            //Console.WriteLine(path6);


        }
    }
}
