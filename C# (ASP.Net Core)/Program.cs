global using static DebugHelper;

using System.Data;
using MySql.Data.MySqlClient;


var builder = WebApplication.CreateBuilder(args);



// Read the connection string from appsettings.json
// var connectionString = builder.Configuration.GetConnectionString( "MysqlConnection" );
// Register DbContext with the connection string from appsettings.json
// builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));  // Use MySQL or PostgreSQL if applicable

// Register IDbConnection for Dapper (using MariaDB)
		builder.Services.AddScoped<IDbConnection>(sp =>
			new MySqlConnection(builder.Configuration.GetConnectionString("MysqlConnection"))
		);
		builder.Services.AddScoped<UserRepository>();





// Configure route options to use lowercase URLs
	builder.Services.Configure<RouteOptions>(options =>
	{
		options.LowercaseUrls = true; // Enforce lowercase URLs
		options.LowercaseQueryStrings = true; // Optional: Enforce lowercase query strings
	});

	// Add services to the container.
	builder.Services.AddControllersWithViews();
	builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
	name: "default",
	// pattern: "{controller=Home}/{action=Index}/{id?}")
	pattern: "{controller=Test}/{action=Index}/{id?}")
// 	.WithStaticAssets();
// app.MapControllerRoute(
	// name: "default",
	// pattern: "{controller=Home}/{action=Index}/{id?}")
	.WithStaticAssets();
app.MapRazorPages(); // Razor Pages Route

app.Run();