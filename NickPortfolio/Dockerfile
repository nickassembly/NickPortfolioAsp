# Get base SDK Image from Microsoft
FROM mcr.Microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# copy the CSPROJ file and restore any dependencies via NUGET
COPY *.csproj ./
RUN dotnet restore

# Copy the project files and build our release
COPY . ./
RUN dotnet publish -c Release -o out

# Generate runtime image
FROM mcr.Microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "NickPortfolio.dll" ]