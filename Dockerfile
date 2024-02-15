#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["HotelApi.csproj", "."]
RUN dotnet tool install --global dotnet-ef --version 7.0.16
ENV PATH="$PATH:/root/.dotnet/tools"
RUN dotnet restore "./HotelApi.csproj"
RUN dotnet ef database update
COPY . .
WORKDIR "/src/."
RUN dotnet build "HotelApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HotelApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "HotelApi.dll"]
