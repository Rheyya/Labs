// See https://aka.ms/new-console-template for more information


List<Movie> movies = new List<Movie>()
{
    new Movie ("Monster Ink", "Animation"),
    new Movie ("The Notebook", "Romantic"),
    new Movie ("Bird Box", "Thriller"),
    new Movie ("Scream", "Thriller"),
    new Movie ("Bridesmaids", "Comedy"),
    new Movie ("8 Mile", "Drama"),
    new Movie ("The Godfather", "Crime"),
    new Movie ("The Matrix", "Sci-Fi"),
    new Movie ("Spider-Man", "Action"),
    new Movie ("Spongebob Movie", "Animation")

};

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine($"There are {movies.Count} movies in this list.");

bool continueSearching = true;
while (continueSearching)
{
    Console.WriteLine("What category are you interested in?");
    string userCategory = Console.ReadLine().ToLower();

    var matchingMovies = movies.Where(x => x.movieCatergory.ToLower() == userCategory).ToList();

    if (matchingMovies.Any())
    {
       
        matchingMovies.ForEach(movie => Console.WriteLine(movie.movieTitle));
    }
    else
    {
        Console.WriteLine($"No movies found in the category {userCategory}");
    }

    Console.Write("Continue? (y/n): ");
    continueSearching = Console.ReadLine().ToLower() == "y";
}
Console.WriteLine("Thank you for using the Movie List Application!");