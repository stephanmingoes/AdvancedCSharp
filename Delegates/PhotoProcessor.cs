namespace Delegates
{
    public class PhotoProcessor
    {

        public void Process(string path, Action<Photo> handler)
        {
            var loadedPhoto = Photo.Load(path);
            handler(loadedPhoto);
            
        }

    }
}
