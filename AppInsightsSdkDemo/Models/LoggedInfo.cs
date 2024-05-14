public class LoggedInfo
{
    public LoggedInfo(String level, String message)
    {
        Level = level;
        Message = message;
    }

    public string Level { get; set; }
    public string Message { get; set; }
}
