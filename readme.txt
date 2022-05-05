- MOngoDB cloud: user harvybj@gmail.com

- MongoDB Variables are set on launchSettings.json 
- MongoDB Conection String is stored with ( Secret Manager )
  On Nuget Package Manager COnsole:
  -> dotnet user-secrets init -p Bookstore.WebApi
  -> dotnet user-secrets set "CONNECTION_STRING" "conectionString value" -p Bookstore.WebApi
  
  to check secrests:
  ->dotnet user-secrets list -p Bookstore.WebApi
  
Notes about Mongo DB:

1- Create the client  
  var client = new MongoClient( Connection_String );
2- Get the Datbaase  
  var database = client.GetDatabase( Database_Name );
3- Get the collection
   IMongoCollection<Book> _books = database.GetCollection<Book>( Collection_Name );
   
Query:
    - _books.Find(book => true).ToList(); // All Records
	- _books.Find(book => book.Id == id).First(); //id = parameter
   
   
  
