# Getting Started

These samples demonstrates how to use the Azure OpenAI with a `gpt-35-turbo` and `dall-e-3` models, from a simple .NET 8.0 console application. It consists of a simple console applications, running locally, that will send request to an Azure OpenAI service deployed in your Azure subscription. 

Everything will be deployed automatically using the Azure Developer CLI.


## Prerequisites

- .NET 8.0 SDK - [Install the .NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- An Azure subscription - [Create one for free](https://azure.microsoft.com/free)
- Azure Developer CLI - [Install or update the Azure Developer CLI](https://learn.microsoft.com/azure/developer/azure-developer-cli/install-azd)
- Access to [Azure OpenAI service](https://learn.microsoft.com/azure/ai-services/openai/overview#how-do-i-get-access-to-azure-openai).


## Deploying the Azure resources

Ensure that you follow the [Prerequisites](#prerequisites) to have access to Azure OpenAI Service as well as the Azure Developer CLI, and then follow the following guide to set started with the sample application.

1. Clone/ Download the repository
   
2. From a terminal or command prompt, navigate to the `Getting-Started` directory.

3. Create the Azure resources (Azure OpenAI service, gpt-35-turbo and dall-e-3 models) using the Azure Developer CLI. Only the regions that support the Azure OpenAI service with the models will be displayed. 
	```bash
	azd up
	```

	> 💡 If you already have an Azure OpenAI service available, you can skip the deployment and use hardcoded value in the `program.cs`.
	

## Azure OpenAI SDK (SDK)

The [Azure OpenAI client library for .NET](https://learn.microsoft.com/en-us/azure/ai-services/openai/) is an adaptation of OpenAI's REST APIs that provides an idiomatic interface and rich integration with the rest of the Azure SDK ecosystem. It can connect to Azure OpenAI resources or to the non-Azure OpenAI inference endpoint, making it a great choice for even non-Azure OpenAI development.

## Semantic Kernel (SK)

[Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/overview/) is an open-source SDK that lets you easily build agents that can call your existing code. As a highly extensible SDK, you can use Semantic Kernel with models from OpenAI, Azure OpenAI, Hugging Face, and more!

## Trying the samples

Now that your Azure OpenAI Service is deployed, It's time to select one of our sample to experiment different scenarios.

| Sample                | Description                         | Semantic Kernel | Azure OpenAI SDK |
|-----------------------|-------------                        |-----------------|------------------|
| Hike Benefits Summary | Summarize long text to a few words. | [SK](semantic-kernel/01-HikeBenefitsSummary/README.md) | [SDK](azure-openai-sdk/01-HikeBenefitsSummary/README.md) |
| Hiker AI              | Chat with the AI and get hike recommendation. | [SK](semantic-kernel/02-HikerAI/README.md) | [SDK](azure-openai-sdk/02-HikerAI/README.md) |
| Chatting About my Previous Hikes | Chat with the AI about your previous hikes. | [SK](semantic-kernel/03-ChattingAboutMyHikes/README.md) | [SDK](azure-openai-sdk/03-ChattingAboutMyHikes/README.md) |
| Hiker AI Pro          | Extending the AI model with a local function using Function Tool. | [SK](semantic-kernel/04-AiAndNative/README.md) | [SDK](azure-openai-sdk/04-HikerAIPro/README.md) |
| Hike Images           | Generate postal card images to invite your friends for a hike. | [SK](semantic-kernel/05-HikeImages/README.md) | [SDK](azure-openai-sdk/05-HikeImages/README.md) |

## Clean up resources

When you are done experimenting with the samples, you can delete the Azure resources created using the Azure Developer CLI.

```bash
azd down
```

## Troubleshooting

On Windows, you may get an error message: "*postprovision.ps1 is not digitally signed. The script will not execute on the system*" after the deployment. This is cause by the script "postprovision" being executed locally after the deployment to create .NET secret that will be used in the application. To avoid this error, execute the command `Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass`. And re-run the `azd up` command.
