namespace Portfolio.Models
{
	public class WorkExperience
	{
		public WorkExperience(string title, string employer, string timeSpan, string location, string description)
		{
			Title = title;
			Employer = employer;
			TimeSpan = timeSpan;
			Location = location;
			Description = description;
		}

		private string Title { get; set; }
		private string Employer { get; set; }
		private string TimeSpan { get; set; }
		private string Location { get; set; }
		private string Description { get; set; }
	}
}