WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();
app.UseRouting();

app.MapGet("/", () => "Hello!");
app.MapGet("/fail", () => {throw new Exception();});

app.Run();