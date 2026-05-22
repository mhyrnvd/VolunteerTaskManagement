# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
#EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["VolunteerTaskManagement.Api/VolunteerTaskManagement.Api.csproj", "VolunteerTaskManagement.Api/"]
COPY ["Base/Base.Api/Base.Api.csproj", "Base/Base.Api/"]
COPY ["Base/Base.Application/Base.Application.csproj", "Base/Base.Application/"]
COPY ["Base/Base.Application.Contracts/Base.Application.Contracts.csproj", "Base/Base.Application.Contracts/"]
COPY ["Base/Base.Domain/Base.Domain.csproj", "Base/Base.Domain/"]
COPY ["Base/Base.Infrastructure/Base.Infrastructure.csproj", "Base/Base.Infrastructure/"]
COPY ["VolunteerTaskManagement.Application/VolunteerTaskManagement.Application.csproj", "VolunteerTaskManagement.Application/"]
COPY ["VolunteerTaskManagement.Domain/VolunteerTaskManagement.Domain.csproj", "VolunteerTaskManagement.Domain/"]
COPY ["VolunteerTaskManagement.Infrastructure/VolunteerTaskManagement.Infrastructure.csproj", "VolunteerTaskManagement.Infrastructure/"]
RUN dotnet restore "./VolunteerTaskManagement.Api/VolunteerTaskManagement.Api.csproj"
COPY . .
WORKDIR "/src/VolunteerTaskManagement.Api"
RUN dotnet build "./VolunteerTaskManagement.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./VolunteerTaskManagement.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VolunteerTaskManagement.Api.dll"]