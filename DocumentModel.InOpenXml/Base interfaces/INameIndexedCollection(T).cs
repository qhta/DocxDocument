namespace DocumentModel;

/// <summary>
/// Represents a collection of objects that can be accessed by name and provides notification when the collection
/// changes.
/// </summary>
/// <remarks>This class combines name-based indexing with standard collection functionality and change
/// notification. It is suitable for scenarios where objects need to be retrieved or managed by their unique names, and
/// where clients should be notified of changes to the collection. Implementations must ensure that each element's name
/// is unique within the collection.</remarks>
/// <typeparam name="T">The type of elements in the collection. Must implement <see cref="DocumentModel.INamedObject"/> and <see cref="CollectionItem"/>.</typeparam>
public interface INameIndexedElementCollection<T>: IElementCollection<T>
  where T: INamedObject, ICollectionItem
{
}