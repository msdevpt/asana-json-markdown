// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace Models{
    public class Assignee
    {
        public string gid { get; set; }
        public string name { get; set; }
        public string resource_type { get; set; }
    }

    public class AssigneeSection
    {
        public string gid { get; set; }
        public string name { get; set; }
        public string resource_type { get; set; }
    }

    public class Follower
    {
        public string gid { get; set; }
        public string name { get; set; }
        public string resource_type { get; set; }
    }

    public class Project
    {
        public string gid { get; set; }
        public string name { get; set; }
        public string resource_type { get; set; }
    }

    public class Section
    {
        public string gid { get; set; }
        public string name { get; set; }
        public string resource_type { get; set; }
    }

    public class Membership
    {
        public Project project { get; set; }
        public Section section { get; set; }
    }

    public class Project2
    {
        public string gid { get; set; }
        public string name { get; set; }
        public string resource_type { get; set; }
    }

    public class Parent
    {
        public string gid { get; set; }
        public string name { get; set; }
        public string resource_type { get; set; }
    }

    public class Workspace
    {
        public string gid { get; set; }
        public string name { get; set; }
        public string resource_type { get; set; }
    }

    public class Subtask
    {
        public string gid { get; set; }
        public object assignee { get; set; }
        public string assignee_status { get; set; }
        public bool completed { get; set; }
        public DateTime? completed_at { get; set; }
        public DateTime created_at { get; set; }
        public List<object> custom_fields { get; set; }
        public object due_at { get; set; }
        public object due_on { get; set; }
        public List<Follower> followers { get; set; }
        public bool hearted { get; set; }
        public List<object> hearts { get; set; }
        public bool liked { get; set; }
        public List<object> likes { get; set; }
        public List<object> memberships { get; set; }
        public DateTime modified_at { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
        public int num_hearts { get; set; }
        public int num_likes { get; set; }
        public Parent parent { get; set; }
        public string permalink_url { get; set; }
        public List<object> projects { get; set; }
        public string resource_type { get; set; }
        public object start_at { get; set; }
        public object start_on { get; set; }
        public List<object> subtasks { get; set; }
        public List<object> tags { get; set; }
        public string resource_subtype { get; set; }
        public Workspace workspace { get; set; }
    }

    public class Datum
    {
        public string gid { get; set; }
        public Assignee assignee { get; set; }
        public string assignee_status { get; set; }
        public AssigneeSection assignee_section { get; set; }
        public bool completed { get; set; }
        public DateTime? completed_at { get; set; }
        public DateTime created_at { get; set; }
        public List<object> custom_fields { get; set; }
        public object due_at { get; set; }
        public string due_on { get; set; }
        public List<Follower> followers { get; set; }
        public bool hearted { get; set; }
        public List<object> hearts { get; set; }
        public bool liked { get; set; }
        public List<object> likes { get; set; }
        public List<Membership> memberships { get; set; }
        public DateTime modified_at { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
        public int num_hearts { get; set; }
        public int num_likes { get; set; }
        public object parent { get; set; }
        public string permalink_url { get; set; }
        public List<Project> projects { get; set; }
        public string resource_type { get; set; }
        public object start_at { get; set; }
        public object start_on { get; set; }
        public List<Subtask> subtasks { get; set; }
        public List<object> tags { get; set; }
        public string resource_subtype { get; set; }
        public Workspace workspace { get; set; }
    }

    public class Root
    {
        public List<Datum> data { get; set; }
    }

}