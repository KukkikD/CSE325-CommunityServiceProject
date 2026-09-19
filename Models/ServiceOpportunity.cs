using CSE325_CommunityServiceProject.Data;

namespace CSE325_CommunityServiceProject.Models
{
    public class ServiceOpportunity
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        public DateTime DateTime { get; set; }

        public string Location { get; set; } = String.Empty;

        public OpportunityStatus Status { get; set; } = OpportunityStatus.Open;

        public string OrganizerUserId { get; set; } = string.Empty;

        public ApplicationUser Organizer { get; set; } = null!;

        public List<ServiceTask> Tasks { get; set; } = [];
    }
}