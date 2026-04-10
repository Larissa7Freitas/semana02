///
var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://localhost:8000");
var app = builder.Build();

//Variáveis
int idade = 15;
float altura = 1.75f;
string cidade = "Camaçari";
bool apovado =  false; 

app.MapGet("/", () => {
    return new { mensagem= "API em execução ... " };
});

app.MapGet("/calcula/{opcao}/{valor1}/{valo2}", (int opcao, int valor1, valor2) => {
    switch(opcao) {
        case 1:
            return new { resultado = valor1 + valor2};
        case 2:
           return new {resultado = valor1 - valor2};
        case 3:
           return new { resultado = valor1 * valor2};
        case 4:
        if  (valor2 == 0);
           return new {mensagem = " não é posível dividir por zero"};
           return new {resultado = valor1 / valor2};
        default:
           return new { mensagem= "Opção inválida ..."};
    }
});

app.MapGet("/calcula/{opcao}/{valor1}/{valor2}/{int opcao, int valor1, int valor2}"/{4/3}", (int opcao, int valor1, int valor2) => {
 switch(opcao){
        case 1:
            return new { resultado = valor1 + valor2 };
        case 2:
            return new { resultado = valor1 - valor2 };
        case 3:
            return new { resultado = valor1 * valor2 };
        case 4:
            if (valor2 == 0)
                return new { mensagem = "Não é possível dividir por zero" };
            return new { resultado = valor1 / valor2 };
        default:
            return new { mensagem = "Opção inválida..." };
    }
});

app.Run();