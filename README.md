## C# .NET 7.0 (VSCode) - Exception handling

Write a program to read data from a hotel reservation(room number, check-in and check-out dates) and display reservation data, including its duration in days. Then, read new check-in and check-out dates and display again reservation updated data. The program must not accept invalid data for the reservation, as the following rules:


* Reservation updates only can occur at future dates.
* Check-out date must be higher than check-in date.

### Remark:
At this activity, there will be 3 possible solutions to handle exceptions:
* Very bad solution: validation logic in the Main class.
* Bad solution: returning a string from a method.
* Very good solution: creating a custom exception.
