// wwwroot 内の静的 HTML を配信するだけの最小構成
var app = WebApplication.CreateBuilder(args).Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
