# MkLink GUI

<!-- ![Project Logo](./path/to/logo.png)  Optional: Add a logo or image -->

A simple Windows Forms application that provides a graphical user interface (GUI) for the `mklink` command, allowing users to create symbolic links and junction points easily.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Binaries](#binaries)


## Features

- Create symbolic links and junction points between folders.
- Input validation for source and destination paths.
- Preview the command before execution.
- Optional checkbox to rename the target folder based on the source folder name.
- Displays command output and error messages in the GUI.

## Installation

### Prerequisites

- [.NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0) or higher
- Visual Studio 2022 or newer (optional, for development)

### Steps

1. Clone the repository:
```bash
   git clone https://github.com/yourusername/MkLinkGUI.git
```
2. Navigate to the project directory:
```bash
cd MkLinkGUI
```
3. Install Git LFS (if necessary):
```bash
git lfs install
```
4. Open the project in Visual Studio and build the solution.
5. Run the application.

## Usage

1. Launch the application.
2. Enter the source and destination paths using the provided input fields.
3. (Optional) Check the "Rename Target" checkbox if you want the target folder to be named after the source folder.
4. Click the Preview button to view the generated command.
5. Click the Execute button to create the link.
6. View the command output in the output text box.

## Binaries

Binaries are provided in the release section of the repository.