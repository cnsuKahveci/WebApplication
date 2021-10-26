FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WInfrastructure/WInfrastructure.csproj", "WInfrastructure/"]
RUN dotnet restore "WInfrastructure/WInfrastructure.csproj"
COPY . .
WORKDIR "/src/WInfrastructure"
RUN dotnet build "WInfrastructure.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WInfrastructure.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WInfrastructure.dll"]
