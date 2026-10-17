# Contributing to Syncfusion Blazor Toolkit Templates

Thank you for your interest in contributing to the **Syncfusion Blazor Toolkit Templates**! We welcome contributions from the community — bug fixes, template improvements, documentation updates, and new template ideas.

If your change is anything beyond a small bug fix or docs tweak, **open an issue first** so we can agree on the shape before you invest time. Substantive changes to the public CLI surface — adding, renaming, or removing a `template.json` symbol or source-modifier — are breaking changes for users who invoke that flag from the command line, so they require sign-off from the Syncfusion Blazor Toolkit team.

This project follows the [Code of Conduct](CODE_OF_CONDUCT.md).

## 1. Reporting Issues

If you encounter a bug or have a feature request, please create an issue on GitHub. When reporting an issue, please include:

- A clear and descriptive title.
- A detailed description of the problem or suggestion.
- Steps to reproduce the issue (if applicable), including the exact `dotnet new` command and the .NET SDK version (`dotnet --list-sdks`).
- Any relevant logs or screenshots.

## 2. Fork the Repository

Navigate to [github.com/syncfusion/blazor-toolkit-templates](https://github.com/syncfusion/blazor-toolkit-templates) and click **Fork**.

## 3. Clone and Set Up

```bash
git clone https://github.com/<your-username>/blazor-toolkit-templates.git
cd blazor-toolkit-templates
```

Install the **[.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)**, then follow the **"Installing directly from Source Code"** section in the [README](README.md#installing-directly-from-source-code) to install the template pack from your local checkout. Installing the template pack **is** the build step — templates do not compile into a single assembly.

## 4. Create a Branch

Use a descriptive branch name:

```bash
git checkout -b feat/your-feature-name
# or:
git checkout -b fix/your-bug-name
# or:
git checkout -b docs/your-doc-name
```
PRs that change the public CLI surface must additionally tag the PR title with `[breaking-cli]`.

## 5. Make Your Changes

Follow the project style:

- **C#**: hard tabs, no `private` keyword (default accessibility), per the [.NET runtime coding guidelines](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md).
- **Razor**: hard tabs, `OnInitialized` lifecycle, `@code` blocks over code-behind for small components.
- **template.json**: never rename a parameter symbol in a way that breaks `dotnet new --help` output for existing users; document every new symbol in the README's *Options* table.
- **Markdown**: hard tabs for code-block indents, one sentence per line in prose, no bare-URL links.

### Test your change

For **every PR that touches a template** — even if your change is to a different flag — run every row of the matrix below and verify each generated app with `dotnet build && dotnet run`. This catches regressions in render paths you didn't directly modify.

| # | Template | Flags | Reason |
| --- | --- | --- | --- |
| 1 | `sfblazorweb` | _(default)_ | Default Server interactivity. |
| 2 | `sfblazorweb` | `-int None` | Static SSR path (no SignalR / WASM folders). |
| 3 | `sfblazorweb` | `-int Auto` | Per-page interactivity. |
| 4 | `sfblazorweb` | `-int Auto -ai` | Global interactivity. |
| 5 | `sfblazorweb` | `-int WebAssembly` | WASM client project generated. |
| 6 | `sfblazorweb` | `-e` | Empty template path. |
| 7 | `sfblazorweb` | `--no-https` | HTTPS disabled. |
| 8 | `sfblazorweb` | `--use-program-main` | Top-level statements disabled. |
| 9 | `sfblazorwasm` | _(default)_ | Standalone WASM. |
| 10 | `sfblazorwasm` | `--pwa` | PWA support. |
| 11 | `sfblazorwasm` | `-e` | Empty template. |
| 12 | `sfblazorwasm` | `--no-https` | HTTPS disabled. |

When you add a flag, add a row. When you remove a flag, keep its row until its last-supported version reaches EOL.

## 6. Commit Your Changes

Commit your changes with a clear and concise commit message:

```bash
git add .
git commit -m "Add new feature: your feature description"
```

## 7. Push to Your Fork

```bash
git push origin feat/your-feature-name
```

## 8. Open a Pull Request

1. Click **New pull request** → **compare across forks**.
2. Select your fork and branch from the **compare** dropdown.
3. Click **Create pull request**.
4. Enable **Allow edits from maintainers** so we can resolve conflicts and apply minor fixes directly.

Thank you for your contributions!