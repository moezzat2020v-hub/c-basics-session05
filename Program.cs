

// Ass - 05

// Q1 - Q2 - Q3

using Ass___05;

Book book = new Book();

book.Title = "C# Programming";

Console.WriteLine(book.password);
Console.WriteLine(book.copiesInStock);
Console.WriteLine(book.Title);


// book.password doesnt work because the password field is private .
// book.copiesInStock works because the copiesInStock field is internal

// Q4

Genre genre01 = Genre.Fiction;
Genre genre02 = Genre.NonFiction;
Genre genre03 = Genre.Science;

Console.WriteLine(genre01);
Console.WriteLine(genre02);
Console.WriteLine(genre03);

// Q5

Console.WriteLine((int)genre01);
Console.WriteLine((int)genre02);
Console.WriteLine((int)genre03);

// Q6

int genreNumber = 1;

Genre genreFromNumber = (Genre)genreNumber;
Console.WriteLine(genreFromNumber);

// Q7

Genre genre = Genre.Fiction;
string genreText = genre.ToString();
Console.WriteLine(genreText);

// Q8


// Q9

