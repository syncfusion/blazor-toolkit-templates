![Blazor_Toolkit_Banner](https://cdn.syncfusion.com/content/images/blazor-toolkit/blazor-toolkit-banner.png)

# Syncfusion Blazor Toolkit Templates

[![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![Latest Release](https://img.shields.io/github/v/release/syncfusion/blazor-toolkit-templates?label=release&logo=github)](https://github.com/syncfusion/blazor-toolkit-templates/releases)
[![Package: GitHub Packages](https://img.shields.io/badge/package-GitHub_Packages-181717?logo=github)](https://github.com/syncfusion/blazor-toolkit-templates/packages)
[![.NET 8](https://img.shields.io/badge/.NET%208%20%7C%20.NET%209%20%7C%20.NET%2010-5C2D91?logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/download/dotnet)

Templates for creating Blazor applications using the [Syncfusion Blazor Toolkit](https://www.syncfusion.com/blazor-components). Pre-configured with Syncfusion components, theming, and project structure so you can start building apps immediately.

## Prerequisites

- Either one of the SDK's [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0), [.NET 9](https://dotnet.microsoft.com/download/dotnet/9.0), [.NET 10](https://dotnet.microsoft.com/download/dotnet/10.0)
- Visual Studio 2026, JetBrains Rider, or Visual Studio Code

## Getting Started

### Installation

```bash
dotnet new install Syncfusion.Blazor.Toolkit.Templates
```

### Updating the Template

If you already installed `Syncfusion.Blazor.Toolkit.Templates` and want the latest version, update your installed template packages with:

```bash
dotnet new update
```

This checks installed template packages and installs available updates. To preview updates without changing anything:

```bash
dotnet new update --check-only
```

To verify which versions/templates are installed / available:

```bash
dotnet new list sfblazor
```

To reinstall manually (for example, to pin a specific version):

```bash
dotnet new uninstall Syncfusion.Blazor.Toolkit.Templates
dotnet new install Syncfusion.Blazor.Toolkit.Templates
```

Install a specific version:

```bash
dotnet new install Syncfusion.Blazor.Toolkit.Templates::<version>
```

> **Note:** `dotnet new update` updates all installed template packages, not just `Syncfusion.Blazor.Toolkit.Templates`.

## Templates

| Template | Description |
| --- | --- |
| `sfblazorweb` | Blazor Web App with server-side rendering and optional WebAssembly interactivity |
| `sfblazorwasm` | Blazor WebAssembly Standalone App with Progressive Web App (PWA) support |

## Usage

### Common Commands

Create a new Blazor Web App (default is `Server` interactivity):

```bash
dotnet new sfblazorweb -o MyApp
```

Create a static server-rendered app (no interactivity):

```bash
dotnet new sfblazorweb -o MyApp -int None
```

Create a Blazor Web App with per-page interactive components:

```bash
dotnet new sfblazorweb -o MyApp -int Auto
```

Create a Blazor Web App with interactive rendering enabled globally:

```bash
dotnet new sfblazorweb -o MyApp -int Auto -ai
```

Create a new standalone WebAssembly app:

```bash
dotnet new sfblazorwasm -o MyApp
cd MyApp
dotnet watch run
```

Create a standalone WebAssembly PWA:

```bash
dotnet new sfblazorwasm -o MyApp --pwa
```

Create an empty starter (omit sample pages and demo styling):

```bash
dotnet new sfblazorweb -o MyApp -e
dotnet new sfblazorwasm -o MyApp -e
```

Create an app without HTTPS (for local development only):

```bash
dotnet new sfblazorweb -o MyApp --no-https
dotnet new sfblazorwasm -o MyApp --no-https
```

Create an app using explicit `Program.Main`:

```bash
dotnet new sfblazorweb -o MyApp --use-program-main
dotnet new sfblazorwasm -o MyApp --use-program-main
```

### Options

| Option | Values / Type | Default | Description / Notes |
| --- | --- | --- | --- |
| `-int`, `--interactivity` | `Auto`, `None`, `Server`, `WebAssembly` | `Server` | Selects the interactive render mode. Use `None` for static SSR only. |
| `-ai`, `--all-interactive` | `bool` | `false` | Applies interactivity globally (root-level). Only enabled when interactivity is not `None`. |
| `-e`, `--empty` | `bool` | `false` | Omits sample pages and demo styling. |
| `--no-https` | `bool` | `false` | Disables HTTPS for local development. |
| `--exclude-launch-settings` | `bool` | `false` | Excludes `Properties/launchSettings.json` from generated output. |
| `--no-restore` | `bool` | `false` | Skips automatic `dotnet restore` after project creation. |
| `--use-program-main` | `bool` | `false` | Generates an explicit `Program` class and `Main` method instead of top-level statements. |

For the complete option list:

```bash
dotnet new sfblazorweb --help
dotnet new sfblazorwasm --help
```

### Visual Studio Templates

The templates can also be used in Visual Studio and should show up in the **Create a new project** template list. CLI examples are the best reference for advanced combinations and flags.

## Template Configuration

The Syncfusion Blazor Toolkit templates include:

- **Server-Side Rendering (SSR)**: Default web app template with optional client interactivity
- **WebAssembly Interactivity**: Full-featured WASM support with shared component code
- **Syncfusion Components**: Pre-configured with Syncfusion Blazor Toolkit components
- **Launch Settings**: Customizable Blazor launch profiles with configurable ports
- **Sample Content**: Optional demo pages and styling (use `-e` / `--empty` to skip)

## Contributing

### Installing directly from Source Code

If you want to test changes to the template source code that haven't been published yet, clone the repository and install locally:

```bash
git clone https://github.com/syncfusion/blazor-toolkit-templates.git
cd blazor-toolkit-templates
dotnet new uninstall Syncfusion.Blazor.Toolkit.Templates
dotnet new install .
```

To verify the templates are installed:

```bash
dotnet new list sfblazor
```