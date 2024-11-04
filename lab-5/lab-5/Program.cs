using System;
using System.Runtime.InteropServices;


public class Matrix2
{
    protected internal int[,] _matrix;
    private int rows;
    private int columns;

    public Matrix2(int rows, int columns, int[] initialValues)
    {
        this.rows = rows;
        this.columns = columns;
        _matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int index = i * columns + j;
                _matrix[i, j] = (index < initialValues.Length) ? initialValues[index] : 0;
            }
        }
    }

    public (int Rows, int Columns) GetSize()
    {
        return (rows, columns);
    }

    public static Matrix2 Add(Matrix2 m1, Matrix2 m2)
    {
        int maxRows = Math.Max(m1.rows, m2.rows);
        int maxCols = Math.Max(m1.columns, m2.columns);
        int[] resultValues = new int[maxRows * maxCols];

        for (int i = 0; i < maxRows; i++)
        {
            for (int j = 0; j < maxCols; j++)
            {
                int m1Value = (i < m1.rows && j < m1.columns) ? m1._matrix[i, j] : 0;
                int m2Value = (i < m2.rows && j < m2.columns) ? m2._matrix[i, j] : 0;
                resultValues[i * maxCols + j] = m1Value + m2Value;
            }
        }

        return new Matrix2(maxRows, maxCols, resultValues);
    }

    public static Matrix2 Subtract(Matrix2 m1, Matrix2 m2)
    {
        int maxRows = Math.Max(m1.rows, m2.rows);
        int maxCols = Math.Max(m1.columns, m2.columns);
        int[] resultValues = new int[maxRows * maxCols];

        for (int i = 0; i < maxRows; i++)
        {
            for (int j = 0; j < maxCols; j++)
            {
                int m1Value = (i < m1.rows && j < m1.columns) ? m1._matrix[i, j] : 0;
                int m2Value = (i < m2.rows && j < m2.columns) ? m2._matrix[i, j] : 0;
                resultValues[i * maxCols + j] = m1Value - m2Value;
            }
        }

        return new Matrix2(maxRows, maxCols, resultValues);
    }

    public void PrintMatrix()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(_matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

public class Matrix
{
    private int[] matrix;
    private int c; // liczba kolumn
    private int l; // liczba wierszy

    public Matrix(int rows, int columns, int[] initialValues)
    {
        l = rows;
        c = columns;
        matrix = new int[l * c];

        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = (i < initialValues.Length) ? initialValues[i] : 0;
        }
    }

    public void AddElem(int row, int column, int value)
    {
        if (row >= 0 && row < l && column >= 0 && column < c)
        {
            matrix[row * c + column] = value;
        }
        else
        {
            Console.WriteLine("Poza zakresem macierzy.");
        }
    }

    public (int rows, int columns) GetSize()
    {
        return (l, c);
    }

    public int[] GetMatrixValues()
    {
        return (int[])matrix.Clone();
    }

    public static Matrix AddMatrix(Matrix m1, Matrix m2)
    {
        int maxRows = Math.Max(m1.l, m2.l);
        int maxCols = Math.Max(m1.c, m2.c);
        int[] resultValues = new int[maxRows * maxCols];

        for (int i = 0; i < maxRows; i++)
        {
            for (int j = 0; j < maxCols; j++)
            {
                int m1Value = (i < m1.l && j < m1.c) ? m1.matrix[i * m1.c + j] : 0;
                int m2Value = (i < m2.l && j < m2.c) ? m2.matrix[i * m2.c + j] : 0;
                resultValues[i * maxCols + j] = m1Value + m2Value;
            }
        }

        return new Matrix(maxRows, maxCols, resultValues);
    }

    public void PrintMatrix()
    {
        for (int i = 0; i < l; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(matrix[i * c + j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

class Stack
{
    private List<int> items;

    public Stack()
    {
        items = new List<int>();
    }

    public void AddItem(int item)
    {
        items.Add(item);
    }

    public void DeleteItem()
    {
        if (items.Count > 0)
        {
            items.RemoveAt(items.Count - 1);
        }
    }

    public int ShowTheNumberOfItems()
    {
        return items.Count;
    }

    public int ShowMinItem()
    {
        if (items.Count == 0) throw new InvalidOperationException("Stack is empty.");
        return items.Min();
    }

    public int ShowMaxItem()
    {
        if (items.Count == 0) throw new InvalidOperationException("Stack is empty.");
        return items.Max();
    }

    public int FindAnItem(int item)
    {
        int index = items.LastIndexOf(item);
        return index == -1 ? -1 : items.Count - index;
    }

    public void PrintAllItems()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Stack is empty.");
        }
        else
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
            }
        }
    }

    public void ClearAll()
    {
        items.Clear();
    }
}


public class Book
{
    public string Title { get; }
    public string Author { get; }
    public double Price { get; }
    public string ISBN { get; }
    public DateTime Date { get; }

    public Book(string title, string author, double price, string isbn, DateTime date)
    {
        Title = title;
        Author = author;
        Price = price;
        ISBN = isbn;
        Date = date;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Price: {Price}, ISBN: {ISBN}, Date: {Date.ToShortDateString()}";
    }
}

public sealed class BookLibrary
{
    private static readonly BookLibrary _instance = new BookLibrary();
    private readonly Dictionary<string, Book> _books = new Dictionary<string, Book>();

    private BookLibrary() { }

    public static BookLibrary Instance => _instance;

    public bool AddBook(Book book)
    {
        if (!_books.ContainsKey(book.ISBN))
        {
            _books[book.ISBN] = book;
            return true;
        }
        return false; // Book with this ISBN already exists
    }

    public bool RemoveBook(string isbn)
    {
        return _books.Remove(isbn);
    }

    public Book FindByISBN(string isbn)
    {
        return _books.TryGetValue(isbn, out var book) ? book : null;
    }

    public IEnumerable<Book> FindByAuthor(string author)
    {
        return _books.Values.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase));
    }

    public IEnumerable<Book> FindByTitle(string title)
    {
        return _books.Values.Where(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public IEnumerable<Book> FindByPrice(double price)
    {
        return _books.Values.Where(b => b.Price == price);
    }

    public bool ContainsBook(string isbn)
    {
        return _books.ContainsKey(isbn);
    }

    public void ListAllBooks()
    {
        foreach (var book in _books.Values)
        {
            Console.WriteLine(book);
        }
    }
}

class Program
{
    [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int puts(string str);

    [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int _flushall();

    static void Main()
    {
        // CW 1
        // Console.Write("Podaj rozmiar trójkąta: ");
        // int n = int.Parse(Console.ReadLine());

        // TrianglePattern1(n);
        // TrianglePattern2(n);

        // CW 2
        // Int32 i = 23;
        // object o = i;
        // i = 123;
        // long j = (long)o;
        // Po dokonaniu konwersji
        // Unable to cast object of type 'System.Int32' to type 'System.Int64'.
        // Console.WriteLine(i + ", " + (Int32) o);
        // wypisane liczby to 123, 23 poniewaz tak interpretuje je c#

        // CW 3
        // int? nullableValue;

        // Próba wypisania wartości nullable spowoduje błąd kompilacji
        // Console.WriteLine(nullableValue); // To nie zadziała, ponieważ zmienna jest niezainicjowana.

        // Użycie GetValueOrDefault oraz HasValue, aby bezpiecznie wypisać wartość
        // Console.WriteLine("Czy zmienna posiada wartość? " + nullableValue.HasValue); // False
        // Console.WriteLine("Wartość lub domyślna (np. 100): " + nullableValue.GetValueOrDefault(100)); // 100

        // Przypisanie wartości i ponowne wypisanie
        // nullableValue = 42;
        // Console.WriteLine("Czy zmienna posiada wartość? " + nullableValue.HasValue); // True
        // Console.WriteLine("Aktualna wartość zmiennej: " + nullableValue); // 42

        // CW 4
        // int? i = null;
        // int j = 10;
        // Console.WriteLine(i < j); // Fasle
        // Console.WriteLine(i > j); // False
        // Console.WriteLine(i == j); // False

        // CW 5
        
        // string message = "Testowa wiadomość";
        // puts(message);
        // _flushall();

        // CW 6
        // Klasa zaimplementowana powyzej klasy 'Program'
        // Stack stack1 = new Stack();
        // Stack stack2 = new Stack();
        // Random rand = new Random();

        // for (int i = 0; i < 100; i++)
        // {
        //     stack1.AddItem(rand.Next(1, 200));
        //     stack2.AddItem(rand.Next(1, 200));
        // }

        // Stack stack3 = new Stack();

        // HashSet<int> uniqueEvenItems = new HashSet<int>();

        // AddEvenItemsToSet(stack1, uniqueEvenItems);
        // AddEvenItemsToSet(stack2, uniqueEvenItems);

        // foreach (int item in uniqueEvenItems)
        // {
        //     stack3.AddItem(item);
        // }

        // Console.WriteLine("Wszystkie elementy stosu 3:");
        // stack3.PrintAllItems();

        // CW 8

        // int[] initialValues1 = { 1, 2, 3, 4, 5, 6 };
        // int[] initialValues2 = { 7, 8, 9, 10, 11, 12 };

        // Matrix2 matrix1 = new Matrix2(2, 3, initialValues1);
        // Matrix2 matrix2 = new Matrix2(2, 3, initialValues2);

        // Console.WriteLine("Macierz 1:");
        // matrix1.PrintMatrix();

        // Console.WriteLine("Macierz 2:");
        // matrix2.PrintMatrix();

        // Matrix2 sumMatrix = Matrix2.Add(matrix1, matrix2);
        // Console.WriteLine("Suma macierzy:");
        // sumMatrix.PrintMatrix();

        // Matrix2 diffMatrix = Matrix2.Subtract(matrix1, matrix2);
        // Console.WriteLine("Różnica macierzy:");
        // diffMatrix.PrintMatrix();

        // CW 9

        BookLibrary library = BookLibrary.Instance;

        var book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.99, "1234567890", new DateTime(1925, 4, 10));
        var book2 = new Book("To Kill a Mockingbird", "Harper Lee", 8.99, "0987654321", new DateTime(1960, 7, 11));
        var book3 = new Book("1984", "George Orwell", 7.99, "1122334455", new DateTime(1949, 6, 8));

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        Console.WriteLine("All books in library:");
        library.ListAllBooks();

        Console.WriteLine("\nSearching by author 'George Orwell':");
        foreach (var book in library.FindByAuthor("George Orwell"))
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nChecking if book with ISBN '1234567890' exists:");
        Console.WriteLine(library.ContainsBook("1234567890") ? "Book exists" : "Book does not exist");

        Console.WriteLine("\nRemoving book with ISBN '1234567890'");
        library.RemoveBook("1234567890");

        Console.WriteLine("\nAll books in library after removal:");
        library.ListAllBooks();
    }

    static void TrianglePattern1(int num)
    {
        Console.WriteLine("\nPierwszy wzór trójkątny:");
        
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }

    static void TrianglePattern2(int num)
    {
        Console.WriteLine("\nDrugi wzór trójkątny:");
        
        int row = 1;

        while (row <= num)
        {
            int col = 1;
            while (col <= row)
            {
                Console.Write(row);
                col++;
            }
            Console.WriteLine();
            row++;
        }
        
        Console.WriteLine("\nDrugi wzór trójkątny (wersja z do-while):");
        
        row = 1;
        do
        {
            int col = 1;
            do
            {
                Console.Write(row);
                col++;
            } while (col <= row);
            Console.WriteLine();
            row++;
        } while (row <= num);
    }

    static void AddEvenItemsToSet(Stack stack, HashSet<int> uniqueEvenItems)
    {
        Stack tempStack = new Stack();

        while (stack.ShowTheNumberOfItems() > 0)
        {
            int item = stack.ShowMaxItem();
            stack.DeleteItem();

            if (item % 2 == 0)
            {
                uniqueEvenItems.Add(item);
            }
            tempStack.AddItem(item);
        }

        while (tempStack.ShowTheNumberOfItems() > 0)
        {
            stack.AddItem(tempStack.ShowMaxItem());
            tempStack.DeleteItem();
        }
    }
}
