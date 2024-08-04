using DroneHakaton.Domain.Repositories.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DroneHakaton.Domain.Repositories.Entities
{
    public class UserProgress
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public Guid ModuleId { get; set; }
        public Module Module { get; set; }
        public string CompletionStatus { get; set; }
        public int? Score { get; set; }
    }
}