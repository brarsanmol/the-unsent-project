using System;
using System.ComponentModel.DataAnnotations;

namespace The_Unsent_Project.Models
{
    /// <summary>
    /// The model for messages.
    /// </summary>
    public record Message
    {
        /// <summary>
        /// The message identifier.
        /// </summary>
        [Key] public int Identifier { get; init; }

        /// <summary>
        /// The person who the message was addressed to.
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(140)]
        public string To { get; init; }

        /// <summary>
        /// The message.
        /// </summary>
        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(140)]
        public string Content { get; init; }

        /// <summary>
        /// The date and time the message was created at.
        /// </summary>
        [DataType(DataType.DateTime)] public DateTime CreatedAt { get; init; } = DateTime.Now;
    }
}