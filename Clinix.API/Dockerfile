# Imagem base para runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080

# Imagem para build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copia o csproj primeiro (melhora cache)
COPY ["Clinix.API/Clinix.API.csproj", "Clinix.API/"]
RUN dotnet restore "Clinix.API/Clinix.API.csproj"

# Copia todo o resto
COPY . .
WORKDIR "/src/Clinix.API"
RUN dotnet publish -c Release -o /app/publish

# Imagem final
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Clinix.API.dll"]
