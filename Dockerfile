# Usa la imagen oficial del SDK de .NET 8.0 para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establecer el directorio de trabajo
WORKDIR /app

# Copiar los archivos del proyecto
COPY *.csproj ./
RUN dotnet restore

# Copiar el resto del código de la aplicación
COPY . ./

# Construir la aplicación
RUN dotnet publish -c Release -o out

# Usar la imagen oficial de ASP.NET 8.0 para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# Establecer el directorio de trabajo
WORKDIR /app

# Copiar la aplicación construida desde la etapa anterior
COPY --from=build /app/out .

# Exponer el puerto 8083
EXPOSE 8083

# Establecer el punto de entrada para la aplicación
ENTRYPOINT ["dotnet", "OrdenarNumerosApp.dll"] 