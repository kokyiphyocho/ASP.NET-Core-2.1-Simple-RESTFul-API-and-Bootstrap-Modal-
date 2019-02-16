using Microsoft.EntityFrameworkCore.Migrations;

namespace BookRESTFulService.Data.Migrations.Book
{
    public partial class InitialConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Isbn = table.Column<string>(maxLength: 30, nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: true),
                    Category = table.Column<string>(maxLength: 50, nullable: true),
                    Edition = table.Column<string>(nullable: true),
                    PublishYear = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Isbn);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Isbn", "Category", "Edition", "Price", "PublishYear", "Quantity", "Title" },
                values: new object[,]
                {
                    { "978-1491987650", "Programming", "1st Edition", 65m, 2017, 5, "C# 7.0 in a Nutshell : The Definitive Reference" },
                    { "978-1943872077", "Programming", "5th Edition", 70m, 2017, 4, "Murach's Java Programming" },
                    { "978-0134685991", "Programming", "3rd Edition", 62m, 2018, 0, "Effective Java" },
                    { "978-1260440218", "Programming", "8th Edition", 45m, 2018, 2, "Java: A Beginner's Guide" },
                    { "978-0596009205", "Programming", "2nd Edition", 48m, 2003, 2, "Head First Java" },
                    { "978-0134802213", "Programming", "7th Edition", 40m, 2015, 4, "Starting Out with Java" },
                    { "978-1259589331", "Programming", "10th Edition", 33m, 2017, 0, "Java: The Complete Reference" },
                    { "978-1492037255", "Programming", "7th Edition", 52m, 2018, 1, "Java in a Nutshell" },
                    { "978-0135166307", "Programming", "11th Edition", 38m, 2018, 7, "Core Java Volume I" },
                    { "978-0321349606", "Programming", "1st Edition", 60m, 2015, 5, "Java Concurrency in Practice" },
                    { "978-1119247791", "Programming", "5th Edition", 66m, 2017, 1, "Java All-in-One For Dummies" },
                    { "978-0134777566", "Programming", "4th Edition", 72m, 2017, 0, "Java 9 for Programmers" },
                    { "978-0672324536", "Programming", "2nd Edition", 38m, 2018, 3, "Data Structures and Algorithms in Java" },
                    { "978-1119235538", "Programming", "5th Edition", 48m, 2017, 4, "Beginning Programming with Java For Dummies" },
                    { "978-1430260318", "Programming", "4th Edition", 52m, 2013, 5, "PHP Objects, Patterns, and Practice" },
                    { "978-1491929568", "Programming", "1st Edition", 55m, 2016, 5, "Think Java: How to Think Like a Computer Scientist" },
                    { "978-1119056447", "Programming", "6th Edition", 68m, 2016, 0, "Big Java, Binder Ready Version: Early Objects" },
                    { "978-1890774783", "Programming", "3rd Edition", 43m, 2014, 0, "Murach's Java Servlets and JSP" },
                    { "978-0134177298", "Programming", "10th Edition", 38m, 2017, 4, "Core Java, Volume II" },
                    { "978-1449358457", "Programming", "1st Edition", 39m, 2014, 2, "Java Performance: The Definitive Guide" },
                    { "978-1484231494", "Programming", "7th Edition", 52m, 2017, 4, "Pro ASP.NET Core MVC 2" },
                    { "978-1890774950", "Programming", "6th Edition", 56m, 2016, 0, "Murach's ASP.NET 4.6 Web Programming with C# 2015" },
                    { "978-1119181316", "Programming", "1st Edition", 48m, 2018, 1, "Front-end Development with ASP.NET Core, Angular, and Bootstrap" },
                    { "978-1509304417", "Programming", "1st Edition", 35m, 2018, 7, "Programming ASP.NET Core" },
                    { "978-1509304066", "Programming", "1st Edition", 55m, 2017, 5, "ASP.NET Core Application Development" },
                    { "978-1118794753", "Programming", "1st Edition", 72m, 2014, 1, "Professional ASP.NET MVC 5" },
                    { "978-1617294617", "Programming", "1st Edition", 65m, 2018, 0, "ASP.NET Core in Action" },
                    { "978-1788293600", "Programming", "1st Edition", 33m, 2018, 3, "ASP.NET Core 2 and Angular 5" },
                    { "978-1119410263", "Programming", "1st Edition", 49m, 2018, 4, "Professional ASP.NET: Core 2.0" },
                    { "978-0134462028", "Programming", "9th Edition", 53m, 2017, 8, "Java Software Solutions" },
                    { "978-1430265290", "Programming", "5th Edition", 52m, 2016, 5, "Pro ASP.NET MVC 5" },
                    { "978-0994346988", "Programming", "6th Edition", 53m, 2017, 9, "PHP & MySQL: Novice to Ninja" },
                    { "978-0596006303", "Programming", "1st Edition", 38m, 2009, 6, "Head First PHP & MySQL" },
                    { "978-1119449270", "Programming", "1st Edition", 35m, 2018, 8, "Professional C# 7 and .NET Core 2.0" },
                    { "978-1484230176", "Programming", "1st Edition", 40m, 2017, 5, "Pro C# 7: With .NET and .NET Core" },
                    { "978-1509307760", "Programming", "9th Edition", 31m, 2018, 7, "Microsoft Visual C# Step by Step " },
                    { "978-1617291340", "Programming", "3rd Edition", 75m, 2014, 3, "C# in Depth" },
                    { "978-1518877551", "Programming", "2nd Edition", 59m, 2015, 6, "C# For Beginners : The tactical guidebook " },
                    { "978-1973727767", "Programming", "4th Edition", 55m, 2015, 8, "C# for Tweens and Teens" },
                    { "978-1890774943", "Programming", "6th Edition", 42m, 2016, 9, "Murach's C# 2015 " },
                    { "978-1617294532", "Programming", "4th Edition", 72m, 2018, 5, "C# in Depth" },
                    { "978-1119428114", "Programming", "1st Edition", 60m, 2018, 4, "C# 7.0 All-in-One For Dummies" },
                    { "978-1449343507", "Programming", "3rd Edition", 63m, 2016, 0, "Head First C#" },
                    { "978-0735667457", "Programming", "4th Edition", 39m, 2012, 2, "CLR via C# (Developer Reference)" },
                    { "978-1119458685", "Programming", "1st Edition", 51m, 2018, 2, "Beginning C# 7 Programming with Visual Studio 2017" },
                    { "978-1484213339", "Programming", "7th Edition", 55m, 2015, 4, "C# 6.0 and the .NET 4.6 Framework" },
                    { "978-0470413968", "Programming", "1st Edition", 44m, 2010, 8, "Beginning PHP 5.3" },
                    { "978-1509303588", "Programming", "6th Edition", 58m, 2018, 0, "Essential C# 7.0" },
                    { "978-0134301846", "Programming", "5th Edition", 43m, 2018, 7, "PHP and MySQL for Dynamic Web Sites" },
                    { "978-1119149224", "Programming", "1st Edition", 58m, 2019, 5, "PHP & MySQL: Server-side Web Development" },
                    { "978-1943872381", "Programming", "3rd Edition", 60m, 2017, 1, "Murach's PHP and MySQL" },
                    { "978-1491905012", "Programming", "1st Edition", 65m, 2015, 0, "Modern PHP: New Features and Good Practices" },
                    { "978-0134291253", "Programming", "5th Edition", 35m, 2016, 3, "PHP for the Web: Visual QuickStart Guide" },
                    { "978-1491918661", "Programming", "4th Edition", 42m, 2015, 4, "Learning PHP, MySQL & JavaScript" },
                    { "978-1449363758", "Programming", "3rd Edition", 63m, 2014, 5, "PHP Cookbook" },
                    { "978-1119468387", "Programming", "1st Edition", 55m, 2018, 8, "PHP, MySQL, & JavaScript All-in-One" },
                    { "978-0321833891", "Programming", "5th Edition", 58m, 2017, 0, "PHP and MySQL Web Development" },
                    { "978-1484206362", "Programming", "3rd Edition", 43m, 2015, 0, "PHP Solutions : Dynamic Web Design Made Easy " },
                    { "978-0321832184", "Programming", "3rd Edition", 39m, 2013, 4, "PHP Advanced and Object-Oriented Programming" },
                    { "978-1449392772", "Programming", "3rd Edition", 66m, 2013, 7, "Programming PHP: Creating Dynamic Web Pages" },
                    { "978-1430260431", "Programming", "5th Edition", 72m, 2018, 9, "Beginning PHP and MySQL" },
                    { "978-1491978917", "Programming", "5th Edition", 47m, 2018, 1, "Learning PHP, MySQL & JavaScript" },
                    { "978-1491961735", "Programming", "1st Edition", 54m, 2017, 8, "Building Microservices with ASP.NET Core" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
