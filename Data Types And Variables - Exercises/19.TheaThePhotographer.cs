using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            byte uploadPictures = byte.Parse(Console.ReadLine());
            long UploadTime = int.Parse(Console.ReadLine());

            long totalFilterTimeS = totalPictures * filterTime;
            int picsUpload = (int)Math.Ceiling(totalPictures * (uploadPictures / 100d));
            long totalUploadTime = UploadTime * picsUpload;

            long totalTime = totalFilterTimeS + totalUploadTime;

            byte seconds = (byte)(totalTime % 60);
            totalTime = (totalTime - (totalTime % 60)) / 60;
            byte minutes = (byte)(totalTime % 60);
            totalTime = (totalTime - (totalTime % 60)) / 60;
            byte hours = (byte)(totalTime % 24);
            totalTime = (totalTime - (totalTime % 24)) / 24;
            int days = (int)totalTime;

            Console.WriteLine($"{days}:{hours:d2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
