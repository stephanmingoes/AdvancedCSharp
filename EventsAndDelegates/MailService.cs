namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object? source, VideoEncoderEventArgs e)
        {
            Console.WriteLine("Mail Service sending an email ", e.Video.Title);
        }
    }

}
