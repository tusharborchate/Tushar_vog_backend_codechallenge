#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /app 
#
EXPOSE 80
EXPOSE 443

# copy csproj and restore as distinct layers
COPY *.sln .
COPY ["VogCodeChallenge.API/VogCodeChallenge.API.csproj", "./VogCodeChallenge.API/"]
COPY ["VogCodeChallenge.Models/VogCodeChallenge.Entities.csproj", "./VogCodeChallenge.Models/"]
COPY ["VogCodeChallenge.Business/VogCodeChallenge.Business.csproj", "./VogCodeChallenge.Business/"]

#
RUN dotnet restore 
#
# copy everything else and build app

COPY ["VogCodeChallenge.API/.", "./VogCodeChallenge.API/"]
COPY ["VogCodeChallenge.Models/.", "./VogCodeChallenge.Models/"]
COPY ["VogCodeChallenge.Business/.", "./VogCodeChallenge.Business/"]
#
WORKDIR /app/VogCodeChallenge.API
RUN dotnet publish -c Release -o out 
#
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app 
#
COPY --from=build /app/VogCodeChallenge.API/out ./
ENTRYPOINT ["dotnet", "VogCodeChallenge.API.dll"]

