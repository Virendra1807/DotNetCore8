using WebAppMVC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.   Important
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Cart}/{action=Index}/{id?}");

app.MapControllers();


//app.Map("/Viren", ()=> "General Map Method");

app.MapGet("/Viren", ()=>
{
    var a = "Hello ";
    var b = "World !";
    String res = "MapGet Method " + a + b;
    return res;
});

app.MapPost("/Viren", ()=> "MapPost Method");
app.MapPut("/Viren", ()=> "MapPut Method");
app.MapDelete("/Viren", ()=> "MapDelete Method");



app.MapGet("/users", UserEndpoints.GetUsers);




app.Run();
