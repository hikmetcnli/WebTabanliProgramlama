var builder = WebApplication.CreateBuilder(args);

/*PROJEM�Z� MVC PROJES�NE �EV�R�YORUZ*/
builder.Services.AddMvc();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

/*Home/Index default olarak �a�r�lmas�n� sa�l�yor.*/
app.MapControllerRoute(name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();
