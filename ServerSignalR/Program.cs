using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();



app.MapGet("/", () => "Hello World!");
app.MapHub<ServerSignalR.SimpleChatHub>("/chat");

app.Run();
