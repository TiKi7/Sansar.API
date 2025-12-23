# Context7 Service

This repository provides a fully updated environment for developing Sansar API scripts for the Context7 service.

## Repository Structure

- `lib/`: Contains the essential Sansar API libraries (`Sansar.Script.dll` and `Sansar.Simulation.dll`).
- `docs/`: Contains official documentation and the `access.html` file, which lists the libraries and methods accessible within the Sansar restricted environment.
- `examples/`: A collection of example scripts demonstrating various Sansar API features.
- `src/`: Your source code for the Context7 service.
- `GLOSSARY.md`: A comprehensive glossary of Sansar API and Context7 terms and concepts.
- `PAGE2.md`: An introductory guide to Sansar scripting, covering file structure, namespaces, media sources, and chat commands.

## Development Environment

### Restricted Environment Note
Sansar scripts run in a restricted environment. Many standard .NET libraries (like `System.Text.Json`) are **not available**. Refer to [docs/access.html](docs/access.html) for a full list of accessible APIs.

### Prerequisites
- .NET Framework 4.7.2
- A C# IDE (e.g., Visual Studio, VS Code)

### Building
The project is configured to use C# 7.2. Opening `Context7.csproj` in your IDE will automatically reference the DLLs in the `lib/` folder.

## Getting Started
You can find a starter script in `src/StarterScript.cs`. To create a new script:
1. Add a new `.cs` file to the `src/` directory.
2. Inherit from `SceneObjectScript` or other relevant base classes from `Sansar.Simulation`.
3. Use the `[RegisterComponent]` attribute.
