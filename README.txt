0. The application was created with .NET Core 3.1, which should be contained by the project, there is no need for install.

1. Run the file InitQuery.sql on the database server with the necessary privileges (created in MSSQL2019)

2. The parameters needed for database connection should be set in the dbConnectionString.txt file.

3. Start the application with the [Download Folder]\PizzaPlace-main\PizzaPlace\bin\Debug\netcoreapp3.1\PizzaPlace.exe

4. In the first "Csatlakozás" window, please provide the place of the ConnectionString data file (2.), the program will save the location of the file for next time.

5. New customers will be saved automatically.

6. If the customer's name and address match, but we change the phone number, only the number will be overwritten.
      the customer's name or address changes, the program will create a new customer in the database
	     - in this way, a customer can have more addresses and an address can belong to more customers.
