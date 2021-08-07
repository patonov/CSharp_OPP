using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace P01._FileStream_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            File file = new File();
            file.Sent = 50;
            file.Length = 200;

            Progress progress = new Progress(file);

            while (true)
            {
                file.Sent += 7;
                Console.WriteLine($"{progress.CurrentPercent()}% sent.");
                Thread.Sleep(107);
            }

            Music music = new Music();
            music.Sent = 10;
            music.Sent = 312;

            Progress prog = new Progress(music);

            while (true)
            {
                music.Sent += 12;
                Console.WriteLine($"{prog.CurrentPercent()}% sent.");
                Thread.Sleep(212);
            }
        }
    }
}
