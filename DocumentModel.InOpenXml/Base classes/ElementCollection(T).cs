#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()

namespace DocumentModel;

/// <summary>
/// Represents a collection of model elements.
/// </summary>
/// <typeparam name="ItemType">The type of elements contained in the collection.</typeparam>
public abstract class ElementCollection<ItemType> : ModelElement,
  IElementCollection<ItemType>, IEquatable<ElementCollection<ItemType>>, ICollection
  
{
  private readonly ObservableCollection<ItemType> _items = new();

  /// <summary>
  /// Initializes a new, empty collection.
  /// </summary>
  protected ElementCollection()
  {
    _items.CollectionChanged += _items_CollectionChanged;
  }

  /// <summary>
  /// Creates a new collection with the specified parent element.
  /// The parent element is assigned to the Parent property of this collection, establishing a hierarchical relationship
  /// between the collection and its parent. This constructor allows for the creation of collections that are associated
  /// with a specific parent model element, enabling structured data organization and navigation within the model.
  /// </summary>
  /// <param name="parent"></param>
  protected ElementCollection(ModelElement parent): this()
  {
    SetParent(parent);
  }

  /// <summary>
  /// Handles the CollectionChanged event of the internal ObservableCollection.
  /// When items are added to the collection, this method checks if the new items implement the ICollectionItem interface and,
  /// if so, sets their Collection property to this instance of ElementCollection.
  /// This ensures that each item in the collection has a reference back to the collection it belongs to,
  /// which can be useful for navigation and data management purposes. 
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void _items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
  {
    if (e.Action == NotifyCollectionChangedAction.Add)
    {
      if (e.NewItems != null)
      {
        foreach (var newItem in e.NewItems)
        {
          if (newItem is ICollectionItem collectionItem)
          {
            collectionItem.SetCollection(this);
          }
        }
      }
    }
  }

  /// <summary>
  /// Initializes a new collection with the specified items.
  /// </summary>
  /// <param name="items">The items to add to the collection.</param>
  protected ElementCollection(IEnumerable<ItemType> items)
  {
    foreach (var item in items)
    {
      _items.Add(item);
    }
  }

  /// <summary>
  /// Returns the first item in the collection, or null if the collection is empty.
  /// </summary>
  public ItemType? First => this.Count > 0 ? this[0] : default;

  /// <summary>
  /// Returns the last item in the collection, or null if the collection is empty.
  /// </summary>
  public ItemType? Last => this.Count > 0 ? this[this.Count - 1] : default;

  /// <summary>
  /// Compares this collection to another collection for equality.
  /// </summary>
  /// <param name="other">The other collection to compare to.</param>
  /// <returns>True if the collections are equal; otherwise, false.</returns>
  public bool Equals(ElementCollection<ItemType>? other)
  {
    if (this.Count != other?.Count) return false;
    for (int i = 0; i < this.Count; i++)
    {
      var thisItem = this[i];
      var otherItem = other[i];
      if (!thisItem!.Equals(otherItem)) return false;
    }
    return true;
  }


  /// <summary>
  /// Compares this collection to another object for equality.
  /// </summary>
  /// <param name="obj">The object to compare to.</param>
  /// <returns>True if the objects are equal; otherwise, false.</returns>
  public override bool Equals(object? obj)
  {
    if (obj is null) return false;
    if (ReferenceEquals(this, obj)) return true;
    if (obj.GetType() != GetType()) return false;
    return Equals((ElementCollection<ItemType>)obj);
  }

  /// <summary>
  /// Returns an enumerator that iterates through the collection (non-generic).
  /// </summary>
  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)_items).GetEnumerator();
  }

  /// <summary>
  /// Returns an enumerator that iterates through the collection.
  /// </summary>
  public IEnumerator<ItemType> GetEnumerator()
  {
    return _items.GetEnumerator();
  }

  /// <summary>
  /// Adds an item to the collection.
  /// </summary>
  /// <param name="item">The item to add.</param>
  public void Add(ItemType item)
  {
    _items.Add(item);
  }

  /// <summary>
  /// Removes all items from the collection.
  /// </summary>
  public void Clear()
  {
    _items.Clear();
  }

  /// <summary>
  /// Determines whether the collection contains a specific item.
  /// </summary>
  /// <param name="item">The item to locate.</param>
  /// <returns>True if found; otherwise, false.</returns>
  public bool Contains(ItemType item)
  {
    return _items.Contains(item);
  }

  /// <summary>
  /// Copies the elements of the collection to an array, starting at a particular array index.
  /// </summary>
  /// <param name="array">The destination array.</param>
  /// <param name="arrayIndex">The zero-based index at which copying begins.</param>
  public void CopyTo(ItemType[] array, int arrayIndex)
  {
    _items.CopyTo(array, arrayIndex);
  }

  /// <summary>
  /// Removes the first occurrence of a specific item from the collection.
  /// </summary>
  /// <param name="item">The item to remove.</param>
  /// <returns>True if removed; otherwise, false.</returns>
  public bool Remove(ItemType item)
  {
    return _items.Remove(item);
  }


  /// <summary>
  /// Returns the number of items in the collection.
  /// </summary>
  public int Count => _items.Count;

  /// <summary>
  /// Copies the elements of the collection to a specified one-dimensional array, starting at the given index in the
  /// target array.
  /// </summary>
  /// <param name="array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have
  /// zero-based indexing and sufficient space to accommodate the copied elements.</param>
  /// <param name="index">The zero-based index in the destination array at which copying begins.</param>
  public void CopyTo(Array array, int index)
  {
    ((ICollection)_items).CopyTo(array, index);
  }

  /// <summary>
  /// Gets a value indicating whether access to the collection is synchronized (thread-safe).
  /// </summary>
  /// <remarks>If this property returns <see langword="true"/>, access to the collection is thread-safe and can
  /// be shared among multiple threads without additional synchronization. If <see langword="false"/>, callers must
  /// implement their own synchronization to ensure thread safety when accessing the collection concurrently.</remarks>
  public bool IsSynchronized => ((ICollection)_items).IsSynchronized;

  /// <summary>
  /// Gets an object that can be used to synchronize access to the collection.
  /// </summary>
  /// <remarks>Use the returned object with a lock statement to ensure thread safety when accessing the
  /// collection from multiple threads. Synchronizing access using this object helps prevent race conditions and data
  /// corruption in multithreaded scenarios.</remarks>
  public object SyncRoot => ((ICollection)_items).SyncRoot;

  /// <summary>
  /// Indicates whether the collection is read-only.
  /// </summary>
  public bool IsReadOnly => false;

  /// <summary>
  /// Determines the index of a specific item in the collection.
  /// </summary>
  /// <param name="item">The item to locate.</param>
  /// <returns>The index if found; otherwise, -1.</returns>
  public int IndexOf(ItemType item)
  {
    return _items.IndexOf(item);
  }

  /// <summary>
  /// Inserts an item at the specified index.
  /// </summary>
  /// <param name="index">The zero-based index at which to insert.</param>
  /// <param name="item">The item to insert.</param>
  public void Insert(int index, ItemType item)
  {
    _items.Insert(index, item);
  }

  /// <summary>
  /// Removes the item at the specified index.
  /// </summary>
  /// <param name="index">The zero-based index of the item to remove.</param>
  public void RemoveAt(int index)
  {
    _items.RemoveAt(index);
  }

  /// <summary>
  /// Returns or assigns the item at the specified index.
  /// </summary>
  /// <param name="index">The zero-based index.</param>
  public ItemType this[int index]
  {
    get => _items[index];
    set => _items[index] = value;
  }

  /// <summary>
  /// Occurs when the collection changes, such as when items are added, removed, or the entire list is refreshed.
  /// </summary>
  /// <remarks>Subscribe to this event to receive notifications about changes to the collection. The event
  /// provides details about the type of change and the affected items. This event is typically used to update UI
  /// elements or respond to dynamic data changes in data-binding scenarios.</remarks>
  public event NotifyCollectionChangedEventHandler? CollectionChanged
  {
    add => _items.CollectionChanged += value;
    remove => _items.CollectionChanged -= value;
  }
}
