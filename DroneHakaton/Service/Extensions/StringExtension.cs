namespace DroneHakaton.Service.Extensions
{
    public static class StringExtension
    {
        public static string CutController(this string text)
        {
            return text.Replace("Controller", "");
        }
    }
}
