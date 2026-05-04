#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()

namespace DocumentModel;
/// <summary>
/// Represents a collection of model elements.
/// </summary>
/// <typeparam name = "ItemType">The type of elements contained in the collection.</typeparam>
[XmlRoot("ElementCollection", Namespace = "DocumentModel")]
public abstract partial class ElementCollection<ItemType> : ModelElement, IElementCollection<ItemType>, 
  IEquatable<ElementCollection<ItemType>>, ICollection<ItemType>, IList, INotificationSource, IEmptyCheckable
  where ItemType : notnull
{
  private readonly BiDiDictionary<object, ItemType> _index = new BiDiDictionary<object, ItemType>();

  /// <summary>
  /// Accessor for the internal ObservableCollection of items for all Collection
  /// </summary>
  protected virtual ObservableCollection<ItemType> Items
  {
    get
    {
      if (_items == null)
      {
        _items = new ObservableCollection<ItemType>();
        _items.CollectionChanged += Items_CollectionChanged;
      }
      return _items;
    }
  }
  private ObservableCollection<ItemType>? _items;

  /// <summary>
  /// Initializes a new, empty collection.
  /// </summary>
  protected ElementCollection() { }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="parent"></param>
  protected ElementCollection(ModelElement parent) : base(parent)
  {
  }

  /// <summary>
  /// Initializes a new collection with the specified items.
  /// </summary>
  /// <param name = "items">The items to add to the collection.</param>
  protected ElementCollection(IEnumerable<ItemType> items)
  {
    _items = new ObservableCollection<ItemType>();
    foreach (var item in items)
    {
      _items.Add(item);
      if (item is ICollectionItem collectionItem)
        collectionItem.SetCollection(this);
      if (item is INamedObject namedObject && _index != null)
        _index.Add(namedObject.Name!, item);
      if (item is INotifyPropertyChanged notificationSource)
        notificationSource.PropertyChanged += ItemPropertyChanged;
    }
    _items.CollectionChanged += Items_CollectionChanged;
  }

  /// <summary>
  /// Copies the elements from the specified source collection into this collection, replacing any existing elements.
  /// </summary>
  /// <param name="source"></param>
  /// <exception cref="ArgumentNullException"></exception>
  public virtual void CopyFrom(IEnumerable<ItemType> source)
  {
    var sourceArray = source as ItemType[] ?? source.ToArray();
    Clear();
    foreach (var item in sourceArray)
    {
      Add(item);
    }
  }

  /// <summary>
  /// Handles the CollectionChanged event of the internal ObservableCollection.
  /// When items are added to the collection, this method checks if the new items implement the ICollectionItem interface and,
  /// if so, sets their Collection property to this instance of ElementCollection.
  /// This ensures that each item in the collection has a reference back to the collection it belongs to,
  /// which can be useful for navigation and data management purposes. 
  /// </summary>
  /// <param name = "sender">The object which have raised this event.</param>
  /// <param name = "args">The argument object of the event.</param>
  private void Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (args.Action == NotifyCollectionChangedAction.Add)
    {
      if (args.NewItems != null)
      {
        foreach (var item in args.NewItems.Cast<ItemType>())
        {
          if (item is ICollectionItem collectionItem)
            collectionItem.SetCollection(this);
          if (item is INamedObject namedObject && _index != null && namedObject.Name != null)
            _index.Add(namedObject.Name, item);
          if (item is INotifyPropertyChanged notificationSource)
            notificationSource.PropertyChanged += ItemPropertyChanged;
        }
      }
    }
    else if (args.Action == NotifyCollectionChangedAction.Remove)
    {
      if (args.OldItems != null)
      {
        foreach (var item in args.OldItems.Cast<ItemType>())
        {
          if (item is ICollectionItem collectionItem)
            collectionItem.SetCollection(null);
          if (item is INamedObject namedObject && _index != null && namedObject.Name != null)
            _index.Remove(namedObject.Name);
          if (item is INotifyPropertyChanged notificationSource)
            notificationSource.PropertyChanged -= ItemPropertyChanged;
        }
      }
    }
    else if (args.Action == NotifyCollectionChangedAction.Reset)
      return;

    if (!IsLoading)
      if (Parent != null)
      {
        var openXmlElement = GetUpdatableElement();
        if (openXmlElement != null)
          UpdateData(openXmlElement);
      }

    CollectionChanged?.Invoke(this, args);
    if (!IsLoading && IsNotificationEnabled)
      SetIsModified(true);
  }

  /// <summary>
  /// Handles notification from child item and raises this PropertyChanged event.
  /// </summary>
  /// <param name = "sender">Child item that sent PropertyChanged event</param>
  /// <param name = "args">Arguments of this event</param>
  private void ItemPropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (sender is ItemType item)
    {
      var propertyName = args.PropertyName;
      if (propertyName == "Name" && sender is INamedObject namedObject)
      {
        if (args is PropertyValueChangedEventArgs valueChangedArgs)
        {
          if (valueChangedArgs.OldValue is string oldName)
            _index.Remove(new KeyValuePair<string, ItemType>(oldName, item));
          if (valueChangedArgs.NewValue is string newName)
            _index.Add(new KeyValuePair<object, ItemType>(newName, item));
        }
        else
        {
          // If PropertyValueChangedEventArgs is not available, we can still update the index based on the new name.
          // However, we may not be able to remove the old name from the index without it. This is a limitation.
          if (_index.TryGetValue1(item, out var oldName))
            _index.Remove(new KeyValuePair<object, ItemType>(oldName, item));
          if (namedObject.Name != null)
            _index.Add(new KeyValuePair<object, ItemType>(namedObject.Name, item));
        }
      }
    }

    if (IsNotificationEnabled && PropertyName != null)
      NotifyPropertyChanged(PropertyName);
  }

  /// <summary>
  /// Indexed access to items by integer index or string name (if ItemType implements INamedObject).
  /// </summary>
  /// <param name = "Index">The index of the item to access. Can be an integer or a string.</param>
  /// <returns>The item at the specified index.</returns>
  /// <exception cref = "KeyNotFoundException">Thrown when the specified string index does not exist in the collection.</exception>
  /// <exception cref = "NotSupportedException">Thrown when the index type is not supported.</exception>
  public virtual ItemType this[object Index]
  {
    get
    {
      if (Index is int intIndex)
        return this[intIndex];

      return _index.TryGetValue2(Index, out var item)
        ? item
        : throw new KeyNotFoundException($"No item with index '{Index}' found in the collection.");
    }
    set
    {
      if (Index is int intIndex)
        this[intIndex] = value;
      else
      {
        if (_index.TryGetValue2((Index), out var item))
          _index[Index] = value;
        else
          throw new KeyNotFoundException($"No item with index '{Index}' found in the collection.");
      }
    }
  }

  /// <summary>
  /// Returns the first item in the collection, or null if the collection is empty.
  /// </summary>
  public virtual ItemType? First => this.Count > 0 ? this[0] : default;

  /// <summary>
  /// Returns the last item in the collection, or null if the collection is empty.
  /// </summary>
  public virtual ItemType? Last => this.Count > 0 ? this[this.Count - 1] : default;

  /// <summary>
  /// Compares this collection to another collection for equality.
  /// </summary>
  /// <param name = "other">The other collection to compare to.</param>
  /// <returns>True if the collections are equal; otherwise, false.</returns>
  public bool Equals(ElementCollection<ItemType>? other)
  {
    if (this.Count != other?.Count)
      return false;
    for (int i = 0; i < this.Count; i++)
    {
      var thisItem = this[i];
      var otherItem = other[i];
      if (!thisItem!.Equals(otherItem))
        return false;
    }

    return true;
  }

  /// <summary>
  /// Compares this collection to another object for equality.
  /// </summary>
  /// <param name = "obj">The object to compare to.</param>
  /// <returns>True if the objects are equal; otherwise, false.</returns>
  public override bool Equals(object? obj)
  {
    if (obj is null)
      return false;
    if (ReferenceEquals(this, obj))
      return true;
    if (obj.GetType() != GetType())
      return false;
    return Equals((ElementCollection<ItemType>)obj);
  }

  /// <summary>
  /// Returns an enumerator that iterates through the collection (non-generic).
  /// </summary>
  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }

  /// <summary>
  /// Returns an enumerator that iterates through the collection.
  /// </summary>
  public IEnumerator<ItemType> GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  /// <summary>
  /// Adds an item to the collection.
  /// </summary>
  /// <param name = "item">The item to add.</param>
  public void Add(ItemType item)
  {
    Items.Add(item);
  }

  /// <summary>
  /// Removes all items from the collection.
  /// </summary>
  public virtual void Clear()
  {
    Items.Clear();
  }

  /// <summary>
  /// Determines whether the collection contains a specific item.
  /// </summary>
  /// <param name = "item">The item to locate.</param>
  /// <returns>True if found; otherwise, false.</returns>
  public virtual bool Contains(ItemType item)
  {
    return Items.Contains(item);
  }

  /// <summary>
  /// Copies the elements of the collection to an array, starting at a particular array index.
  /// </summary>
  /// <param name = "array">The destination array.</param>
  /// <param name = "arrayIndex">The zero-based index at which copying begins.</param>
  public virtual void CopyTo(ItemType[] array, int arrayIndex)
  {
    Items.CopyTo(array, arrayIndex);
  }

  /// <summary>
  /// Removes the first occurrence of a specific item from the collection.
  /// </summary>
  /// <param name = "item">The item to remove.</param>
  /// <returns>True if removed; otherwise, false.</returns>
  public virtual bool Remove(ItemType item)
  {
    return Items.Remove(item);
  }

  /// <summary>
  /// Returns the number of items in the collection.
  /// </summary>
  public virtual int Count => Items.Count;

  /// <summary>
  /// Copies the elements of the collection to a specified one-dimensional array, starting at the given index in the
  /// target array.
  /// </summary>
  /// <param name = "array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have
  /// zero-based indexing and sufficient space to accommodate the copied elements.</param>
  /// <param name = "index">The zero-based index in the destination array at which copying begins.</param>
  public virtual void CopyTo(Array array, int index)
  {
    ((ICollection)Items).CopyTo(array, index);
  }

  /// <summary>
  /// Gets a value indicating whether access to the collection is synchronized (thread-safe).
  /// </summary>
  /// <remarks>If this property returns <see langword="true"/>, access to the collection is thread-safe and can
  /// be shared among multiple threads without additional synchronization. If <see langword="false"/>, callers must
  /// implement their own synchronization to ensure thread safety when accessing the collection concurrently.</remarks>
  public virtual bool IsSynchronized => ((ICollection)Items).IsSynchronized;

  /// <summary>
  /// Gets an object that can be used to synchronize access to the collection.
  /// </summary>
  /// <remarks>Use the returned object with a lock statement to ensure thread safety when accessing the
  /// collection from multiple threads. Synchronizing access using this object helps prevent race conditions and data
  /// corruption in multithreaded scenarios.</remarks>
  public virtual object SyncRoot => ((ICollection)Items).SyncRoot;

  /// <summary>
  /// Indicates whether the collection is read-only.
  /// </summary>
  public virtual bool IsReadOnly => false;

  /// <summary>
  /// Determines the index of a specific item in the collection.
  /// </summary>
  /// <param name = "item">The item to locate.</param>
  /// <returns>The index if found; otherwise, -1.</returns>
  public virtual int IndexOf(ItemType item)
  {
    return Items.IndexOf(item);
  }

  /// <summary>
  /// Inserts an item at the specified index.
  /// </summary>
  /// <param name = "index">The zero-based index at which to insert.</param>
  /// <param name = "item">The item to insert.</param>
  public virtual void Insert(int index, ItemType item)
  {
    Items.Insert(index, item);
  }

  /// <summary>
  /// Removes the item at the specified index.
  /// </summary>
  /// <param name = "index">The zero-based index of the item to remove.</param>
  public virtual void RemoveAt(int index)
  {
    Items.RemoveAt(index);
  }

  /// <summary>
  /// Returns or assigns the item at the specified index.
  /// </summary>
  /// <param name = "index">The zero-based index.</param>
  public virtual ItemType this[int index] { get => Items[index]; set => Items[index] = value; }

  /// <summary>
  /// Occurs when the collection changes, such as when items are added, removed, or the entire list is refreshed.
  /// </summary>
  /// <remarks>Subscribe to this event to receive notifications about changes to the collection. The event
  /// provides details about the type of change and the affected items. This event is typically used to update UI
  /// elements or respond to dynamic data changes in data-binding scenarios.</remarks>
  public event NotifyCollectionChangedEventHandler? CollectionChanged;

  #region implementation of IList
  /// <summary>
  /// Adds an item to the collection and returns the index at which the item was inserted.
  /// </summary>
  /// <remarks>This method modifies the collection by adding the specified item. Ensure that the value parameter
  /// is of the correct type to avoid exceptions.</remarks>
  /// <param name = "value">The item to add to the collection. Must be of type ItemType.</param>
  /// <returns>The zero-based index at which the item was added to the collection.</returns>
  /// <exception cref = "InvalidOperationException">Thrown if the provided value is not of type ItemType.</exception>
  int IList.Add(object? value)
  {
    if (value is ItemType itemType)
    {
      Add(itemType);
      return Count - 1;
    }

    throw new InvalidOperationException($"Item to add must be a {typeof(ItemType)}");
  }

  /// <summary>
  /// Checks if an item is contained in the collection.
  /// </summary>
  /// <param name = "value">The item to check.</param>
  /// <returns>True if an item is contained in the collection, otherwise false.</returns>
  /// <exception cref = "InvalidOperationException">Thrown if the provided value is not of type ItemType.</exception>
  bool IList.Contains(object? value)
  {
    if (value is ItemType itemType)
      return Contains(itemType);
    throw new InvalidOperationException($"Item to add must be a {typeof(ItemType)}");
  }

  /// <summary>
  /// Gets the index of the item is contained in the collection.
  /// </summary>
  /// <param name = "value">The item to search.</param>
  /// <returns>The index of the item is contained in the collection.</returns>
  /// <exception cref = "InvalidOperationException">Thrown if the provided value is not of type ItemType.</exception>
  int IList.IndexOf(object? value)
  {
    if (value is ItemType itemType)
      return IndexOf(itemType);
    throw new InvalidOperationException($"Item to add must be a {typeof(ItemType)}");
  }

  /// <summary>
  /// Inserts an item of type ItemType at the specified index in the collection.
  /// </summary>
  /// <remarks>This method modifies the collection by adding the specified item at the given index. Ensure that
  /// the index is valid before calling this method.</remarks>
  /// <param name = "index">The zero-based index at which the item should be inserted. Must be within the bounds of the collection.</param>
  /// <param name = "value">The object to insert into the collection. Must be of type ItemType; otherwise, an exception is thrown.</param>
  /// <exception cref = "InvalidOperationException">Thrown if the provided value is not of type ItemType.</exception>
  void IList.Insert(int index, object? value)
  {
    if (value is ItemType itemType)
    {
      Insert(index, itemType);
      return;
    }

    throw new InvalidOperationException($"Item to add must be a {typeof(ItemType)}");
  }

  /// <summary>
  /// Removes the specified item from the collection if it is of the correct type.
  /// </summary>
  /// <remarks>This method attempts to cast the provided value to <see langword="ItemType"/> before removal. If
  /// the cast fails, an exception is thrown.</remarks>
  /// <param name = "value">The item to remove from the collection. Must be of type <see langword="ItemType"/>.</param>
  /// <exception cref = "InvalidOperationException">Thrown if the specified item is not of type <see langword="ItemType"/>.</exception>
  void IList.Remove(object? value)
  {
    if (value is ItemType itemType)
    {
      Remove(itemType);
      return;
    }

    throw new InvalidOperationException($"Item to add must be a {typeof(ItemType)}");
  }

  /// <summary>
  /// Indexed access to items.
  /// </summary>
  /// <param name = "index"></param>
  /// <returns></returns>
  object? IList.this[int index] { get => this[index]; set => this[index] = (ItemType)value!; }

  /// <summary>
  /// Gets a value indicating whether the collection has a fixed size.
  /// </summary>
  /// <remarks>A fixed-size collection does not allow adding or removing elements after it is created. This
  /// property is useful for determining the mutability of the collection.</remarks>
  bool IList.IsFixedSize => false;

  #endregion
  /// <summary>
  /// Checks if the collection is empty.
  /// A collection is considered empty if all its properties are null or empty
  /// (as determined by the base implementation of IsEmpty())
  /// and it contains no items or if all items in the collection are themselves empty
  /// (i.e., they implement IEmptyCheckable and return true for IsEmpty()).
  /// </summary>
  /// <returns></returns>
  public override bool IsEmpty()
  {
    return !Items.Any();
  }

  /// <summary>
  /// Checks if the collection should be serialized.
  /// </summary>
  /// <returns></returns>
  public override bool ShouldSerialize()
  {
    return !IsEmpty();
  }

}