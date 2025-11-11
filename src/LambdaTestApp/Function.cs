public class Entrada
{
    public string Mensagem { get; set; }
}

public string FunctionHandler(Entrada input, ILambdaContext context)
{
    var json = JsonConvert.SerializeObject(input);
    return $"Olá da Lambda em .NET 9! Entrada: {json}. Agora são {DateTime.Now.Humanize()}!";
}
