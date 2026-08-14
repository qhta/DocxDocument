using DocumentModel;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DocumentModel;
/// <summary>
///   Represents a collection of model elements associated with an OpenXml element, which loads separate elements on demand.
/// </summary>
[LazyLoad]
public abstract partial class ContentItemsQuery<ItemType> : ModelElement, ICollection<ItemType>
  where ItemType : ModelElement
{

  private ModelElement _Parent;
  private ContentItemsCollection _baseCollection;

  /// <summary>
  /// Initializes a new instance of the ContentItemsQuery class with the specified parent model element and base collection for this query.
  /// The base collection provides the underlying data source for the query, allowing for filtering and lazy loading of items as needed.
  /// </summary>
  /// <param name="parent">The parent ModelElement that owns this collection. Cannot be null.</param>
  /// <param name="baseCollection">The underlying ContentItemsCollection that provides the base collection for this query. Cannot be null.</param>
  protected ContentItemsQuery(ModelElement parent, ContentItemsCollection baseCollection)
  {
    _Parent = parent;
    _baseCollection = baseCollection;
  }

  /// <summary>
  /// Gets the enumerator for iterating through the collection of items in this query.
  /// </summary>
  /// <returns></returns>
  /// <exception cref="NotImplementedException"></exception>
  public IEnumerator<ItemType> GetEnumerator()
  {
    var enumerator = _baseCollection.GetTypedEnumerator<ItemType>();
    if (enumerator.Current is ItemType item1)
      yield return item1;
    while (enumerator.MoveNext())
    {
      if (enumerator.Current is ItemType item)
        yield return item;
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  /// <summary>
  /// Adds an item to the collection, allowing for dynamic modification of the underlying data source.
  /// </summary>
  /// <param name="item">The item to add to the collection.</param>
  public void Add(ItemType item)
  {
    _baseCollection.Add(item);
  }

  /// <summary>
  /// Clears all items from the collection, removing all elements and resetting the collection to an empty state.
  /// </summary>
  public void Clear()
  {
    _baseCollection.Clear();
  }

  /// <summary>
  /// Determines whether the collection contains a specific item, allowing for efficient membership testing within the underlying data source.
  /// </summary>
  /// <param name="item">The item to locate in the collection.</param>
  /// <returns>True if the item is found; otherwise, false.</returns>
  public bool Contains(ItemType item)
  {
    return _baseCollection.Contains(item);
  }

  /// <summary>
  /// Copies the elements of the collection to an array, starting at a particular index in the target array.
  /// </summary>
  /// <param name="array">The destination array.</param>
  /// <param name="arrayIndex">The zero-based index in the destination array at which copying begins.</param>
  public void CopyTo(ItemType[] array, int arrayIndex)
  {
    var tempArray = _baseCollection.OfType<ItemType>().ToArray();
    Array.Copy(tempArray, 0, array, arrayIndex, tempArray.Length);  
  }

  /// <summary>
  /// Removes the first occurrence of a specific item from the collection, allowing for dynamic modification of the underlying data source.
  /// </summary>
  /// <param name="item">The item to remove from the collection.</param>
  /// <returns>True if the item was successfully removed; otherwise, false.</returns>
  public bool Remove(ItemType item)
  {
    return _baseCollection.Remove(item);
  }

  /// <summary>
  /// Gets the number of elements contained in the collection, providing a count of the items currently present in the underlying data source.
  /// </summary>
  public int Count => _baseCollection.OfType<ItemType>().Count();

  /// <summary>
  /// Gets a value indicating whether the collection is read-only. This property always returns false, indicating that the collection can be modified.
  /// </summary>
  public bool IsReadOnly => false;
}
