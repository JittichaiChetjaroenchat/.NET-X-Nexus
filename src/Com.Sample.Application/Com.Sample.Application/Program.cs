using Com.Sample.Extensions;

namespace Com.Sample.Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var string1 = string.Empty;
            var string1Result = string1.IsEmpty();
            Console.WriteLine($"String is null or empty: {string1Result}");

            var collection1 = new List<string>();
            var collection1Result = collection1.IsEmpty();
            Console.WriteLine($"Collection 1 is null or empty: {collection1Result}");

            var collection2 = Enumerable.Range(0, 0);
            var collection2Result = collection2.IsEmpty();
            Console.WriteLine($"Collection 2 is null or empty: {collection2Result}");
        }
    }
}