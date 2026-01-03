namespace DocumentModel;
/// <summary>
///   Variant stroring a vector of items.
/// </summary>
public interface IVectorVariant : IVariant, IList<object?>, IEquatable<IVectorVariant>
{
}