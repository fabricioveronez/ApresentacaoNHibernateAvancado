FROM microsoft/dotnet:2.2-runtime-stretch-slim AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk-stretch AS build
WORKDIR /src
COPY ["NHibernateFeatured/NHibernateFeatured.csproj", "NHibernateFeatured/"]
RUN dotnet restore "NHibernateFeatured/NHibernateFeatured.csproj"
COPY . .
WORKDIR "/src/NHibernateFeatured"
RUN dotnet build "NHibernateFeatured.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "NHibernateFeatured.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "NHibernateFeatured.dll"]
