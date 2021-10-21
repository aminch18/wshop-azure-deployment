namespace Microsoft.AspNetCore.Builder;

internal static partial class ApplicationBuilderExtensions
{
    /// <summary>
    /// Register Swagger endpoints.
    /// </summary>
    public static IApplicationBuilder UseSwaggerEndpoints(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        return app;
    }
}
