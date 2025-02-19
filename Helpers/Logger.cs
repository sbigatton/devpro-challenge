namespace DevProChallenge.Helpers;

public class Logger
{
    public static void LogMessage(string filePath, string message, string logType)
    {
        var logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{logType}] {message}";

        try
        {        
            using var writer = File.AppendText(filePath);
            lock(writer) {
                writer.Write(logMessage);
            }   
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Logging into message into file failed: {ex.Message}");
        }
    }
}