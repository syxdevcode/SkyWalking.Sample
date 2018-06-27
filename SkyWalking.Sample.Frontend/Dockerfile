FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY SkyWalking.Sample.Frontend/SkyWalking.Sample.Frontend.csproj SkyWalking.Sample.Frontend/
RUN dotnet restore SkyWalking.Sample.Frontend/SkyWalking.Sample.Frontend.csproj
COPY . .
WORKDIR /src/SkyWalking.Sample.Frontend
RUN dotnet build SkyWalking.Sample.Frontend.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish SkyWalking.Sample.Frontend.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "SkyWalking.Sample.Frontend.dll"]
