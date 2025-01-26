## **JaEsSoll**  
**A Custom Tool for Tweaks**  

**JaEsSoll** is a program I developed in **C# .NET** to execute specific tweaks efficiently.  

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
  dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
  ```  

This will create a self-contained executable file for Windows (x64 architecture).  