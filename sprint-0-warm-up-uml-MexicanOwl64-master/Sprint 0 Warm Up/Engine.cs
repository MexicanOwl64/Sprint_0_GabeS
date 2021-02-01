namespace Sprint_0_Warm_Up
{
    public class Engine
    {
        public bool IsStarted = false;    
   
        public void Start()
        {
            IsStarted = true;
        }

        public void Stop()
        {
            IsStarted = false;
        }
    }
}