using System;
namespace JiraDashboard.JiraFeatures.Dto
{
    public class Fields
    {
        public IssueType IssueType { get; set;}

        public String LastViewed { get; set; }

        public String Created { get; set;}

        public Priority Priority { get; set; }

        public Status Status { get; set; }

        public string Summary { get; set; }

        public JiraFeatureDto[] SubTasks { get; set; }

    }

    public class IssueType
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class Status
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }

    public class Priority
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }

}
