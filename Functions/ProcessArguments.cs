using System;

namespace VCDL.Functions
{
    class ProcessArguments
    {
        public static void ProcessArgs(string[] args)
        {
            bool videotypeDefined = false;
            bool videoUrlDefined = false;
            bool timestampsDefined = false;
            for ( int i = 0; i < args.Length; i++ )
            {
                if (args[i] == "-videotype" && i + 1 < args.Length)
                {
                    if (args[i + 1] == "youtube" || args[i + 1] == "other" )
                    {
                        videotypeDefined = true;
                        Console.WriteLine($"Video Type: {args[i + 1]}");
                    }
                    else
                    {
                        throw new ArgumentException("Invalid Video Type");
                    }
                }
                if (args[i] == "--video-url" && i + 1 < args.Length)
                {
                    videoUrlDefined = true;
                    Console.WriteLine($"Video URL: {args[i + 1]}");
                }
                if (args[i] == "-timestamps" && i + 1 < args.Length)
                {
                    timestampsDefined = true;
                    Console.WriteLine($"Timestamps: {args[i + 1]}");
                }
            }
            if (videotypeDefined == false)
            {
                throw new ArgumentException("No Video Type Defined");
            }
            else if (videoUrlDefined == false)
            {
                throw new ArgumentException("No Video URL Defined");
            }
            else if (timestampsDefined == false)
            {
                throw new ArgumentException("No Timestamps Defined");
            }
        }
    }
}
