using BuilderPatterns;

var book = new BookBuilder()
.setTitle("clean Archictecture")
.setAuthor("rober")
.setpages(100)
.Builder();

Console.ReadKey();