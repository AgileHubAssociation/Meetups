namespace Composite_Files_End.Classes
{
    public interface IDiskItem
    {
        string Name { get; }
        int SizeInKB { get; }
        void Display(int indent);
    }
}
