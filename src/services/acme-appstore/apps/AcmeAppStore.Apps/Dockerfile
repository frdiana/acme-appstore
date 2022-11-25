#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["apps/AcmeAppStore.Apps/AcmeAppStore.Apps.csproj", "apps/AcmeAppStore.Apps/"]
RUN dotnet restore "apps/AcmeAppStore.Apps/AcmeAppStore.Apps.csproj"
COPY . .
WORKDIR "/src/apps/AcmeAppStore.Apps"
RUN dotnet build "AcmeAppStore.Apps.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AcmeAppStore.Apps.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AcmeAppStore.Apps.dll"]