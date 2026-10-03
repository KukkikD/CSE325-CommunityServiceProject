using System.ComponentModel.DataAnnotations;

namespace CSE325_CommunityServiceProject.Models
{
    public class ServiceTask
    {
        public Guid Id { get; set; }

        // Prevent empty tasks from being created.
        [Required(ErrorMessage = "Task title is required.")]
        public string Title { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "At least one volunteer is required.")]
        public int VolunteersNeeded { get; set; }

        public Guid ServiceOpportunityId { get; set; }

        public ServiceOpportunity ServiceOpportunity { get; set; } = null!;

        public List<VolunteerSignup> VolunteerSignups { get; set; } = [];
    }
}