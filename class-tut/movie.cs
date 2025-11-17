namespace Cinema
{
    public class Movie
    {
        public string Title;
        public string Director;
        public int ReleaseYear;
        public static int Count = 0;

        public Movie(string title, string director, int releaseYear)
        {
            Title = title;
            Director = director;
            ReleaseYear = releaseYear;
            Count ++;


        }

        // defining a method
        public void DisplayInfo()
        {
            Console.WriteLine("Title: " + Title + ", Director: " + Director + ", Release Year: " + ReleaseYear);
        }
    }
}