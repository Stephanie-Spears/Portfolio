//using System.Collections.Generic;
//using Portfolio.Models;
//
//namespace Portfolio.Data
//{
//	public static class Data
//	{
//		public static ContactInformation ContactInformationDetails { get; set; }
//		public static List<Education> EducationList { get; set; }
//		public static PersonalQuality PersonalQualities { get; set; }
//		public static List<PortfolioProject> PortfolioProjectList { get; set; }
//		public static TechnicalSkill TechnicalSkills { get; set; }
//		public static List<WorkExperience> WorkExperienceList { get; set; }
//
//		
//		static Data()
//		{
//			InitData();
//		}
//
//	private static void InitData()
//		{
//			var contactInformation = new ContactInformation("Stephanie Spears", "Full Stack Developer", "503-459-3847", "Stephanie.Spears1@gmail.com", "https://github.com/Stephanie-Spears", "https://linkedin.com/in/Stephanie-Spears", "https://Stephanie-Spears.github.io/homepage/");
//
//			var education = new List<Education>()
//			{
//				new Education("Launch Code", "Certificate of Completion", "Key Coursework: Web Development, Python, Java", "Nov 2017", "Portland, OR"),
//				new Education("Portland Community College", "", "Key Coursework: Computer Science, C/C++", "Oct 2017", "Portland, OR"),
//				new Education("University of Oregon", "Bachelor of Arts", "Majors: Psychology, Humanities, English", "Nov 2012", "Eugene, OR")
//			};
//
//			string intro =
//				"Full Stack Developer with an avidity for mastering new skills and technologies. Proficient in C/C++, C#, Java, Python, JavaScript, HTML, CSS, SQL, Bash, Arduino, and VB. Personal areas of interest include machine learning, VR app development, and IoT embedded system micro-controllers.";
//
//			List<string> qualities = new List<string>(new[]
//			{
//				"Excellent written and verbal communication",
//				"Highly organized and detail-oriented",
//				"Learn and adapt quickly",
//				"Good sense of humor and positive attitude",
//				"Analytical thinking and research ability",
//				"Work effectively as part of a team or independently"
//			});
//
//			var personalQualities = new PersonalQuality(intro, qualities);
//
//			var portfolioProjects = new List<PortfolioProject>()
//			{
//				new PortfolioProject("A Flask web application developed in collaboration with a team of four using a Scrum-based framework. Technologies included Ajax, React, jQuery, Google Maps API, SQLAlchemy, PostgreSQL, and AWS-S3(DB), ElasticSearch/Kibana (full-text search), MS Azure’s Translate API (language translation and support), Moment.js (date/time localization), and Flask-Mail (SMTP/TLS).", "https://github.com/Stephanie-Spears/iGotta", "https://i-gotta.herokuapp.com"),
//				new PortfolioProject("An organizational tool for music libraries written in C++ and initially implementing a simple console application UI. Subsequent updates to the UI were made to incorporate a deployable frontend with Node.js, AngularJS, JSON, and SCSS. Development tools include Vim, GDB, g++, and Valgrind. Concepts included doubly linked lists, memory allocation, sorting algorithms, and Big O analysis.","https://github.com/Stephanie-Spears/MusicLibrary",""),
//				new PortfolioProject("A RESTful restaurant menu application in Java, configured with a Gradle build, and utilizing the Spring Framework. Templating in ThymeLeaf, and RDBMS employing MySQL.", "https://github.com/Stephanie-Spears/cheese-mvc-persistent","")
//			};
//
//			var skills = new List<string>
//				{"C/C++", "C#", "ASP.NET MVC", "Java", "Python", "JavaScript", "HTML", "CSS", "SASS", "SQL", "Bash", "Arduino", "VB", "XML", "TensorFlow"};
//			var tools = new List<string> { "Agile", "Scrum", "Git", "Visual Studio", "TFS", "Continuous Integration", "Unit Testing", "SEO", "Bootstrap", "jQuery", "Django", "Flask", "AJAX", "RESTful WebServices", "PostgreSQL", "React.js", "AngularJS", "ElasticSearch", "Umbraco", "Spring", "ThymeLeaf", "Entity"};
//
//			var technicalSkills = new TechnicalSkill(skills, tools);
//
//			var workExperience = new List<WorkExperience>()
//			{
//				new WorkExperience("Full Stack Developer", "Graphic Products", "April 2018-Present", "Beaverton, OR", "As a member of an Agile software development team, we worked closely to build and maintain company	e-commerce and web presence platforms from within a continuous integration environment. Migrated, redesigned, and optimized both front-end and back-end components with Microsoft stack technologies, including ASP.Net MVC framework in C#, Razor view engine, TFS source control, and Umbraco CMS."),
//				new WorkExperience("Content Developer/Consultant", "Self-Employed", "March 2012-April 2018", "Osaka, Japan", "Collaborated using an Agile framework with overseas colleagues to develop and improve professional, technical, and informational materials to be used in both print and digital media. Areas of work include procedural documentation, scholarly articles, scientific studies, and international conference speeches. Notable employers include Panasonic Lighting, the Kubota Group, and Nissin Foods"),
//				new WorkExperience("Language Consultant", "Kuzuha College", "Feb 2012-March 2015", "Kobe, Japan", "Developed materials for use in business and academic settings, including technical and advertisement copywriting"),
//				new WorkExperience("Research Assistant", "Scott T. Bailey, Attorney at Law", "June 2011-Sept 2012", "Florence, OR", "Assisted with researching, organizing, and summarizing medical evidence in support of medical disability claims."),
//				new WorkExperience("Academic Tutor", "University of Oregon", "Nov 2009-June 2011", "Eugene, OR", "Academic tutor at the University of Oregon, working primarily with non-native English speakers.")
//			};
//
//			ContactInformationDetails = contactInformation;
//			EducationList = education;
//			PersonalQualities = personalQualities;
//			PortfolioProjectList = portfolioProjects;
//			TechnicalSkills = technicalSkills;
//			WorkExperienceList = workExperience;
//
//		}
//
//		public static List<object> GetResumeList()
//		{
//			List<object> myResumeList = new List<object>
//			{
//				ContactInformationDetails,
//				EducationList,
//				PersonalQualities,
//				PortfolioProjectList,
//				TechnicalSkills,
//				WorkExperienceList
//			};
//			return myResumeList;
//		}
//	}
//}