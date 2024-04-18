using System.ComponentModel.DataAnnotations;

namespace APItest.Entities
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string TeamLocation { get; set; }
    }
}