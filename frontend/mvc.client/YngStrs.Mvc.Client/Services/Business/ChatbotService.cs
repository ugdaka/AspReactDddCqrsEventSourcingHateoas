﻿using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Marvin.StreamExtensions;
using Newtonsoft.Json;
using YngStrs.Mvc.Client.Models;
using YngStrs.Mvc.Client.Models.Chatbot;
using YngStrs.Mvc.Client.Services.Core;

namespace YngStrs.Mvc.Client.Services.Business
{
    public class ChatbotService : IChatbotService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ChatbotService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public object GetQuestionsContent()
        {
            const string resourcePath = "YngStrs.Mvc.Client.EmbeddedResources.";

            var questionsResourceStream = Assembly
                .GetExecutingAssembly()
                .GetManifestResourceStream(resourcePath + "questions.json");

            return questionsResourceStream.ReadAndDeserializeFromJson();
        }

        public async Task<bool> SaveUserChatbotAnswersAsync(ChatbotResultsRootObject rootObject)
        {
            var httpClient = _httpClientFactory.CreateClient("ChatbotClient");

            var request = new HttpRequestMessage(
                HttpMethod.Post,
                "/api/Chatbot/save-results");

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));

            var serializedRootObject = JsonConvert.SerializeObject(rootObject);

            request.Content = new StringContent(serializedRootObject)

            var response = await httpClient.SendAsync(
                request,
                HttpCompletionOption.ResponseHeadersRead,
                CancellationToken.None);

            return response.IsSuccessStatusCode;
        }

        public void ArrangeUserAnswers(ChatbotResultsRootObject rootObject)
        {
           var userAnswers = JsonConvert.DeserializeObject<IEnumerable<UserChatBotAnswer>>(rootObject.res);
           var userData = rootObject.form; //"name=dsfsfds&email=admin%40jbet.org&hr-checkbox=1"
        }
    }
}