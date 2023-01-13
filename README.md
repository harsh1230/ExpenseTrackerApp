# ExpenseTrackerApp

Prerequisites:

Visual Studio (2015 or higher)
SQL Server
SQL Server Management Studio
How to run the project:

Step-1 : Ensure that the SQL Server services are running.


Step-2 : In SQL Server Management Studio, create a database 'db_expensetrackerapp' and within this database, create three tables 'Categories', 'Expenses' and 'ExpenseLimit'.

Columns in 'Categories' table - CategoryId (Primary Key), CategoryName and CategoryExpenseLimit

Columns in 'Expenses' table - ExpenseId (Primary Key), Title, Description, Amount, CategoryName and CategoryId (Foreign Key)

Columns in 'ExpenseLimit' table - ExpenseLimitId (Primary Key) and TotalExpenseLimit


Step-3 : Create a new connection in Visual Studio in the Server Explorer with the created database and add a connection string in the web.config file as follows:

     <connectionStrings>
               <add name="Category_ExpenseContext" connectionString="Data Source=LAPTOP-RJVACA2G;InitialCatalog=db_expensetrackerapp;Integrated Security=True" providerName="System.Data.SqlClient"/>
     </connectionStrings>
     
     
Step-4 : Run the application by clicking on the green play button in Visual Studio.


Outputs:

![image](https://user-images.githubusercontent.com/71223672/212386185-2640e9f0-236e-4894-9c13-fd5ee740c884.png)


![image](https://user-images.githubusercontent.com/71223672/212386266-745069ef-9202-4890-a39a-b4209286bcee.png)


![image](https://user-images.githubusercontent.com/71223672/212386338-b118ad51-125b-4ed5-a89b-a719c4372da6.png)


![image](https://user-images.githubusercontent.com/71223672/212386435-928a5e54-edcb-4125-bda9-dcfd69c56dfe.png)




