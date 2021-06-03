using VCDL.Functions;
using System;
using System.Diagnostics;
using System.Linq;

namespace VCDL
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ProcessArguments.ProcessArgs(args);
            Process ffmpeg = new Process();
            ProcessStartInfo ffmpegStartInfo = new ProcessStartInfo();

            ffmpegStartInfo.CreateNoWindow = true;
            ffmpegStartInfo.UseShellExecute = false;
            ffmpegStartInfo.RedirectStandardOutput = true;
            ffmpegStartInfo.RedirectStandardError = true;
            ffmpegStartInfo.FileName = "ffmpeg";
            ffmpegStartInfo.Arguments = "";
            ffmpeg.StartInfo = ffmpegStartInfo;
            ffmpeg.OutputDataReceived += (sender, arg) => Console.WriteLine("{0}", arg.Data);
            ffmpeg.ErrorDataReceived += (sender, arg) => Console.WriteLine("{0}", arg.Data);
            ffmpeg.Start();
            ffmpeg.BeginOutputReadLine();
            ffmpeg.BeginErrorReadLine();
            ffmpeg.WaitForExit();

            string path = Environment.GetEnvironmentVariable("PATH");
            Console.WriteLine("Hello World!");
        }
    }
}
