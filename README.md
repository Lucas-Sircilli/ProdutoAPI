# ProdutoAPI

# ProdutoAPI - Backend : API desenvolvida em ASP.NET Core para gerenciar produtos.

## 📋 Pré-requisitos

### Backend
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- (OPCIONAL) [Visual Studio](https://visualstudio.microsoft.com/pt-br/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false)
- [Postman](https://www.postman.com/downloads/) (opcional para testes de API)

## Complemento ##
Tanto a API quanto a instância já foi feito o deploy de ambos, importante lembrar que o postman está configurando para consumir a API publicada, caso queira testar localmente, só trocar o link por um desses endereços:
# Endereços padrão:
# - https://localhost:7055
# - http://localhost:5055

## 🚀 Configuração e Execução

### 1️⃣ Clonar repositórios
```bash
git clone https://github.com/Lucas-Sircilli/ProdutoAPI.git
```

### 2️⃣ Backend - ProdutoAPI
```bash
# Acessar pasta
cd ProdutoAPI

# Configurar conexão com banco (editar appsettings.json e colocar o texto que foi encaminhado no email)
# "ConnectionStrings": {
#     "DefaultConnection": "texto do email"
# }

# Rodar API
dotnet run
```

## 📄 Licença
Este projeto está sob a licença MIT.
