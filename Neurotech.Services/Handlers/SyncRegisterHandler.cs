﻿using MediatR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using Neurotech.Application.Commands;
using Neurotech.Application.ValueObjects;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Neurotech.Application.Exceptions;

namespace Neurotech.Services.Handlers
{
    public class SyncRegisterHandler : IRequestHandler<RegisterCommand, ResultVO>
    {
        private readonly IHttpClientFactory httpClientFactory;

        private readonly IConfiguration configuration;

        public SyncRegisterHandler(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            this.httpClientFactory = httpClientFactory;
            this.configuration = configuration;
        }

        public async Task<ResultVO> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {

            var httpClient = httpClientFactory.CreateClient("neurotech");
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "text/plain; application/json");
            var stringContent = PrepararBody(request);
            var content = new StringContent(stringContent, Encoding.UTF32, "application/json");
            try
            {
                using (var result = await httpClient.PostAsync($"/services/rest/workflow/submit", content))
                {
                    if (result.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ConexaoNeurotechException();
                    }

                    return DeserializeResponse<ResultVO>(result.Content);
                }
            }
            catch
            {
                throw new ConexaoNeurotechException();
            }
        }

        private string PrepararBody(RegisterCommand request)
        {
            if (request.Authentication is null)
            {
                var Login = configuration.GetValue<string>("Neurotech:Login");
                var Password = configuration.GetValue<string>("Neurotech:Password");

                request.Authentication = new AuthenticationVO(Login, Password);
            }

            return JsonConvert.SerializeObject(request, Formatting.Indented);
        }

        private T DeserializeResponse<T>(HttpContent responseContent)
        {
            string _responseContent = responseContent.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(_responseContent);
        }
    }
}
