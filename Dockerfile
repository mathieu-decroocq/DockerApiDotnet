FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /source

# Copy csproj and restore as distinct layers
COPY **/DockerProject.API.csproj ./DockerProject.API/DockerProject.API.csproj
#RUN dotnet restore
#COPY *.csproj .

# Copy everything else and build
COPY . .
#RUN dotnet build -c Release
RUN dotnet publish -c release -o /app 

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app .
ENTRYPOINT ["dotnet", "DockerProject.API.dll"]