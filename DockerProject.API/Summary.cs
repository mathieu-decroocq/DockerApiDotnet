namespace DockerProject.API
{
    public class Summary
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Summary(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}