namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // define Event Delegate 
        // define event based on that delegate 
        // raise the 

        public event EventHandler<VideoEncoderEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        public void AddSubsciber(EventHandler<VideoEncoderEventArgs> videoEncoded)
        {
            VideoEncoded += videoEncoded;
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEncoderEventArgs { Video = video });
            }
        }

    }

}
