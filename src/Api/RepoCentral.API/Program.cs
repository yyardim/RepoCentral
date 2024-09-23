using RepoCentral.Application.Queries.Repos;

// Creat the WebApplicationBuilder
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add the authentication services for the application
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(options =>
    {
        builder.Configuration.Bind("AzureAd", options);
        options.TokenValidationParameters.NameClaimType = "name";
    }, options => { builder.Configuration.Bind("AzureAd", options); });

// Add the authorization policy for the application
builder.Services.AddAuthorization(config =>
{
    config.AddPolicy("AuthZPolicy", policyBuilder =>
        policyBuilder.Requirements.Add(new ScopeAuthorizationRequirement()
        {
            RequiredScopesConfigurationKey = $"AzureAd:Scopes"
        }));
});

// Add the Carter services for the application
builder.Services.AddCarter();

// Get the assembly where commands, queries, and handlers live
Assembly applicationAssembly = typeof(GetReposQuery).Assembly;

builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    // Register all MediatR services from the RepoCentral.Application assembly
    config.RegisterServicesFromAssembly(applicationAssembly);

    // Add Open Behaviors like Logging, Validation, etc. from the RepoCentral.Core assembly
    config.AddOpenBehavior(typeof(ValidatorBehavior<,>));
    config.AddOpenBehavior(typeof(LoggingBehavior<,>));
});

// Register all FluentValidation validators from the RepoCentral.Application assembly
builder.Services.AddValidatorsFromAssembly(applicationAssembly);

// Register Redis Cache with the connection string from the appsettings.json
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
    options.InstanceName = "RepoCentral";
});

// Register the custom exception handler for the application
builder.Services.AddExceptionHandler<CustomExceptionHandler>();

// Register Health Checks for the application
builder.Services.AddHealthChecks();

// Add other services & middlewares here
builder.Services.AddControllers();

// Build the WebApplication
WebApplication app = builder.Build();

// Add the authentication middleware to the application
app.UseAuthentication();
app.UseAuthorization();

// Add the exception handler middleware to the application
app.UseExceptionHandler(options => { });

// Add development exception page if the environment is development
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Add the HTTPS redirection middleware to the application
app.UseHttpsRedirection();

// Add the routing middleware to the application
app.UseRouting();

// Map the controllers to the application
app.MapControllers();

// Add the health checks middleware to the application
app.UseHealthChecks("/health");

// Run the application
app.Run();