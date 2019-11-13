﻿namespace YngStrs.Mvc.Client
{
    public static class GlobalConstants
    {
        public static class HttpClientNames
        {
            public const string TestClientName = "PersonalityTestClient";
            public const string ChatbotClientName = "ChatbotClient";
        }

        public static class PersonalityTestApiUrls
        {
            public const string GetStructuredUrlPath = "/api/personality-tests/structured";
            public const string RegisterUserAnswerUrlPath = "api/personality-tests/user-answer/";
            public const string SaveResultsUrlPath = "api/personality-tests/user-result/save";
        }

        public static class ChatbotApiUrls
        {
            public const string SaveUserResultsUrlPath = "/api/chatbot/save-results";
        }

        public static class UserIdentifier
        {
            internal const string UserAnswersEventStreamId = "stream_id";
        }
    }
}