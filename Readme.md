## Instalation Guide ##

### Get Files ###
* Clone the repository using git.
> git clone https://github.com/kjaroska/Employees

* Open the project in your IDE (I have been using VS2017).
* Build Solution

### Ensure LocalDb connection ###
* You need an instance of localDb connected to your IDE to successfully run this project.
If you have a **running** instance you can proceed to the next point.

If not, you can create one in cmd prompt:
1) *sqllocaldb create 'dbName'*
2) *sqllocaldB run 'dbName'*


* Open IDE and add connection to your localDb in SQL Server Object Explorer, if you already have one proceed to next section.

* In Visual Studio -> Open SQL Server Object -> RMB on SQL Server and *Add SQL Server*. You can either enter connection data or browser *Local* tab and pick the one you want to use.

### Restore the Database from dbBackup.bak file ###
* You can do it in VS but I suggest using SQL Management Studio.
1) Connect to your localDb - *dbName*
2) Expand Databases tab
3) RMB on System Databases -> Restore Database
4) Under General -> Switch Source to Device and Select the backup file.
5) Under Destination set Database to *KPMG*

### Modify Web.config file in Solution ###
* Find connectionStrings and modify connectionString data source to match your localDb
> connectionString="data source=(LocalDB)\\**dbName**
