FROM mcr.microsoft.com/dotnet/sdk:7.0

ENV PATH="${PATH}:/root/.dotnet/tools"

RUN dotnet tool install --global dotnet-ef  --version 7.0

WORKDIR /src

COPY ["src/CoffeeShop.Api/CoffeeShop.Api.csproj", "src/CoffeeShop.Api/"]
COPY ["src/CoffeeShop.Business/CoffeeShop.Business.csproj", "src/CoffeeShop.Business/"]
COPY ["src/CoffeeShop.Core/CoffeeShop.Core.csproj", "src/CoffeeShop.Core/"]
COPY ["src/CoffeeShop.Domain/CoffeeShop.Domain.csproj", "src/CoffeeShop.Domain/"]
COPY ["src/CoffeeShop.Persistance/CoffeeShop.Persistance.csproj", "src/CoffeeShop.Persistance/"]

RUN dotnet restore "src/CoffeeShop.Api/CoffeeShop.Api.csproj"

COPY . .

WORKDIR "./"

ADD migration_script.sh  .

RUN chmod +x ./migration_script.sh

CMD /bin/bash ./migration_script.sh
