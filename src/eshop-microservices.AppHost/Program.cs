var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Catalog_API>("catalog-api");

var app = builder.Build();

await app.RunAsync();
