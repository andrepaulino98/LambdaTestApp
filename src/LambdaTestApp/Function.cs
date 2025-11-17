using System;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using Humanizer;
using LambdaTestApp.Models;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaTestApp
{
    public class Function
    {
        public ResponseModel FunctionHandler(object input, ILambdaContext context)
        {
            var json = JsonConvert.SerializeObject(input);
            return new ResponseModel
            {
                Mensagem = $"Olá da Lambda em .NET 8! Entrada: {json}",
                Data = DateTime.Now
            };
        }
    }
}
