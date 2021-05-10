using System;

namespace familycoins
{
    public class FamilyPointsTransaction
    {
        public int Id {get; set;}
        public FamilyPointsTransactionType TypeOfTransaction { get; set;}
        public string Name {get; set;}
        public string Details {get; set;}
        public int points {get; set;}
    }
}