﻿using System;
using YngStrs.Common.EventSourcing.Core;

namespace YngStrs.PersonalityTests.Api.Domain.Events
{
    public class UserResultCalculated : IEvent
    {
        public UserResultCalculated(Guid personalityTestId, Guid[] testResultsIds)
        {
            PersonalityTestId = personalityTestId;
            TestResultsIds = testResultsIds;
        }

        public Guid PersonalityTestId { get; set; }

        public Guid[] TestResultsIds { get; set; }
    }
}