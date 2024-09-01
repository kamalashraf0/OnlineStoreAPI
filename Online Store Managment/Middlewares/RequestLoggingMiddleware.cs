namespace Online_Store_Managment.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation($"Request Path: {context.Request.Path}");
            _logger.LogInformation($"Request Headers: {string.Join(", ", context.Request.Headers.Select(h => $"{h.Key}: {h.Value}"))}");
            _logger.LogInformation($"Query Parameters: {string.Join(", ", context.Request.Query.Select(q => $"{q.Key}: {q.Value}"))}");

            await _next(context);
        }
    }
}
