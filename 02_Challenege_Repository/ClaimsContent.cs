using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenege_Repository
{
    public enum ClaimType { Car = 1, Home, Theft }
    public class ClaimsContent
    {
        
        public ClaimsContent()
        {

        }
        public int ClaimId { get; set; }
        public ClaimType ClaimType {get; set;}
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; } 
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; } //keep it in the build so that its apart but it doesnt need to be in the contructor?? not 100% sure why.

        public ClaimsContent(int claimId, ClaimType claimType, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimId = claimId;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = (dateOfClaim - dateOfIncident).Days <= 30; //default value would be false so we set it as true to equal Isvalid

        }

        
    }

}
