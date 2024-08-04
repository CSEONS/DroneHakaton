using Microsoft.AspNetCore.Identity;

namespace DroneHakaton.Domain.Repositories.Entities
{
    public class User : IdentityUser<Guid>
    {
        public ICollection<UserProgress> Progresses { get; set; }
    }
}
