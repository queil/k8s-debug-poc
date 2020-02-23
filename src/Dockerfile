FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build

WORKDIR /build

COPY *.fsproj ./
RUN dotnet restore

COPY ./ ./
RUN dotnet publish -c Release --no-restore -o ./pkg

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app
COPY --from=build /build/pkg ./

ENTRYPOINT ["dotnet", "Queil.Example.App.dll"]
