namespace SportClubApi.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Client> Clients { get; set; }
        public List<Coach> Coachs { get; set; } 
        public List<Administration> Administrations { get; set; }
    }
}
