#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["VogCodeChallenge.API.csproj", ""]
RUN dotnet restore "./VogCodeChallenge.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "VogCodeChallenge.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VogCodeChallenge.API.csproj" -c Release -o /app/publish



FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN apt-get update

RUN apt-get install wget libgdiplus -y

RUN wget -P /app https://github.com/rdvojmoc/DinkToPdf/raw/master/v0.12.4/64%20bit/libwkhtmltox.dll

RUN wget -P /app https://github.com/rdvojmoc/DinkToPdf/raw/master/v0.12.4/64%20bit/libwkhtmltox.dylib

RUN wget -P /app https://github.com/rdvojmoc/DinkToPdf/raw/master/v0.12.4/64%20bit/libwkhtmltox.so
ENV ASPNETCORE_URLS https://+:5002 
EXPOSE 5002
ENTRYPOINT ["dotnet", "VogCodeChallenge.API.dll","--environment=Development"]

