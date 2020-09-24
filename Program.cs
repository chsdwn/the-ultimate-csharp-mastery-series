using System;
using System.IO;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var result = Calculator.Divide(2, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                var youtubeApi = new YoutubeApi();
                youtubeApi.GetVideos("youtube");

                using (var streamReader = new StreamReader(@".\dummy.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}
