# LoanWebApp

## Introduction

TODO

![ER Diagram](assets/LoanWebAppERDiagram.png)

## Building and running the project

To build the project, .NET Core 3.1 compatible SDK is required. More information here: <https://dotnet.microsoft.com/download>

Node.js is also required (either the LTS or current version). You can download it here: <https://nodejs.org/>

To run the source code, run `dotnet run` from the project root folder. It might take a while
the first time you run it, because it automatically runs `npm install` in the background to
build the front-end Angular application (if you wish, you can run it manually beforehand
from the ClientApp folder). If the application builds and runs successfully,
you should be able to access the app from the browser at <https://localhost:5001/>

To stop the application, input Ctrl+C in the console where you ran the project from.
