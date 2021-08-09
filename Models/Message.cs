using System;
using System.ComponentModel.DataAnnotations;

namespace The_Unsent_Project.Models
{
    public record Message
    {
        [Key] public int Identifier { get; init; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(140)]
        public string To { get; init; }

        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(140)]
        public string Content { get; init; }

        [DataType(DataType.DateTime)] public DateTime CreatedAt { get; init; } = DateTime.Now;
    }
}