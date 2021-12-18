using dell风扇控制;
using System;

namespace cmd控制风扇
{
    class Program
    {


        static void Main(string[] args)
        {
            string str100 = "fan1-level2";
            string str50 = "fan1-level1";
            string str0 = "fan1-level0";

            string strEcEnable = "ec-enable";
            string strECDisable = "ec-disable";

            //DellFanCmd.ProcessCommand(new string[] { strECDisable });
            Console.WriteLine("已经执行一次");
            //DellFanCmd.ProcessCommand(new string[] { str100 });


            DellFanCmd.ProcessCommand(new string[] { strEcEnable });
            Console.Read();
        }
    }
}
