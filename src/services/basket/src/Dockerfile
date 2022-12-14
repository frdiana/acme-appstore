#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["basket/Acme.AppStore.Basket/Acme.AppStore.Basket.csproj", "basket/Acme.AppStore.Basket/"]
RUN dotnet restore "basket/Acme.AppStore.Basket/Acme.AppStore.Basket.csproj"
COPY . .
WORKDIR "/src/basket/Acme.AppStore.Basket"
RUN dotnet build "Acme.AppStore.Basket.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Acme.AppStore.Basket.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Acme.AppStore.Basket.dll"]