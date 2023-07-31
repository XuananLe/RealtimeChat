using RealtimeChatApp.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalRCore();
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddRouting();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    endpoints.MapHub<ChatHub>("/hub");
    // endpoints.MapHub<CustomHub>("/custom");
    // endpoints.MapHub<GroupHub>("/group");
});
app.Run();
