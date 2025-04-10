# 🚀 TaskManager

<div align="center">
  <img src="https://img.shields.io/badge/.NET%20MAUI-512BD4?style=for-the-badge&logo=.net&logoColor=white" alt=".NET MAUI"/>
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#"/>
  <img src="https://img.shields.io/badge/SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white" alt="SQLite"/>
  <img src="https://img.shields.io/badge/Platforms-Android%20|%20iOS%20|%20Windows%20|%20macOS-blue?style=for-the-badge" alt="Platforms"/>
</div>

<br/>

A modern, cross-platform task management application built with .NET MAUI, designed to help users efficiently manage their tasks across multiple platforms with a beautiful and intuitive interface.

## ✨ Features

<div align="center">
  <table>
    <tr>
      <td align="center">
        <img src="https://img.icons8.com/fluency/48/000000/multiple-devices.png" width="48" height="48"/>
        <br/>
        <strong>Cross-Platform</strong>
        <br/>
        <small>Runs on Android, iOS, macOS, and Windows</small>
      </td>
      <td align="center">
        <img src="https://img.icons8.com/fluency/48/000000/task-completed.png" width="48" height="48"/>
        <br/>
        <strong>Task Management</strong>
        <br/>
        <small>Create, view, and manage tasks with ease</small>
      </td>
      <td align="center">
        <img src="https://img.icons8.com/fluency/48/000000/database.png" width="48" height="48"/>
        <br/>
        <strong>Local Storage</strong>
        <br/>
        <small>SQLite database for persistent storage</small>
      </td>
    </tr>
    <tr>
      <td align="center">
        <img src="https://img.icons8.com/fluency/48/000000/design.png" width="48" height="48"/>
        <br/>
        <strong>Modern UI</strong>
        <br/>
        <small>Clean and intuitive interface</small>
      </td>
      <td align="center">
        <img src="https://img.icons8.com/fluency/48/000000/details-pane.png" width="48" height="48"/>
        <br/>
        <strong>Task Details</strong>
        <br/>
        <small>Add detailed information to tasks</small>
      </td>
      <td align="center">
        <img src="https://img.icons8.com/fluency/48/000000/resize-horizontal.png" width="48" height="48"/>
        <br/>
        <strong>Responsive</strong>
        <br/>
        <small>Optimized for all screen sizes</small>
      </td>
    </tr>
  </table>
</div>

## 🛠️ Technologies Used

<div align="center">
  <table>
    <tr>
      <td align="center">
        <img src="https://img.icons8.com/color/48/000000/dot-net.png" width="48" height="48"/>
        <br/>
        <strong>.NET MAUI</strong>
      </td>
      <td align="center">
        <img src="https://img.icons8.com/color/48/000000/sql.png" width="48" height="48"/>
        <br/>
        <strong>SQLite</strong>
      </td>
      <td align="center">
        <img src="https://img.icons8.com/color/48/000000/xaml.png" width="48" height="48"/>
        <br/>
        <strong>XAML</strong>
      </td>
      <td align="center">
        <img src="https://img.icons8.com/color/48/000000/c-sharp-logo.png" width="48" height="48"/>
        <br/>
        <strong>C#</strong>
      </td>
    </tr>
  </table>
</div>

## 📦 Dependencies

```bash
Microsoft.Maui.Controls
Microsoft.Extensions.Logging.Debug (9.0.0)
sqlite-net-pcl (1.9.172)
SQLitePCLRaw.bundle_green (2.1.10)
System.Data.SQLite (1.0.119)
```

## 📁 Project Structure

```plaintext
TaskManager/
├── 📄 AddPage.xaml/.cs          # Page for adding new tasks
├── 📄 App.xaml/.cs              # Application entry point
├── 📄 AppShell.xaml/.cs         # Application shell and navigation
├── 📄 Constants.cs              # Application constants
├── 📄 DatePickerStringConverter.cs # Date conversion utilities
├── 📄 MainPage.xaml/.cs         # Main application page
├── 📄 MauiProgram.cs            # MAUI program configuration
├── 📁 Platforms/                # Platform-specific code
├── 📁 Properties/               # Application properties
├── 📁 Resources/                # Application resources
│   ├── 📁 AppIcon/             # Application icons
│   ├── 📁 Fonts/               # Custom fonts
│   ├── 📁 Images/              # Application images
│   ├── 📁 Raw/                 # Raw assets
│   └── 📁 Splash/              # Splash screen resources
├── 📄 TodoItem.cs              # Task item model
├── 📄 TodoItemDatabase.cs      # Database operations
├── 📄 TodoItemPage.xaml/.cs    # Task item details page
└── 📄 ViewPage.xaml/.cs        # Task viewing page
```

## 🚀 Getting Started

### Prerequisites

- .NET 9.0 SDK
- Visual Studio 2022 or Visual Studio for Mac
- Platform-specific development tools:
  - Android: Android SDK
  - iOS: Xcode (macOS only)
  - Windows: Windows 10 SDK

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/TaskManager.git
   ```

2. Open the solution in Visual Studio:
   - Open `TaskManager.sln`

3. Restore NuGet packages:
   - Right-click on the solution
   - Select "Restore NuGet Packages"

4. Build and run the application:
   - Select your target platform
   - Press F5 or click the "Start" button

## 💡 Usage

### Adding Tasks
1. Navigate to the Add page
2. Fill in task details
3. Save the task

### Viewing Tasks
1. Use the View page to see all tasks
2. Tasks are displayed in a list format

### Managing Tasks
1. View task details
2. Update task information
3. Delete tasks when completed

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- .NET MAUI team for the cross-platform framework
- SQLite team for the database solution
- Icons by [Icons8](https://icons8.com) 