namespace ProductCatalog.Library
{
    public class PublicDealership
    {
        public string Name; // Pole jawnie publiczne
        string SecretLocation; // Brak modyfikatora

        public void ShowInfo()
        {
            Console.WriteLine("Salon dostępny zewsząd!");
        }
    }
}