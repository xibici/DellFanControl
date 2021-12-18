using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dell风扇控制.utils
{
    class AndroidCmd
    {

        public static List<object> connectWinSusbsystem()
        {
            List<object> tempList = new List<object>();
            string res = "";
            try
            {
                res = doCmd("adb connect 127.0.0.1:58526");
                if (res.Contains("10061"))
                {
                    throw (new Exception(res));
                }

                tempList.Add(true);
                return tempList;
            }
            catch (Exception e)
            {

                tempList.Add(false);
                tempList.Add(e.Message);
                return tempList;
            }


        }

        public static void useScrcpyJar()
        {
            string tempStr =
                "adb shell CLASSPATH=/storage/emulated/0/scrcpy-server-flutter.jar app_process / --nice-name=scrcpy_device_server com.genymobile.scrcpy.Server 0000000000000000 error 0 8000000 0 -1 true - true true 0 false false - - false";
            string res = doCmd(tempStr);

        }

        public static List<object> connectWinSusbsystemAndUseScrcpyJar()
        {

            List<object> tempList=connectWinSusbsystem();
            Thread th = new Thread(useScrcpyJar);
            th.Start();
            //暂时只返回一个
            return tempList;
        }


        public static string doCmd(string cmdStr)
        {
           
            Process p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = true;
            //输出信息
            p.StartInfo.RedirectStandardOutput = true;
            // 输出错误
            p.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.StandardOutputEncoding = Encoding.UTF8;// 指定编码
            //启动程序
            p.Start();

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(cmdStr + "&exit");

            p.StandardInput.AutoFlush = true;

            //获取输出信息
            string strOuput = p.StandardOutput.ReadToEnd();
            //等待程序执行完退出进程
            p.WaitForExit();

            p.Close();

            return strOuput;

        }

    }

   

}
