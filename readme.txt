EntityFrameworkCore.sqlserver
EntityFrameworkCore.tools



make class  NameDbContext which inherit from DBContext

make 2 constructors default and parameterized

override OnConfiguring(DBContextOptionsBuilder){
optionsBuilder.UseSQLsERVER(@"DataSource=___ ;Initial catalogue=MyStore;");
}


ab wo classes bnanin ha jis ke against table banan ha 
e.g item.cs   add properties

ab db ko btana ha ke knsi classses ke against table bnao

public DbSet<Item> Items { get; set; } add it in Appdbcontext

now add migration

dotnet ef migrations add InitialCreate

dotnet ef database update

ye row kb update huvi aur kis ne update ki kis time ki

1 tariq ye ha ke ap manually item me 4 new columns add krdo

Inheritance use kr sakte ha yaha pr take har table me ye 4 column ajay