using SignalRChatServer.Hubs; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.SetIsOriginAllowed(origin => true) 
                  .AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowCredentials(); 
        });
});

var app = builder.Build();


app.UseCors("AllowAllOrigins");

app.MapHub<ChatHub>("/chat");

app.MapGet("/", () => "SignalR Server is running. Connect at /chat");

app.Run();

