namespace Portfolio.Models
{
	public class Education
	{

		public Education(string schoolName, string certification, string major, string timeSpan, string cityState)
		{
			SchoolName = schoolName;
			Certification = certification;
			Major = major;
			TimeSpan = timeSpan;
			CityState = cityState;
		}

		private string SchoolName { get; set; }
		private string Certification { get; set; }
		private string Major { get; set; }
		private string TimeSpan { get; set; }
		private string CityState { get; set; }
	}
}