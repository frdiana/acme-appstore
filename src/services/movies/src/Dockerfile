#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["movies/AcmeAppStore.Movies/Acme.AppStore.Movies.csproj", "movies/AcmeAppStore.Movies/"]
COPY ["Acme.AppStore.Common/Acme.AppStore.Common.csproj", "Acme.AppStore.Common/"]
RUN dotnet restore "movies/AcmeAppStore.Movies/Acme.AppStore.Movies.csproj"
COPY . .
WORKDIR "/src/movies/AcmeAppStore.Movies"
RUN dotnet build "Acme.AppStore.Movies.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Acme.AppStore.Movies.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Acme.AppStore.Movies.dll"]