using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace vcpkgManager.Common
{
    /// <summary>
    /// 运行指令并将指令重定向到指定的位置
    /// </summary>
    public class ShellCommand
    {
        private Process ownerProc = null;

        /// <summary>
        /// 运行指令，如果不设置重定向函数则不会进行重定向 仅仅后台运行
        /// </summary>
        /// <param name="exec">运行程序</param>
        /// <param name="args">参数</param>
        /// <param name="recvHander">CALLBACK参数</param>
        /// <returns>是否运行成功</returns>
        public bool RunShell(string exec, string args, DataReceivedEventHandler recvHander = null)
        {
           if(ownerProc == null)
            {
                ownerProc = new Process();
                ownerProc.StartInfo.CreateNoWindow = true; // 无窗口
                ownerProc.StartInfo.UseShellExecute = false;
                ownerProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                ownerProc.StartInfo.FileName = exec;
                ownerProc.StartInfo.Arguments = args;

                // 重定向输出
                if(recvHander != null)
                {
                    ownerProc.StartInfo.RedirectStandardOutput = true;
                    ownerProc.OutputDataReceived += recvHander; // 进行重定向
                }

                return ownerProc.Start(); // 运行
            }

            return false;
        }


        /// <summary>
        /// 用于快速分析使用的一次运行数据，不做持续输出行为，会阻塞
        /// </summary>
        /// <param name="exec">执行程序</param>
        /// <param name="args">参数</param>
        /// <returns>控制台输出的文本内容</returns>
        public static string RunShellOnce(string exec, string args)
        {
            Process nowProc = new Process();
            nowProc.StartInfo.CreateNoWindow = true; // 无窗口
            nowProc.StartInfo.UseShellExecute = false;
            nowProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            nowProc.StartInfo.FileName = exec;
            nowProc.StartInfo.Arguments = args;

            // 重定向输出
            nowProc.StartInfo.RedirectStandardOutput = true;
            nowProc.Start();
            nowProc.WaitForExit();

            return nowProc.StandardOutput.ReadToEnd(); // 读取全部内容
        }

        /// <summary>
        /// 关闭这个进程，只要运行的话
        /// </summary>
        public void Cancel()
        {
            if (ownerProc != null)
            {
                ownerProc.Kill(); // 关闭程序
                ownerProc = null;
            }
        }
    }
}
