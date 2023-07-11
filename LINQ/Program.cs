using System.ComponentModel.DataAnnotations;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<string> VideoGames = new List<string>() {"Horizon Zero Down" , "Resident Evil 2", "Crash Bandicoot 4" };
            VideoGames.Add("Attack on Titan");
            VideoGames.Add("Gollum");

            var orderVideoGames = VideoGames.OrderBy(name => name.Length);

            foreach (var videoGame in orderVideoGames) 
            {
                Console.WriteLine(videoGame);
            
            }
        }
    }
}
