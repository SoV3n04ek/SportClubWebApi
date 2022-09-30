namespace SportClubApi.Models
{
    public class Administration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

       
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        // Менеджер | Главный менеджер залла
        // Manager | General manager

        public Role Role { get; set; }
    }
}
