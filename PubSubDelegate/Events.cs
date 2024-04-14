namespace Models
{
    public enum NumEventType
    {
        EVEN,
        ODD
    }

    public static class Events
    {
        public delegate void NumEventHandler(int num);
        public static event NumEventHandler? EvenNum;
        public static event NumEventHandler? OddNum;

        public static void RaiseNumEvent(NumEventType eventType, int num)
        {
            switch (eventType)
            {
                case NumEventType.EVEN:
                    EvenNum?.Invoke(num);
                    break;
                case NumEventType.ODD:
                    OddNum?.Invoke(num);
                    break;
            }
        }
    }
}