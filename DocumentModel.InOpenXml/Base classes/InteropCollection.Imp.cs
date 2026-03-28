using DocumentModel;

namespace DocumentModel;
public abstract partial class ModelElementCollection<ItemType> : Interfaces.InteropCollection<ItemType>
{
  /// <summary>
  /// Used to store items that implement INamedObject and allow retrieval by name.
  /// The key is the name of the object, and the value is the object itself.
  /// This dictionary is updated whenever an item with a name is added or when an item's name changes.
  /// </summary>
  /// <remarks>
  /// This dictionary is essential created when items that implement INamedObject are added to the collection.
  /// It allows for efficient retrieval of items by their name, which is a common requirement in many scenarios.
  /// The dictionary is automatically updated to reflect changes in item names,
  /// ensuring that it remains accurate and consistent with the current state of the collection.
  /// If an item does not have a name or if its name is null,
  /// it will not be added to this dictionary, and it will not be retrievable by name.
  /// </remarks>
  private Dictionary<string, ItemType>? _NamedItems;

  /// <summary>
  /// Adds the specified item to the collection and registers it for name-based lookup if it implements the INamedObject
  /// interface.
  /// </summary>
  /// <remarks>If the item implements INamedObject, it is added to an internal dictionary for fast name-based
  /// retrieval. The method also subscribes to the NameChanged event to keep the dictionary in sync if the item's name
  /// changes.</remarks>
  /// <param name="item">The item to add to the collection. If the item implements INamedObject, it will be accessible by its name and
  /// monitored for name changes.</param>
  public new void Add(ItemType item)
  {
    base.Add(item);
    if (item is INamedObject namedObject)
    {
      if (_NamedItems == null)
      {
        _NamedItems = new Dictionary<string, ItemType>();
      }
      if (namedObject.Name is string name)
      {
        _NamedItems[name] = item;
      } 
      namedObject.NameChanged += (sender, args) =>
      {
        if (args.OldName is string oldName)
        {
          _NamedItems.Remove(oldName);
        }
        if (args.NewName is string newName)
        {
          _NamedItems[newName] = item;
        }
      };
    }
  }

  /// <summary>
  /// Provides indexed access to items in the collection using either an integer index or a string key.
  /// If the index is an integer, it retrieves the item at that position in the collection.
  /// If the index is a string, it looks up the item by name using the internal dictionary.
  /// If the index type is invalid, it throws an InvalidOperationException.
  /// </summary>
  /// <param name="index">The index of the item to retrieve. Can be an integer or a string.</param>
  /// <returns>The item at the specified index.</returns>
  /// <exception cref="InvalidOperationException">Thrown when the index type is invalid.</exception>
  public ItemType this[object index]
  {
    get
    {
      if (index is int intIndex)
      {
        return base[intIndex];
      }
      if (index is string stringIndex && _NamedItems != null)
      {
        if (_NamedItems.TryGetValue(stringIndex, out var item)) 
          return item;
        return null!;
      }
      throw new InvalidOperationException($"Invalid index type. Index for {typeof(ItemType)} must be an int or string");
    }
    set
    {
      {
        if (index is int intIndex)
        {
          base[intIndex] = value;
        }
        if (index is string stringIndex && _NamedItems != null)
        {
          _NamedItems[stringIndex] = value;
          return;
        }
        throw new InvalidOperationException($"Invalid index type. Index for {typeof(ItemType)} must be an int or string");
      }
    }
  }

}
