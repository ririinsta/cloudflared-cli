namespace cloudflaredcli
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cloudflared-CLI 0.0.1 \nWrote by ririinsta");
            Console.Write("Enter hostname > ");
            string ipthing = Console.ReadLine();
            Console.Write("Enter local address > ");
            string local = Console.ReadLine();
            Console.WriteLine("C:\\Users\\26lungr\\Downloads\\cloudflared.exe access tcp --hostname " + ipthing + " --url " + local);
        }
        public static void checkfirst()
        {
            //Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile)
        }
    }
}