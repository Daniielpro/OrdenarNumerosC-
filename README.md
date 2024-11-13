##Ordenar Numeros App

## About The Project

This C# application is designed to sort a list of numbers provided by the user. It utilizes ASP.NET Core to create a web API that processes requests and returns sorted results.

## Built With

- [.NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0) - The framework used
- [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0) - The web framework for building the application

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- [.NET SDK 6.0 or later](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Git](https://git-scm.com/downloads)
- [Docker](https://www.docker.com/get-docker)

### Installation

Follow these steps to get a local copy of the project up and running:

1. **Clone the repository**
   ```bash
   git clone https://github.com/daniielpro10/ordenar-numeros.git

 
## Local Execution

To run the project locally, follow these steps:

1. Open terminal from the root folder of the project.

2. Install the dependencies if necessary with the command.
   ````bash
   dotnet restore 

2. Issue the following command
   ````bash
   dotnet run

3. Open the terminal: http://localhost:8083/

## Running Dcoker

To run the project using Docker, follow these steps:

1. Open terminal from the root folder of the project.

2. Issue the following command
   ````bash
   docker build -t username/appname .

3. Issue the following command
   ````bash
   docker run -d -p 8083:8083 username/nameapp


