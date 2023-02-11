#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/CoffeeShop.Api/CoffeeShop.Api.csproj", "src/CoffeeShop.Api/"]
COPY ["src/CoffeeShop.Business/CoffeeShop.Business.csproj", "src/CoffeeShop.Business/"]
COPY ["src/CoffeeShop.Core/CoffeeShop.Core.csproj", "src/CoffeeShop.Core/"]
COPY ["src/CoffeeShop.Domain/CoffeeShop.Domain.csproj", "src/CoffeeShop.Domain/"]
COPY ["src/CoffeeShop.Persistance/CoffeeShop.Persistance.csproj", "src/CoffeeShop.Persistance/"]
RUN dotnet restore "src/CoffeeShop.Api/CoffeeShop.Api.csproj"
COPY . .
WORKDIR "/src/src/CoffeeShop.Api"
RUN dotnet build "CoffeeShop.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoffeeShop.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoffeeShop.Api.dll"]