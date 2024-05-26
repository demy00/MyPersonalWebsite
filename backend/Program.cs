var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

app.UseHttpsRedirection();
app.UseCors("AllowAllOrigins");

app.MapGet("/api/projects", () =>
{
    var projects = new[]
    {
        new { Id = 1, Name = "Project 1", Description = "Description for project 1" },
        new { Id = 2, Name = "Project 2", Description = "Description for project 2" }
    };
    return Results.Ok(projects);
})
.WithName("GetProjects")
.WithOpenApi();

app.MapGet("/api/blog", () =>
{
    var blogPosts = new[]
    {
        new { Id = 1, Title = "Blog Post 1", Content = "Content for blog post 1" },
        new { Id = 2, Title = "Blog Post 2", Content = "Content for blog post 2" }
    };
    return Results.Ok(blogPosts);
})
.WithName("GetBlogPosts")
.WithOpenApi();

app.Run();