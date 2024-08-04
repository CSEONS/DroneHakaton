using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DroneHakaton.Domain.Repositories.Entities
{
    public class Module
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public string Type { get; set; }

        public string Content { get; set; }

        public int Order { get; set; }

        public ICollection<Test> Tests { get; set; }

        public ICollection<UserProgress> Progresses { get; set; }
    }
}
