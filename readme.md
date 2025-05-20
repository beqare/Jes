<div id="top" class="">

<div align="center" class="text-center">
<h1>JES</h1>
<p><em>Optimize your system, simplify your workflow effortlessly.</em></p>

<img alt="last-commit" src="https://img.shields.io/github/last-commit/beqare/Jes?style=flat&amp;logo=git&amp;logoColor=white&amp;color=0080ff" class="inline-block mx-1" style="margin: 0px 2px;">
<img alt="repo-top-language" src="https://img.shields.io/github/languages/top/beqare/Jes?style=flat&amp;color=0080ff" class="inline-block mx-1" style="margin: 0px 2px;">
<img alt="repo-language-count" src="https://img.shields.io/github/languages/count/beqare/Jes?style=flat&amp;color=0080ff" class="inline-block mx-1" style="margin: 0px 2px;">
<p><em>Built with the tools and technologies:</em></p>
<img alt="NuGet" src="https://img.shields.io/badge/NuGet-004880.svg?style=flat&amp;logo=NuGet&amp;logoColor=white" class="inline-block mx-1" style="margin: 0px 2px;">
<img alt="bat" src="https://img.shields.io/badge/bat-31369E.svg?style=flat&amp;logo=bat&amp;logoColor=white" class="inline-block mx-1" style="margin: 0px 2px;">
</div>
<br>
<hr>
<h2>Table of Contents</h2>
<ul class="list-disc pl-4 my-0">
<li class="my-0"><a href="#overview">Overview</a></li>
<li class="my-0"><a href="#getting-started">Getting Started</a>
<ul class="list-disc pl-4 my-0">
<li class="my-0"><a href="#prerequisites">Prerequisites</a></li>
<li class="my-0"><a href="#installation">Installation</a></li>
<li class="my-0"><a href="#usage">Usage</a></li>
<li class="my-0"><a href="#testing">Testing</a></li>
</ul>
</li>
</ul>
<hr>
<h2>Overview</h2>
<p>Unlock the full potential of your .NET projects with <strong>Jes</strong>, a tool that simplifies publishing and enhances system performance.</p>
<p><strong>Why Jes?</strong></p>
<p>This project streamlines the deployment and optimization of .NET applications, addressing common developer challenges. The core features include:</p>
<ul class="list-disc pl-4 my-0">
<li class="my-0">🚀 <strong>Automated Publishing:</strong> Simplifies the creation of self-contained executables for easy deployment.</li>
<li class="my-0">⚙️ <strong>Efficient Configuration Management:</strong> Ensures seamless project setup with essential settings for .NET 9.0.</li>
<li class="my-0">🧹 <strong>User-Friendly Optimization:</strong> Provides a console interface for cleaning temporary files and managing system resources.</li>
<li class="my-0">📂 <strong>Organized Development Structure:</strong> Facilitates collaboration with a well-defined Visual Studio solution.</li>
<li class="my-0">💖 <strong>Community Funding Support:</strong> Integrates funding opportunities to sustain and grow the project.</li>
</ul>
<hr>
<h2>Getting Started</h2>
<h3>Prerequisites</h3>
<p>This project requires the following dependencies:</p>
<ul class="list-disc pl-4 my-0">
<li class="my-0"><strong>Programming Language:</strong> unknown</li>
<li class="my-0"><strong>Package Manager:</strong> Nuget</li>
</ul>
<h3>Installation</h3>
<p>Build Jes from the source and intsall dependencies:</p>
<ol>
<li class="my-0">
<p><strong>Clone the repository:</strong></p>
<pre><code class="language-sh">❯ git clone https://github.com/beqare/Jes
</code></pre>
</li>
<li class="my-0">
<p><strong>Navigate to the project directory:</strong></p>
<pre><code class="language-sh">❯ cd Jes
</code></pre>
</li>
<li class="my-0">
<p><strong>Install the dependencies:</strong></p>
</li>
</ol>
<p><strong>Using <a href="https://docs.microsoft.com/en-us/dotnet/csharp/">nuget</a>:</strong></p>
<pre><code class="language-sh">❯ dotnet restore
</code></pre>
<h3>Usage</h3>
<p>Run the project with:</p>
<p><strong>Using <a href="https://docs.microsoft.com/en-us/dotnet/csharp/">nuget</a>:</strong></p>
<pre><code class="language-sh">dotnet run
</code></pre>
<h3>Testing</h3>
<p>Jes uses the {<strong>test_framework</strong>} test framework. Run the test suite with:</p>
<p><strong>Using <a href="https://docs.microsoft.com/en-us/dotnet/csharp/">nuget</a>:</strong></p>
<pre><code class="language-sh">dotnet test
</code></pre>
<hr>
<div align="left" class=""><a href="#top">⬆ Return</a></div>
<hr></div>

## **JaEsSoll**

[Download](https://github.com/beqare/Jes/releases/latest/download/Jes.exe)

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
