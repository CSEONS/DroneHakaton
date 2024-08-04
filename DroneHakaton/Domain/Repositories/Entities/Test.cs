using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DroneHakaton.Domain.Repositories.Entities
{
    public class Test
    {
        public Guid Id { get; set; }
        public Guid ModuleId { get; set; }
        public Module Module { get; set; }
        public ICollection<Question> Questions { get; set; }
        public string Answers { get; set; }
        public string Feedback { get; set; }
    }
}
