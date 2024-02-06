﻿// Copyright (c) Microsoft. All rights reserved.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.GoogleVertexAI;
using Microsoft.SemanticKernel.TextGeneration;
using Xunit;

namespace SemanticKernel.Connectors.GoogleVertexAI.UnitTests.Extensions;

public sealed class GoogleAIServiceCollectionExtensionsTests
{
    [Fact]
    public void GoogleAIGeminiTextGenerationServiceShouldBeRegisteredInKernelServices()
    {
        // Arrange
        var kernelBuilder = Kernel.CreateBuilder();

        // Act
        kernelBuilder.AddGoogleAIGeminiTextGeneration("modelId", "apiKey");
        var kernel = kernelBuilder.Build();

        // Assert
        var textGenerationService = kernel.GetRequiredService<ITextGenerationService>();
        Assert.NotNull(textGenerationService);
        Assert.IsType<GoogleAIGeminiTextGenerationService>(textGenerationService);
    }

    [Fact]
    public void GoogleAIGeminiTextGenerationServiceShouldBeRegisteredInServiceCollection()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        services.AddGoogleAIGeminiTextGeneration("modelId", "apiKey");
        var serviceProvider = services.BuildServiceProvider();

        // Assert
        var textGenerationService = serviceProvider.GetRequiredService<ITextGenerationService>();
        Assert.NotNull(textGenerationService);
        Assert.IsType<GoogleAIGeminiTextGenerationService>(textGenerationService);
    }

    [Fact]
    public void GoogleAIGeminiChatCompletionServiceAsIChatCompletionShouldBeRegisteredInKernelServices()
    {
        // Arrange
        var kernelBuilder = Kernel.CreateBuilder();

        // Act
        kernelBuilder.AddGoogleAIGeminiChatCompletion("modelId", "apiKey");
        var kernel = kernelBuilder.Build();

        // Assert
        var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
        Assert.NotNull(chatCompletionService);
        Assert.IsType<GoogleAIGeminiChatCompletionService>(chatCompletionService);
    }

    [Fact]
    public void GoogleAIGeminiChatCompletionServiceAsIChatCompletionShouldBeRegisteredInServiceCollection()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        services.AddGoogleAIGeminiChatCompletion("modelId", "apiKey");
        var serviceProvider = services.BuildServiceProvider();

        // Assert
        var chatCompletionService = serviceProvider.GetRequiredService<IChatCompletionService>();
        Assert.NotNull(chatCompletionService);
        Assert.IsType<GoogleAIGeminiChatCompletionService>(chatCompletionService);
    }

    [Fact]
    public void GoogleAIGeminiChatCompletionServiceAsITextGenerationShouldBeRegisteredInServiceCollection()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        services.AddGoogleAIGeminiChatCompletion("modelId", "apiKey");
        var serviceProvider = services.BuildServiceProvider();

        // Assert
        var textGenerationService = serviceProvider.GetRequiredService<ITextGenerationService>();
        Assert.NotNull(textGenerationService);
        Assert.IsType<GoogleAIGeminiChatCompletionService>(textGenerationService);
    }

    [Fact]
    public void GoogleAIGeminiChatCompletionServiceAsITextGenerationShouldBeRegisteredInKernelServices()
    {
        // Arrange
        var kernelBuilder = Kernel.CreateBuilder();

        // Act
        kernelBuilder.AddGoogleAIGeminiChatCompletion("modelId", "apiKey");
        var kernel = kernelBuilder.Build();

        // Assert
        var textGenerationService = kernel.GetRequiredService<ITextGenerationService>();
        Assert.NotNull(textGenerationService);
        Assert.IsType<GoogleAIGeminiChatCompletionService>(textGenerationService);
    }
}