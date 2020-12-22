#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["DemoIGF/DemoIGF.csproj", "DemoIGF/"]
COPY ["DemoIGF.Impl/DemoIGF.Impl.csproj", "DemoIGF.Impl/"]
COPY ["DemoIGF.Design/DemoIGF.Design.csproj", "DemoIGF.Design/"]
RUN dotnet restore "DemoIGF/DemoIGF.csproj"
COPY . .
WORKDIR "/src/DemoIGF"
RUN dotnet build "DemoIGF.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoIGF.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoIGF.dll"]