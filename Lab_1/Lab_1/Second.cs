namespace Lab_1
{
    public class Second
    {
        public readonly CustomLogger logger = CustomLogger.Instance;

        public void writeLog(string information)
        {
            logger.WriteInfo(information);
        }
    }
}