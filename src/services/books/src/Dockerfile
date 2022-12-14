#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["books/AcmeAppStore.Books/Acme.AppStore.Books.csproj", "books/AcmeAppStore.Books/"]
COPY ["Acme.AppStore.Common/Acme.AppStore.Common.csproj", "Acme.AppStore.Common/"]
RUN dotnet restore "books/AcmeAppStore.Books/Acme.AppStore.Books.csproj"
COPY . .
WORKDIR "/src/books/AcmeAppStore.Books"
RUN dotnet build "Acme.AppStore.Books.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Acme.AppStore.Books.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Acme.AppStore.Books.dll"]