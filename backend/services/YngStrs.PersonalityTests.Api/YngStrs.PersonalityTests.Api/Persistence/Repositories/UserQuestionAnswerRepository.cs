﻿using Marten;
using Marten.Events;
using YngStrs.PersonalityTests.Api.Domain.Entities;
using YngStrs.PersonalityTests.Api.Domain.Repositories;

namespace YngStrs.PersonalityTests.Api.Persistence.Repositories
{
    public class UserQuestionAnswerRepository : IUserQuestionAnswerRepository
    {
        private readonly IDocumentSession _session;

        public UserQuestionAnswerRepository(IDocumentSession session)
        {
            _session = session;
        }

        public EventStream CreateUserQuestionAnswerEventStream()
        {
            var eventStream = _session.Events.StartStream<UserQuestionAnswer>();
            _session.SaveChangesAsync();
            return eventStream;
        }
    }
}