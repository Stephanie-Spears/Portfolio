namespace Portfolio.Models
{
	public class ContactInformation
	{
		public ContactInformation(string name, string title, string mobile, string email, string github, string linkedin, string homepage)
		{
			Name = name;
			Title = title;
			Mobile = mobile;
			Email = email;
			GitHub = github;
			LinkedIn = linkedin;
			Homepage = homepage;
		}

		private string Name { get; set; }
		private string Title { get; set;}
		private string Mobile { get; set; }
		private string Email { get; set; }
		private string GitHub { get; set; }
		private string LinkedIn { get; set; }
		private string Homepage { get; set; }

	}
}