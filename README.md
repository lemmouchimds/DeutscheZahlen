# DeutscheZahlen

A small Windows Forms app for practicing German number words.

The app can generate a random number and show its German text, translate a typed number, and open a simple challenge window where you type the German spelling for a generated number.

## Features

- Generate a random number in the main window.
- Translate a typed integer into German number text.
- Open `Challenge` mode from the menu.
- In challenge mode, generate a number and check whether the typed German text matches the expected answer.

## Requirements

- Windows
- .NET SDK with Windows Forms support
- The project currently targets `net6.0-windows`

> Note: .NET 6 is out of support. If .NET 6 is not installed, install the .NET 6 Desktop Runtime or update the project target framework to a newer Windows desktop target such as `net8.0-windows`.

## Getting Started

Clone or open the project folder, then restore and build:

```powershell
dotnet restore
dotnet build
```

Run the app:

```powershell
dotnet run --project .\GermanNumbers.csproj
```

If the project is still targeting .NET 6 but only newer runtimes are installed, you can allow runtime roll-forward:

```powershell
$env:DOTNET_ROLL_FORWARD = "Major"
dotnet run --project .\GermanNumbers.csproj
```

## Project Structure

```text
.
|-- GermanNumbers.sln
|-- GermanNumbers.csproj
|-- Program.cs
|-- Form1.cs
|-- Form1.Designer.cs
|-- Challenge.cs
|-- Challenge.Designer.cs
|-- Consts.cs
```

- `Program.cs` starts the Windows Forms application.
- `Form1.cs` contains the main generator and translator window behavior.
- `Challenge.cs` contains the practice/challenge window behavior.
- `Consts.cs` contains the number-to-text conversion logic and the `NumberText` model.

## Usage

### Main Window

1. Click `Generate` to display a random number and its German text.
2. Type a number into the input field.
3. Click `Translate` to display the typed number as German text.

### Challenge Mode

1. Open `Challenge` from the menu.
2. Click `Generate` to get a random number.
3. Type the German number text.
4. Click `OK` or press Enter to check the answer.

## Current Behavior Notes

- The main generator uses numbers from `0` through `999`.
- Challenge mode currently uses numbers from `0` through `9`.
- Translation expects non-negative integers.
- German spelling data lives in `Consts.cs`; review the values there if linguistic accuracy is important.
- `GermanNumbers.sln` currently references a sibling `..\Test\Test.csproj`; if that folder is not present, build `GermanNumbers.csproj` directly.

## Development

Build the project:

```powershell
dotnet build .\GermanNumbers.csproj
```

Run the project:

```powershell
dotnet run --project .\GermanNumbers.csproj
```

Clean build output:

```powershell
dotnet clean
```
