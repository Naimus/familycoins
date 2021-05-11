using System;
using System.ComponentModel.DataAnnotations;

namespace familycoins.Models
{
    public class FamilyMember
    {
        [Key]
        public int Id {get; set;}
        
        [Required]
        public string Name {get; set;}
        
        public string Details {get; set;}
        public int FamilyCoinsScore {get;set;}
    }
}