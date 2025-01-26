## **JaEsSoll**

[Download ![GitHub Downloads (all assets, all releases)](https://img.shields.io/github/downloads/beqare/Jes/total)](https://github.com/beqare/Jes/releases/latest/download/Jes.exe)


---

**A Custom Tool for Tweaks**

**JaEsSoll** is a program I developed in **C# .NET** to efficiently free up your PC's memory by removing unnecessary temporary files.

### **Prerequisites**

If the program does not run, ensure you have the correct version of .NET installed.  
Follow this link to download and install .NET:  
[https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download) (Currently targeting .NET 9.0)

### **Developer Commands**

Here are the key commands for running and publishing the program:

- **Run the program:**

  ```bash
  dotnet run
  ```

- **Publish the program:**

  ```bash
  dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true /p:IncludeAllContentForSelfExtract=true /p:TrimMode=Link
  ```

This will create a self-contained executable file for Windows (x64 architecture).
