namespace DocumentModel;

/// <summary>
/// Collection of Values.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IValueCollection<T> : IModelElement, ICollection<T>, INotifyCollectionChanged, IEquatable<IValueCollection<T>>
{

}
