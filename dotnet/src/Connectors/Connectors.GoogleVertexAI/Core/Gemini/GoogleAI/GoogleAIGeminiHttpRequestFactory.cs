﻿// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Net.Http;
using Microsoft.SemanticKernel.Http;

namespace Microsoft.SemanticKernel.Connectors.GoogleVertexAI;

internal sealed class GoogleAIGeminiHttpRequestFactory : IHttpRequestFactory
{
    public HttpRequestMessage CreatePost(object requestData, Uri endpoint)
    {
        var httpRequestMessage = HttpRequest.CreatePostRequest(endpoint, requestData);
        httpRequestMessage.Headers.Add("User-Agent", HttpHeaderValues.UserAgent);
        return httpRequestMessage;
    }
}
