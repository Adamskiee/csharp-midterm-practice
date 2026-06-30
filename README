# PracticeMidterm

A Windows Forms (.NET Framework) application developed using C#.

## Prerequisites

Before running the project, install:

- Visual Studio 2019 or Visual Studio 2022
- **.NET Desktop Development** workload
- .NET Framework Developer Pack (matching the project's target framework)
- Internet connection (for restoring NuGet packages)

---

## Clone the Repository

```bash
git clone https://github.com/<your-username>/PracticeMidterm.git
cd PracticeMidterm
```

Replace `<your-username>` with the repository owner's GitHub username.

---

## Open the Project

Open the solution file:

```
PracticeMidterm.sln
```

using Visual Studio.

---

## Restore NuGet Packages

The project uses **Newtonsoft.Json**.

Visual Studio usually restores NuGet packages automatically when opening the solution.

If it does not:

1. Right-click the solution.
2. Select **Restore NuGet Packages**.

Or use the Package Manager Console:

```powershell
Update-Package -Reinstall
```

If Newtonsoft.Json is still missing:

```powershell
Install-Package Newtonsoft.Json
```

---

## Build the Project

In Visual Studio:

**Build → Build Solution**

or press:

```
Ctrl + Shift + B
```

---

## Run the Application

Press:

```
F5
```

to run with debugging.

or

```
Ctrl + F5
```

to run without debugging.

---

## Project Structure

```
PracticeMidterm/
│
├── .gitignore
├── README.md
├── PracticeMidterm.sln
│
└── PracticeMidterm/
    ├── Program.cs
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Form1.resx
    ├── App.config
    ├── packages.config
    ├── PracticeMidterm.csproj
    └── Properties/
```

---

## NuGet Packages

This project uses:

- Newtonsoft.Json

If package restoration fails, install it manually:

```powershell
Install-Package Newtonsoft.Json
```

---

## Git Ignore

The following folders/files are intentionally excluded from source control:

```
.vs/
bin/
obj/
*.user
*.suo
```

---

## Troubleshooting

### Missing NuGet Packages

Restore packages by right-clicking the solution and selecting **Restore NuGet Packages**, or run:

```powershell
Update-Package -Reinstall
```

### Build Errors

- Verify that the correct .NET Framework Developer Pack is installed.
- Clean the solution and rebuild:
  - **Build → Clean Solution**
  - **Build → Rebuild Solution**

### Visual Studio Cache Issues

Close Visual Studio and delete:

```
.vs/
bin/
obj/
```

These folders will be regenerated automatically the next time the project is built.

---

## License

This project is intended for educational purposes.