FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

RUN apt-get update && apt-get install -y --no-install-recommends unzip procps
RUN curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l ~/vsdbg 

WORKDIR /app

COPY ./bin ./

ENTRYPOINT ["dotnet", "queil.k8s.debug.poc.dll"]
