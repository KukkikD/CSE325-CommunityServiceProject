using CSE325_CommunityServiceProject.Data;
using System.ComponentModel.DataAnnotations;

namespace CSE325_CommunityServiceProject.Models
{
    public class ServiceOpportunity
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; } = String.Empty;

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; } = String.Empty;

        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; } = String.Empty;

        public OpportunityStatus Status { get; set; } = OpportunityStatus.Open;

        public string OrganizerUserId { get; set; } = string.Empty;

        public ApplicationUser Organizer { get; set; } = null!;

        public List<ServiceTask> Tasks { get; set; } = [];
    }
}