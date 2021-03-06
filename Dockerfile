FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /source

# Copy csproj and restore as distinct layers
COPY **/DockerProject.API.csproj ./DockerProject.API/DockerProject.API.csproj


# Copy everything else and build
COPY . .

RUN dotnet publish -c release -o /app 

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app .
ENTRYPOINT ["dotnet", "DockerProject.API.dll", "--build-arg DATABASE_HOST=$DATABASE_HOST", "--build-arg DATABASE_PASSWORD=$DATABASE_PASSWORD"]