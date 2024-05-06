FROM  mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM  mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "BlazorAmis.csproj"
RUN rm -rf appsettings.Development.json
RUN dotnet build "BlazorAmis.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorAmis.csproj" -c Release -o /app/publish   /p:PublishSingleFile=true





FROM base AS final
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT Production
COPY --from=publish /app/publish .
RUN rm -rf *.pdb

ENTRYPOINT ["./BlazorAmis"]
