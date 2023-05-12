using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<INFRASTRUCTURE.Data.SevenGoContext>(
    options =>
        options.UseSqlite(
            "Data Source=INFRASTRUCTURE/Data/7GO.db"
        )
);

builder.Services.AddScoped<
    CORE.Interfaces.IRepository<CORE.Entities.User>,
    INFRASTRUCTURE.Repositories.UserRepository
>();
builder.Services.AddScoped<
    CORE.Interfaces.IRepository<CORE.Entities.Challenge>,
    INFRASTRUCTURE.Repositories.ChallengeRepository
>();
builder.Services.AddScoped<
    CORE.Interfaces.IRepository<CORE.Entities.Track>,
    INFRASTRUCTURE.Repositories.TrackRepository
>();
builder.Services.AddScoped<
    CORE.Interfaces.IRepository<CORE.Entities.Reward>,
    INFRASTRUCTURE.Repositories.RewardRepository
>();


builder.Services.AddScoped<
    CORE.Interfaces.Iservice<CORE.Entities.User>,
    CORE.Services.UserService
>();
builder.Services.AddScoped<
    CORE.Interfaces.Iservice<CORE.Entities.Challenge>,
    CORE.Services.ChallengeService
>();
builder.Services.AddScoped<
    CORE.Interfaces.Iservice<CORE.Entities.Track>,
    CORE.Services.TrackService
>();
builder.Services.AddScoped<
    CORE.Interfaces.Iservice<CORE.Entities.Reward>,
    CORE.Services.RewardService
>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//  routeOptions.ConstraintMap["id"] = typeof(IdConstraint); // 
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
