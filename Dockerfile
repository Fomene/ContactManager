# Étape de build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copier les fichiers et restaurer les dépendances
COPY *.sln .
COPY *.csproj .
RUN dotnet restore

# Copier tout le reste et publier
COPY . .
RUN dotnet publish -c Release -o out

# Étape finale (exécution)
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/out .

# Commande pour lancer l'app
ENTRYPOINT ["dotnet", "ContactManager.dll"]