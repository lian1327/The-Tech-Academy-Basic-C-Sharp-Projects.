using Microsoft.EntityFrameworkCore;
using Assign23MVCProj.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

// Set default route to Insuree/Create
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Insuree}/{action=Create}/{id?}")
    .WithStaticAssets();

app.Run();

