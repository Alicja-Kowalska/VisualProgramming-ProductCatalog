namespace ProductCatalog.Library
{
    internal class InternalSupplier
    {
        internal string PartName;

        internal void ShowSupplier()
        {
            Console.WriteLine("Supplier visible only within the library!");
        }
    }
}