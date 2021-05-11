using System;
using System.ComponentModel.DataAnnotations;

namespace familycoins.Models
{
    public class FamilyPointsTransaction
    {
        [Key]
        public int Id {get; set;}
        public FamilyPointsTransactionType TypeOfTransaction { get; set;}

        [Required]
        public string Name {get; set;}

        public string Details {get; set;}
        
        [Required]
        public int points {get; set;}
    }
}