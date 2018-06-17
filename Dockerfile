FROM microsoft/dotnet:2.1.300-sdk AS build-env
WORKDIR /app

COPY ./response-api.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.1.0-runtime
WORKDIR /app

COPY --from=build-env /app/out ./
ENTRYPOINT [ "dotnet", "response-api.dll" ]