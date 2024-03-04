

using Practice;

//string text = "ismayil123";

//Console.WriteLine(text.CheckTextWithRegex());

//string text1 = "ismayil";

//Console.WriteLine(text1.CheckTextWithRegex());



//string text = "samir123";

//Console.WriteLine(text.CheckTextWithRegexDynamic(@"\d"));

//Console.WriteLine(text.CheckTextWithRegexDynamic(@"[a-z]"));

//Console.WriteLine(text.CheckTextWithRegexDynamic(@"[A-Z]"));



//SealedClass sealedClass = new SealedClass();

//sealedClass.Name = "Salam";

//Console.WriteLine(sealedClass.Name);





//Book book = new Book();

//string name = null;

////int? num = null;

//Console.WriteLine(book.Id);

//if (book.Id == null)
//{
//    Console.WriteLine("Book is not found...");
//}



Book book1 = new()
{
    Id = 1,
    Name = "Isgendername",
    Author = new Author() { Name = "Nizami", Id = 2 }
};

Book book2 = new()
{
    Id = 2,
    Name = "Leyli ve Mecnun",
};

Book book3 = new()
{
    Id = 3,
    Name = "Oluler",
};


Book[] books = {book1, book2, book3};



//void GetBookById(Book[] books, int? id = null)
//{
//    if (id == null)
//    {
//        Console.WriteLine("Your id is null");
//        return;
//    }
//    var result = books.FirstOrDefault(x => x.Id == id);

//    Console.WriteLine(result.Name);
//}


//GetBookById(null);

//GetBookById(books,1);


//Console.WriteLine("Book:" + book1.Name + " " + "Author:" + book1.Author.Name);

//Console.WriteLine("Book:" + book2.Name + " " + "Author:" + book2.Author?.Name);

Level level1 = Level.Low;

Level level2 = Level.Medium;

Level level3 = Level.High;

//Console.WriteLine(level1);

//Console.WriteLine((int)level1 == 1);

void GetLevel(int levelNum)
{
    switch (levelNum)
    {
        case (int) Level.Low:
            Console.WriteLine("Low");
            break;
        case (int)Level.Medium:
            Console.WriteLine("Medium");
            break;
        case (int)Level.High:
            Console.WriteLine("High");
            break;
        default:
            break;
    }
}

GetLevel(0);

void GetLevelStr(string levelNum)
{
    switch (levelNum)
    {
        case nameof(Level.Low):
            Console.WriteLine("Member");
            break;
        case nameof(Level.Medium):
            Console.WriteLine("Admin");
            break;
        case nameof(Level.High):
            Console.WriteLine("SuperAdmin");
            break;
        default:
            break;
    }
}

GetLevelStr("High");






