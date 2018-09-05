namespace Portfolio.Models
{
	public class PortfolioProject
	{
		public PortfolioProject(string description, string projectRepo, string projectDemo)
		{
			Description = description;
			ProjectRepo = projectRepo;
			ProjectDemo = projectDemo;
		}
	
		private string Description { get; set; }
		private string ProjectRepo { get; set; }
		private string ProjectDemo { get; set; }
	}
}