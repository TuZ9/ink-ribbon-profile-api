FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
profile app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ink-ribbon-profile/ink-ribbon-profile.csproj", "ink-ribbon-profile/"]
RUN dotnet restore "./ink-ribbon-profile/ink-ribbon-profile.csproj"
COPY . .
WORKDIR "/src/ink-ribbon-profile"
RUN dotnet build "./ink-ribbon-profile.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ink-ribbon-profile.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ink-ribbon-profile.dll"]