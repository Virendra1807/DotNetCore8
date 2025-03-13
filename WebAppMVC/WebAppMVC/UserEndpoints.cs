namespace WebAppMVC
{
    public static class UserEndpoints
    {
        public static async Task GetUsers(HttpContext context)
        {
            var users = new List<string> { "Alice", "Bob" };
            await context.Response.WriteAsJsonAsync(users);
        }
    }

}
