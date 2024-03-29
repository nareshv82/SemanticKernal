﻿// Copyright (c) Microsoft. All rights reserved.

using System.Net.Http;

namespace Microsoft.SemanticKernel.Connectors.Weaviate;

internal sealed class GetSchemaRequest
{
    public static GetSchemaRequest Create()
    {
        return new();
    }

    public HttpRequestMessage Build()
    {
        return HttpRequest.CreateGetRequest("schema");
    }
}
