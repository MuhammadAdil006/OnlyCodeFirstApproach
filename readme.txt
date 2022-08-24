EntityFrameworkCore.sqlserver
EntityFrameworkCore.tools



make class  NameDbContext which inherit from DBContext

make 2 constructors default and parameterized

override OnConfiguring(DBContextOptionsBuilder){
optionsBuilder.UseSQLsERVER("connection String");
}


ab wo classes bnanin ha jis ke against table banan ha 