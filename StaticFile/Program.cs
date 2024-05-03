WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
app.UseDeveloperExceptionPage();
}
else {
    app.UseExceptionHandler("/error");
}
app.UseStaticFiles();
app.UseRouting();

app.MapGet("/", () => "Hello!");
app.MapGet("/fail", () => {throw new Exception();});
app.MapGet("/error", () => "There was a problem processing your request");

app.Run();