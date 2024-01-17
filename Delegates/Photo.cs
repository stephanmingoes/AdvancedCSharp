namespace Delegates
{
    public class Photo
    {
        public string Path;
        public int Height;
        public int Width;
        public int Brightness;
        public int Contrast;

        private Photo(string path, int height, int width, int brightness, int contrast)
        {
            Path = path;
            Height = height;
            Width = width;
            Brightness = brightness;
            Contrast = contrast;    
        }

        public static Photo Load(string path) => new Photo(path, 9, 9, 9, 9);

    }
}
