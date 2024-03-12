namespace WebAPI.Infrastructure
{
    public static class IEndpointRouteBuilderExtensions
    {
        public static IEndpointRouteBuilder MapGet(this IEndpointRouteBuilder builder, Delegate handler, string pattern = "")
        {
            builder.MapGet(pattern, handler)
                .WithName(handler.Method.Name);

            return builder;
        }
    }
}
