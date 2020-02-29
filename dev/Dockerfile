FROM quay.io/queil/vsdbg:v0.1.0-aspnet-3.1

WORKDIR /app
COPY ./bin ./
ENTRYPOINT ["dotnet", "queil.k8s.debug.poc.dll"]
