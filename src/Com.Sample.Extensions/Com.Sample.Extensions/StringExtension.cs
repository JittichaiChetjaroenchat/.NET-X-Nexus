namespace Com.Sample.Extensions
{
    public static class StringExtension
    {
        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}
