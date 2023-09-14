namespace Backend_Plateform_Streaming.Classes
{
    public class WatchTime
    {
        public User? User { get; set; }
        public Content? Movies { get; set; }
        public TimeOnly?  StopedTimeWatching{ get; set; }
    }
}
