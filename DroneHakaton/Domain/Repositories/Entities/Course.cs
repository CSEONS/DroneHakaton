using DroneHakaton.Domain.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Reflection;

namespace DroneHakaton.Domain.Repositories.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Module> Modules { get; set; }
        public Guid CreatorId { get; set; }
        public User Creator { get; set; }
        public ICollection<UserProgress> Progresses { get; set; }
    }
}
