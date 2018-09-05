using System.Collections.Generic;

namespace Portfolio.Models
{
	public class TechnicalSkill
	{
		public TechnicalSkill(List<string> skills, List<string> tools)
		{
			SkillList = skills;
			ToolList = tools;
		}
		private List<string> SkillList { get; set; }
		private List<string> ToolList { get; set; }
	}
}