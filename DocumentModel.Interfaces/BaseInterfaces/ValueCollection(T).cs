namespace DocumentModel;

/// <summary>
/// Collection of Values.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ValueCollection<T> : ICollection<T>, INotifyCollectionChanged, IEquatable<ValueCollection<T>>
{

}
