namespace CSE325_CommunityServiceProject.Models
{
    public class ServiceTask
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        public decimal EstimatedHours { get; set; }

        public int VolunteersNeeded { get; set; }

        public Guid ServiceOpportunityId { get; set; }

        public ServiceOpportunity ServiceOpportunity { get; set; } = null!;

        public List<VolunteerSignup> VolunteerSignups { get; set; } = [];
    }
}