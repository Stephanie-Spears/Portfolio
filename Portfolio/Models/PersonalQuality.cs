using System.Collections.Generic;

namespace Portfolio.Models
{
	public class PersonalQuality
	{
		public PersonalQuality(string intro, List<string> qualities)
		{
			Intro = intro;
			Qualities = qualities;
		}

		private string Intro { get; set; }
		private List<string> Qualities { get; set; }		
	}
}