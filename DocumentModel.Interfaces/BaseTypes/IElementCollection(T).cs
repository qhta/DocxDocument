namespace DocumentModel;

/// <summary>
/// Represents a collection of elements that are associated with a parent model element.
/// </summary>
/// <typeparam name="ItemType">The type of elements contained in the collection. Must implement <see cref="ICollectionItem"/>.</typeparam>
public interface IElementCollection<ItemType> : ICollection<ItemType>
  where ItemType : ICollectionItem
{
  /// <summary>
  /// Parent element of this model element.
  /// </summary>
  public IModelElement? ParentElement { get; }
}
