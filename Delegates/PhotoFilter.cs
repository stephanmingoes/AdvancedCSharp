namespace Delegates
{

    public class PhotoFilter
    {
        public static void AdjustBrightness(Photo photo) => Console.WriteLine("Applying Brightness");
        public static void AdjustContrast(Photo photo) => Console.WriteLine("Adjusting Contrast");
        public static void AdjustWidth(Photo photo) => Console.WriteLine("Adjusting Width");
        public static void AdjustHeight(Photo photo) => Console.WriteLine("Adjusting Height");
    }
}
