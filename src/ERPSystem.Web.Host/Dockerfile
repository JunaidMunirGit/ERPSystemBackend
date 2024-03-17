FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/ERPSystem.Web.Host/ERPSystem.Web.Host.csproj", "src/ERPSystem.Web.Host/"]
COPY ["src/ERPSystem.Web.Core/ERPSystem.Web.Core.csproj", "src/ERPSystem.Web.Core/"]
COPY ["src/ERPSystem.Application/ERPSystem.Application.csproj", "src/ERPSystem.Application/"]
COPY ["src/ERPSystem.Core/ERPSystem.Core.csproj", "src/ERPSystem.Core/"]
COPY ["src/ERPSystem.EntityFrameworkCore/ERPSystem.EntityFrameworkCore.csproj", "src/ERPSystem.EntityFrameworkCore/"]
WORKDIR "/src/src/ERPSystem.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ERPSystem.Web.Host", "src/ERPSystem.Web.Host"]
COPY ["src/ERPSystem.Web.Core", "src/ERPSystem.Web.Core"]
COPY ["src/ERPSystem.Application", "src/ERPSystem.Application"]
COPY ["src/ERPSystem.Core", "src/ERPSystem.Core"]
COPY ["src/ERPSystem.EntityFrameworkCore", "src/ERPSystem.EntityFrameworkCore"]
WORKDIR "/src/src/ERPSystem.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ERPSystem.Web.Host.dll"]
