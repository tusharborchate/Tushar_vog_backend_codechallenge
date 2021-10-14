using System;
using System.IO;
using System.Text;

using Amazon.Lambda.Core;
using Amazon.Lambda.DynamoDBEvents;
using Amazon.DynamoDBv2.Model;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using System.Threading.Tasks;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWS_Lambda
{
    public class Function
    {
        private static AmazonLambdaClient lambdaClient;

        static Function()
        {
            initialize();
        }

        static async void initialize()
        {
            lambdaClient = new AmazonLambdaClient();
            await callLambda();
        }
        public void FunctionHandler(DynamoDBEvent dynamoEvent, ILambdaContext context)
        {
            context.Logger.LogLine($"Beginning to process {dynamoEvent.Records.Count} records...");

            foreach (var record in dynamoEvent.Records)
            {
                context.Logger.LogLine($"Event ID: {record.EventID}");
                context.Logger.LogLine($"Event Name: {record.EventName}");
				
				// TODO: Add business logic processing the record.Dynamodb object.
            }

            context.Logger.LogLine("Stream processing complete.");
        }
        public static async Task<GetAccountSettingsResponse> callLambda()
        {
            var request = new GetAccountSettingsRequest();
            var response = await lambdaClient.GetAccountSettingsAsync(request);
            return response;
        }
    }
}