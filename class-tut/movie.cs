namespace Cinema
{
    public class Movie
    {
        public string Title;
        public string Director;
        public int ReleaseYear;
        // static field to keep track of number of Movie instances
        public static int Count = 0;// you can access this field without creating an instance of Movie class

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