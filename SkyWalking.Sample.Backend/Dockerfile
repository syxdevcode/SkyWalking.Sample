FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY SkyWalking.Sample.Backend.csproj SkyWalking.Sample.Backend/
RUN dotnet restore SkyWalking.Sample.Backend/SkyWalking.Sample.Backend.csproj
COPY . .
RUN dotnet build SkyWalking.Sample.Backend.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish SkyWalking.Sample.Backend.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "SkyWalking.Sample.Backend.dll"]
