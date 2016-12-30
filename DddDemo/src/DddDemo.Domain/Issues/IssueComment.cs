﻿using System;
using JetBrains.Annotations;

namespace DddDemo.Issues
{
    public class IssueComment //Entity
    {
        [NotNull]
        public string Id { get; protected set; }

        [NotNull]
        public string Message { get; protected set; }

        [NotNull]
        public string CreatorUserId { get; protected set; }

        public IssueComment([NotNull] string creatorUserId, [NotNull] string message)
        {
            Check.NotNull(creatorUserId, nameof(creatorUserId));
            Check.NotNull(message, nameof(message));

            Id = Guid.NewGuid().ToString("D");

            Message = message;
            CreatorUserId = creatorUserId;
        }
    }
}