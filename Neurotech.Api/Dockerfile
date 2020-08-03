#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Neurotech.Api/Neurotech.Api.csproj", "Neurotech.Api/"]
COPY ["Neurotech.Services/Neurotech.Services.csproj", "Neurotech.Services/"]
COPY ["Neurotech.Application/Neurotech.Application.csproj", "Neurotech.Application/"]
RUN dotnet restore "Neurotech.Api/Neurotech.Api.csproj"
COPY . .
WORKDIR "/src/Neurotech.Api"
RUN dotnet build "Neurotech.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Neurotech.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Neurotech.Api.dll"]