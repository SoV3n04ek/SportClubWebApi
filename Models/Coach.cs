namespace SportClubApi.Models
{
    public class Coach
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }  
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Specialization { get; set; }
        
        public string Login { get; set; }
        public string Password { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        // TODO: add график времени работы
    }
}
