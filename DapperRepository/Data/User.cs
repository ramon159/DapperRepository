using System.ComponentModel.DataAnnotations.Schema;

namespace DapperRepository.Data
{
    public class User
    {
        [Column(name: "id")]
        public int Id { get; set; }

        [Column(name: "username")]
        public string UserName { get; set; }

        [Column(name: "email")]
        public string Email { get; set; }

        [Column(name: "password")]
        public string Password { get; set; }
    }
}
