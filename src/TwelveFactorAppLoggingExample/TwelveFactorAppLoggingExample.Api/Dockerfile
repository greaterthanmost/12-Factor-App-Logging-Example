#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TwelveFactorAppLoggingExample.Api.csproj", ""]
RUN dotnet restore "TwelveFactorAppLoggingExample.Api.csproj"
COPY . .
RUN dotnet build "TwelveFactorAppLoggingExample.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TwelveFactorAppLoggingExample.Api.csproj" -c Release -o /app/publish

FROM base AS final
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TwelveFactorAppLoggingExample.Api.dll"]