namespace ClassLibraryFor4567
{
    public class Class4567
    {
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789?%!№ ;*()_-=+";
        static Random random = new Random();
        public string GenerateCaptcha(int num)
        {
            return new string(Enumerable.Repeat(chars, num).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}