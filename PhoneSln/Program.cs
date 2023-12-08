namespace PhoneSln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile MyMobile = new Mobile("Iphone 15 Pro", "Super Retina XDR display", "512 GB", true);

            Console.WriteLine("What is the brand of the mobile? " + MyMobile.GetBrand());
            Console.WriteLine("What is the display of the mobile? " + MyMobile.GetDisplay());
            Console.WriteLine("What is the storage of the mobile? " + MyMobile.GetStorage());
            if (MyMobile.GetHasinsurance()) 
            {
                Console.WriteLine("HasInsurance : Yes");
            }

            else
            {
                Console.WriteLine("HasInsurance : No");
            }
        }
    }
}