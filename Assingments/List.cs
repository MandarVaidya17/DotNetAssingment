

using Assingments;

internal class List : List<Product>
{
    public static implicit operator List<object>(List v)
    {
        throw new NotImplementedException();
    }
}