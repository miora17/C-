var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// ---------- Home page ----------
app.MapGet("/", () => Results.Content("""
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Home | My C# Site</title>
  <style>
    * { margin: 0; padding: 0; box-sizing: border-box; }
    body { font-family: system-ui, -apple-system, sans-serif; background: #0f172a; color: #e2e8f0; min-height: 100vh; }
    header { display: flex; justify-content: space-between; align-items: center; padding: 1rem 2rem; background: #1e293b; }
    .logo { font-weight: 700; color: #38bdf8; font-size: 1.2rem; }
    nav a { color: #e2e8f0; text-decoration: none; margin-left: 1.5rem; }
    nav a:hover { color: #38bdf8; }
    main { max-width: 800px; margin: 4rem auto; padding: 0 1rem; text-align: center; }
    h1 { font-size: 2.5rem; margin-bottom: 1rem; }
    h1 span { color: #38bdf8; }
    p.lead { color: #94a3b8; font-size: 1.1rem; line-height: 1.6; margin-bottom: 2rem; }
    .btn { display: inline-block; padding: .75rem 1.5rem; border-radius: 8px; background: #38bdf8; color: #0f172a; text-decoration: none; font-weight: 600; }
    .btn:hover { background: #7dd3fc; }
    footer { text-align: center; padding: 2rem; color: #64748b; font-size: .85rem; }
  </style>
</head>
<body>
  <header>
    <div class="logo">MySite</div>
    <nav>
      <a href="/">Home</a>
      <a href="/about">About</a>
      <a href="/contact">Contact</a>
    </nav>
  </header>
  <main>
    <h1>Welcome to <span>MySite</span></h1>
    <p class="lead">A website powered entirely by C# and ASP.NET Core &mdash; every page, every endpoint, no extra frameworks.</p>
    <a class="btn" href="/about">Learn more</a>
  </main>
  <footer>&copy; 2026 MySite &mdash; built with C#</footer>
</body>
</html>
""", "text/html"));

// ---------- About page ----------
app.MapGet("/about", () => Results.Content("""
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>About | My C# Site</title>
  <style>
    * { margin: 0; padding: 0; box-sizing: border-box; }
    body { font-family: system-ui, -apple-system, sans-serif; background: #0f172a; color: #e2e8f0; min-height: 100vh; }
    header { display: flex; justify-content: space-between; align-items: center; padding: 1rem 2rem; background: #1e293b; }
    .logo { font-weight: 700; color: #38bdf8; font-size: 1.2rem; }
    nav a { color: #e2e8f0; text-decoration: none; margin-left: 1.5rem; }
    nav a:hover { color: #38bdf8; }
    main { max-width: 700px; margin: 4rem auto; padding: 0 1rem; }
    h1 { margin-bottom: 1rem; }
    p { color: #94a3b8; line-height: 1.7; margin-bottom: 1rem; }
    code { background: #1e293b; padding: .15rem .4rem; border-radius: 4px; color: #38bdf8; }
    footer { text-align: center; padding: 2rem; color: #64748b; font-size: .85rem; }
  </style>
</head>
<body>
  <header>
    <div class="logo">MySite</div>
    <nav>
      <a href="/">Home</a>
      <a href="/about">About</a>
      <a href="/contact">Contact</a>
    </nav>
  </header>
  <main>
    <h1>About this site</h1>
    <p>This is a minimal ASP.NET Core website. There is no MVC framework, no Razor, no frontend build step &mdash; just a single C# file using minimal APIs.</p>
    <p>Pages are served from <code>app.MapGet()</code> endpoints in <code>Program.cs</code>, and the contact form posts to a real endpoint that echoes back what you sent.</p>
  </main>
  <footer>&copy; 2026 MySite &mdash; built with C#</footer>
</body>
</html>
""", "text/html"));

// ---------- Contact page ----------
app.MapGet("/contact", () => Results.Content("""
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Contact | My C# Site</title>
  <style>
    * { margin: 0; padding: 0; box-sizing: border-box; }
    body { font-family: system-ui, -apple-system, sans-serif; background: #0f172a; color: #e2e8f0; min-height: 100vh; }
    header { display: flex; justify-content: space-between; align-items: center; padding: 1rem 2rem; background: #1e293b; }
    .logo { font-weight: 700; color: #38bdf8; font-size: 1.2rem; }
    nav a { color: #e2e8f0; text-decoration: none; margin-left: 1.5rem; }
    nav a:hover { color: #38bdf8; }
    main { max-width: 500px; margin: 4rem auto; padding: 0 1rem; }
    h1 { margin-bottom: 1rem; }
    form { display: flex; flex-direction: column; gap: 1rem; }
    label { font-size: .9rem; color: #94a3b8; }
    input, textarea { padding: .6rem; border-radius: 6px; border: 1px solid #334155; background: #1e293b; color: #e2e8f0; font: inherit; }
    input:focus, textarea:focus { outline: 2px solid #38bdf8; border-color: transparent; }
    button { padding: .75rem; border: none; border-radius: 8px; background: #38bdf8; color: #0f172a; font-weight: 600; cursor: pointer; }
    button:hover { background: #7dd3fc; }
    footer { text-align: center; padding: 2rem; color: #64748b; font-size: .85rem; }
  </style>
</head>
<body>
  <header>
    <div class="logo">MySite</div>
    <nav>
      <a href="/">Home</a>
      <a href="/about">About</a>
      <a href="/contact">Contact</a>
    </nav>
  </header>
  <main>
    <h1>Contact us</h1>
    <form method="post" action="/contact">
      <label for="name">Name</label>
      <input id="name" name="name" required>
      <label for="email">Email</label>
      <input id="email" name="email" type="email" required>
      <label for="message">Message</label>
      <textarea id="message" name="message" rows="5" required></textarea>
      <button type="submit">Send</button>
    </form>
  </main>
  <footer>&copy; 2026 MySite &mdash; built with C#</footer>
</body>
</html>
""", "text/html"));

// ---------- Contact form handler + API ----------
app.MapPost("/contact", async (HttpContext ctx) =>
{
    var form = await ctx.Request.ReadFormAsync();
    var name = form["name"].ToString();
    var email = form["email"].ToString();
    return Results.Content($"""
    <!DOCTYPE html>
    <html lang="en"><head><meta charset="utf-8"><title>Thanks | My C# Site</title></head>
    <body style="font-family:system-ui;background:#0f172a;color:#e2e8f0;text-align:center;padding-top:6rem;">
      <h1>Thanks, {System.Net.WebUtility.HtmlEncode(name)}!</h1>
      <p style="color:#94a3b8;">We received your message from {System.Net.WebUtility.HtmlEncode(email)} and will reply soon.</p>
      <a href="/" style="color:#38bdf8;">&larr; Back home</a>
    </body></html>
    """, "text/html");
});

app.MapGet("/api/time", () => Results.Json(new
{
    server = "ASP.NET Core on .NET 10",
    utcNow = DateTime.UtcNow
}));

app.Run();
