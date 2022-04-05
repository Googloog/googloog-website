using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Sooziales_Netzwerk.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Sooziales_Netzwerk.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services
                .AddAuthentication(o =>
                {
                    o.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                })
                .AddCookie(o =>
                {
                    // set the path for the authentication challenge
                    o.LoginPath = "/signin";
                    // set the path for the sign out
                    o.LogoutPath = "/signout";
                })
                .AddGitHub(o =>
                {
                    o.ClientId = builder.Configuration["github:clientId"];
                    o.ClientSecret = builder.Configuration["github:clientSecret"];
                    o.CallbackPath = "/signin-github";
                    
                    // Grants access to read a user's profile data.
                    // https://docs.github.com/en/developers/apps/building-oauth-apps/scopes-for-oauth-apps
                    o.Scope.Add("read:user");

                    // Optional
                    // if you need an access token to call GitHub Apis
                    o.Events.OnCreatingTicket += context =>
                    {
                        if (context.AccessToken is { })
                        {
                            context.Identity?.AddClaim(new Claim("access_token", context.AccessToken));
                        }
                        
                        return Task.CompletedTask;
                    };
                });

            builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDbContext<Sooziales_NetzwerkDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("LinkConnection")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();