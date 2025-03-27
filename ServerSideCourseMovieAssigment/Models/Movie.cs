namespace ServerSideHW1.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Url { get; set; }
		public string PrimaryTitle { get; set; }
		public string Description { get; set; }
		public string PrimaryImage { get; set; }
		public int Year { get; set; }
		public DateTime ReleseDate { get; set; } 
		public string Language { get; set; }
		public double Budget { get; set; }
		public double GrossWorldWide { get; set; }
		public string Geners { get; set; }
		public bool IsAdult { get; set; }
		public int RunTimeMinutes { get; set; }
		public float RunTimeSeconds { get; set; }
		public float AverageRating { get; set; }
		public int NumVotes { get; set; }

		static List<Movie> MovieList = new List<Movie>(); //holds all created instances of movies 

		public Movie(int id, string url, string primaryTitle, string description, string primaryImage, int year,
			DateTime releseDate, string language, double budget, double grossWorldWide, string geners, bool isAdult,
			int runTimeMinutes, float runTimeSeconds, float averageRating, int numVotes)
		{
			Id = id;
			Url = url;
			PrimaryTitle = primaryTitle;
			Description = description;
			PrimaryImage = primaryImage;
			Year = year;
			ReleseDate = releseDate;
			Language = language;
			Budget = budget;
			GrossWorldWide = grossWorldWide;
			Geners = geners;
			IsAdult = isAdult;
			RunTimeMinutes = runTimeMinutes;
			RunTimeSeconds = runTimeSeconds;
			AverageRating = averageRating;
			NumVotes = numVotes;
		}

		public Movie()
		{
		}

		public bool Insert()
		{
			foreach (Movie movie in MovieList) { 
				if(Id == movie.Id || PrimaryTitle == movie.PrimaryTitle)
				{
					return false;
				}
			}
			
			MovieList.Add(this);
			return true;
		}

		static public List<Movie> Read()
		{
			return MovieList;
		}

		static public List<Movie> GetByTitle(string title)
		{
			List<Movie> selectedMovies = new List<Movie>();
			
			foreach (Movie movie in MovieList)
			{
				if (movie.PrimaryTitle.Contains(title))
				{
					selectedMovies.Add(movie);
				}
			}
			return selectedMovies;

		}
		static public List<Movie> GetByReleaseDate(DateTime startDate, DateTime endDate)
		{
			List<Movie> selectedMovies = new List<Movie>();

			if (startDate <= endDate)
			{
				foreach (Movie movie in MovieList)
				{
					if(movie.ReleseDate >= startDate && movie.ReleseDate <= endDate)
					{
						selectedMovies.Add(movie);
					}
				}
				return selectedMovies;
			}
			else { 
				throw new ArgumentOutOfRangeException("end-date is before start-date");
			}
			

		}
	}
}
