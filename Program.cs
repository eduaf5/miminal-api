var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Ola Pessoal!");

app.MapPost("/login", (loginDTO loginDTO) => {
if(loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
    return Results.Ok("Login com sucesso");
else
    return Results.Unauthorized();

});

app.Run();

public class loginDTO
{
    public string Email { get;set; } = default!;
    public string Senha { get;set; } = default!;

}