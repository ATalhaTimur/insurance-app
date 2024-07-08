# SigortaApp

SigortaApp is an application that allows users to manage insurance policies. This project is developed to manage different insurance policies, enable users to perform operations on policies, and track transaction history.

## Contents
- [Installation](#installation)
- [Usage](#usage)
- [Architecture](#architecture)
- [Layer Relationships](#layer-relationships)
- [General Design](#general-design)
- [Contributing](#contributing)


## Installation

### Requirements
- .NET SDK (Version 8.0 or higher)
- Visual Studio or another IDE

### Steps
1. Clone this repository:
    ```bash
    git clone https://github.com/username/SigortaApp.git
    ```
2. Navigate to the project directory:
    ```bash
    cd SigortaApp
    ```
3. Install the required dependencies:
    ```bash
    dotnet restore
    ```
4. Run the application:
    ```bash
    dotnet run
    ```

## Usage

### API Endpoints
- `/api/policies` - To manage insurance policies
- `/api/users` - For user operations
- `/api/transactions` - To manage transaction history

### Example API Calls
- Create a new policy:
    ```bash
    curl -X POST -H "Content-Type: application/json" -d '{"policyNumber":"12345","policyName":"Health Insurance"}' http://localhost:5000/api/policies
    ```

## Architecture

This project adopts a layered architecture. The main layers are:
- **Entities**: Contains data models.
- **Repositories**: Data access layer.
- **Services**: Business logic layer.
- **Contracts**: Contains service interfaces.

## Layer Relationships

![Dotnet1 drawio](https://github.com/ATalhaTimur/insurance-app/assets/93510585/19def7e6-cc27-4b2b-802c-ae6a865003a5)


The diagram above shows the relationships between the layers. The `Services` layer depends on the `Repositories` and `Contracts` layers. The `Entities` layer contains the data models used by other layers.

## General Design

![Dotnet2 drawio](https://github.com/ATalhaTimur/insurance-app/assets/93510585/aef1f485-97a3-42ac-9edc-8348819d11f7)

This diagram shows the general design of the project. `PolicyManager`, `PolicyUserManager`, `TransactionsManager`, and `UsersManager` classes interact with the `Repositories` and `Contracts` layers.

## Layers

![Dotnet3 drawio](https://github.com/ATalhaTimur/insurance-app/assets/93510585/0bc552cd-e0cb-41fe-8fdf-3dc9a4f8d976)


This diagram shows the relationship between each manager and its corresponding service interface.

## Contributing

If you want to contribute, please open an issue first. For major changes, please open an issue first to discuss what you would like to change.

1. Fork this repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request


