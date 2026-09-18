using CSE325_CommunityServiceProject.Data;

namespace CSE325_CommunityServiceProject.Models
{
    public class VolunteerSignup
    {
        public Guid Id { get; set; }

        public DateTime SignupDate { get; set; } = DateTime.UtcNow;

        public Guid ServiceTaskId { get; set; }

        public ServiceTask ServiceTask { get; set; } = null!;

        public string VolunteerUserId { get; set; } = string.Empty;

        public ApplicationUser Volunteer { get; set; } = null!;
    }
}