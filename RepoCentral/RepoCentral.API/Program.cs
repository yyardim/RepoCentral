using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(options =>
                {
                    builder.Configuration.Bind("AzureAd", options);
                    options.TokenValidationParameters.NameClaimType = "name";
                }, options => { builder.Configuration.Bind("AzureAd", options); });

        builder.Services.AddAuthorization(config =>
        {
            config.AddPolicy("AuthZPolicy", policyBuilder =>
                policyBuilder.Requirements.Add(new ScopeAuthorizationRequirement()
                {
                    RequiredScopesConfigurationKey = $"AzureAd:Scopes"
                }));
        });

        builder.Services.AddControllers();

        var app = builder.Build();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}