#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["games/AcmeAppStore.Games/Acme.AppStore.Games.csproj", "games/AcmeAppStore.Games/"]
COPY ["Acme.AppStore.Common/Acme.AppStore.Common.csproj", "Acme.AppStore.Common/"]
RUN dotnet restore "games/AcmeAppStore.Games/Acme.AppStore.Games.csproj"
COPY . .
WORKDIR "/src/games/AcmeAppStore.Games"
RUN dotnet build "Acme.AppStore.Games.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Acme.AppStore.Games.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Acme.AppStore.Games.dll"]