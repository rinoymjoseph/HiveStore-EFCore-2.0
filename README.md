# HiveStore-EFCore-2.0

Prerequisites
---------------
1)VisualStudio 2017 Enabled with .Net Core 2.0 development
2).Net Core 2.0 SDK


Steps to Run the Application
-----------------------------
1) Open Solution in Visual Studio 2017.
2) Open HiveDataContext.cs file in HiveStore.DataAccess project and change the 
   DB connection string.
3) Open Package Manage Console and select HiveStore.DataAccess as default project.
4) Execute below command in PMC.
   Update-Database
5) Run HiveStore.TestConsole program.   
