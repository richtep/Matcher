#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Matcher/Server/Matcher.Server.csproj", "Matcher/Server/"]
COPY ["Matcher/Client/Matcher.Client.csproj", "Matcher/Client/"]
COPY ["Matcher/Shared/Matcher.Shared.csproj", "Matcher/Shared/"]
RUN dotnet restore "Matcher/Server/Matcher.Server.csproj"
COPY . .
WORKDIR "/src/Matcher/Server"
RUN dotnet build "Matcher.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Matcher.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Matcher.Server.dll"]