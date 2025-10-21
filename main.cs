public class Program
{
    public static void Main()
    {
        DetectionModule detector = new DetectionModule();

        Console.WriteLine("Download Guardian running... Press Ctrl+C to exit.");

        while (true)
        {
            detector.CheckForDownloads();
            Thread.Sleep(2000); // every 2 seconds
        }
    }
}