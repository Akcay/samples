﻿using System.ComponentModel.DataAnnotations;

namespace DddDemo.Issues.Dtos
{
    public class AssignIssueToUserInput
    {
        [Required]
        [MaxLength(128)]
        public string IssueId { get; set; }

        [Required]
        [MaxLength(128)]
        public string UserId { get; set; }
    }
}