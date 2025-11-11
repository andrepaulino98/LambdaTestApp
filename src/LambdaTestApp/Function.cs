using Amazon.Lambda.Core;
using Newtonsoft.Json;
using Humanizer;
using LambdaTestApp.Models;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaTestApp;

public class Function
{
    public ResponseModel FunctionHandler(IDictionary<string, string>? input, ILambdaContext context)
    {
        var now = DateTime.UtcNow;

        return new ResponseModel
        {
            Message = "Olá do .NET 8 rodando na AWS Lambda! 🚀",
            Now = now,
            HumanizedTime = now.Humanize(false)
        };
    }
}
