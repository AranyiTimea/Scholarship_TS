Task: The following classes are given:
Class Article:
- Is the parent class for the Book and Magazine classes
- Is characterized by properties: ArticleNumber (the article number from the library), Title, PageNumber and IsAvailable
- Methods like: DisplayDetails() and Read(string title)
Class Magazine:
- With properties: MagazineNumber, Edition
- Has a constructor with the following params: article number, title, number of pages, edition and frequency
Class Book:
- With properties: PublishingHouse, Year and CoverType
- Has a constructor with the following params: article number, title, author, publishing house, number of pages, the year and the cover type.
- Has a constructor with one parameter: Book book
Class Library:
- Is characterized by properties: Name, Address, City, EmployeesNumber
- Aggregates a variable number of Article classes
- Methods: List<Articles> GetAllArticles(), void DisplaySchedule()
Add the following properties/methods, where do you think it will fit best:
- string Author
- Frequency (number of occurrences per month)
- bool HasSubscribers (string title)
- List<string> GetAllAuthors()
- void DisplayAllBooks ()
- void DisplayAllMagazine().