namespace DocumentModel;

/// <summary>
/// Collection of Values.
/// </summary>
/// <typeparam name="ItemType">The type of items in the collection.</typeparam>
public abstract class ValueCollection<ItemType> : ModelElement,
  IValueCollection<ItemType>, IEquatable<ValueCollection<ItemType>>, ICollection
{
  private readonly ObservableCollection<ItemType> _items = new();

  /// <summary>
  /// Initializes a new, empty collection.
  /// </summary>
  protected ValueCollection()
  {
    _items.CollectionChanged += _items_CollectionChanged;
  }

  /// <summary>
  /// Handles changes to the underlying item collection by updating the collection reference for newly added items.
  /// </summary>
  /// <remarks>This method assigns the current collection as the parent to any items added to the collection
  /// that implement the ICollectionItem interface. Only addition actions are processed; other change types are
  /// ignored.</remarks>
  /// <param name="sender">The source of the collection change event. Typically, the collection being observed.</param>
  /// <param name="e">An object that contains information about the change event, including the action performed and the affected items.</param>
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
  protected ValueCollection(IEnumerable<ItemType> items)
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
  public bool Equals(ValueCollection<ItemType>? other)
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
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
  public override bool Equals(object? obj)
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
  {
    if (obj is null) return false;
    if (ReferenceEquals(this, obj)) return true;
    if (obj.GetType() != GetType()) return false;
    return Equals((ValueCollection<ItemType>)obj);
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
  /// Copies the elements of the collection to a one-dimensional array, starting at the specified index of the target
  /// array.
  /// </summary>
  /// <param name="array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have
  /// zero-based indexing.</param>
  /// <param name="index">The zero-based index in the destination array at which copying begins.</param>
  public void CopyTo(Array array, int index)
  {
    ((ICollection)_items).CopyTo(array, index);
  }

  /// <summary>
  /// Gets a value indicating whether access to the collection is synchronized (thread-safe).
  /// </summary>
  /// <remarks>Use this property to determine if the collection can be safely accessed by multiple threads
  /// concurrently. If the value is <see langword="false"/>, callers should implement their own synchronization when
  /// accessing the collection from multiple threads.</remarks>
  public bool IsSynchronized => ((ICollection)_items).IsSynchronized;

  /// <summary>
  /// Gets an object that can be used to synchronize access to the collection.
  /// </summary>
  /// <remarks>Use the returned object to lock the collection during multithreaded operations to ensure thread
  /// safety. Accessing the collection through the SyncRoot property is recommended when performing synchronized
  /// operations from multiple threads.</remarks>
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

