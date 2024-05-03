var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("utctime", () => Results.Ok(DateTime.UtcNow));
app.MapGet("time", () => Results.Ok(DateTime.Now));

app.MapGet("hello", () => Results.Ok("Hello World!"));


app.Run();
