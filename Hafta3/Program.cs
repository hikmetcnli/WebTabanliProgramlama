var builder = WebApplication.CreateBuilder(args);

/*PROJEMİZİ MVC PROJESİNE ÇEVİRİYORUZ*/
builder.Services.AddMvc();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

/*Home/Index default olarak çağrılmasını sağlıyor.*/
app.MapControllerRoute(name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();
