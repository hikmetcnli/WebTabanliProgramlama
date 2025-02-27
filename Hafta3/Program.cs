var builder = WebApplication.CreateBuilder(args);

/*PROJEMÝZÝ MVC PROJESÝNE ÇEVÝRÝYORUZ*/
builder.Services.AddMvc();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();

/*Home/Index default olarak çaðrýlmasýný saðlýyor.*/
app.MapControllerRoute(name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();
