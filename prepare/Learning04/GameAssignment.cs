public class GamesAssignment : Assignment
{
    private string _videoGames;
    private string _hours;

    public GamesAssignment(string studentName, string topic, string videoGames, string hours)
    : base (studentName, topic)
    {
        _videoGames = videoGames;
        _hours = hours;
    }

    public string GetGameInformation()
    {
        return $"{base.GetStudentName()} played {_videoGames} for {_hours} hours.";
    }
}
