namespace DocumentModel;

/// <summary>
///   Array Variant implementation.
/// </summary>
[XmlRoot("Array")]
public record ArrayVariant : Variant, ICollection<object?>
{
  private VariantType _baseType;

  private int _fillCount;
  private Array? _items;
  private int _lowerBounds;
  private int _upperBounds;

  public ArrayVariant()
  {
    base.VariantType = VariantType.Array;
  }

  public ArrayVariant(VariantType baseType, int size)
  {
    base.VariantType = VariantType.Array;
    Resize(size, baseType);
  }

  public ArrayVariant(VariantType baseType, int lowerBounds, int upperBounds)
  {
    base.VariantType = VariantType.Array;
    Resize(lowerBounds, upperBounds, baseType);
  }

  [XmlIgnore] public new VariantType VariantType => VariantType.Array;

  /// <summary>
  ///   Array Base Type
  /// </summary>
  [XmlAttribute]
  public VariantType BaseType
  {
    get => _baseType;
    set
    {
      if (_baseType != value)
        Resize(_lowerBounds, _upperBounds, value);
    }
  }

  /// <summary>
  ///   Returns an item type that was set by BaseType
  /// </summary>
  public Type ItemType { get; private set; } = typeof(object);

  /// <summary>
  ///   <para>Array Lower Bounds Attribute</para>
  /// </summary>
  [XmlAttribute]
  public int LowerBounds
  {
    get => _lowerBounds;
    set
    {
      if (_lowerBounds != value) Resize(value, _upperBounds, BaseType);
    }
  }

  /// <summary>
  ///   <para>Array Upper Bounds Attribute</para>
  /// </summary>
  [XmlAttribute]
  public int UpperBounds
  {
    get => _upperBounds;
    set
    {
      if (_upperBounds != value) Resize(_lowerBounds, value, BaseType);
    }
  }

  /// <summary>
  ///   Returns current items count.
  /// </summary>
  public int Size => _upperBounds - _lowerBounds + 1;

  public object? this[int index]
  {
    get => _items?.GetValue(index - _lowerBounds);
    set => _items?.SetValue(Convert_ChangeType(value, ItemType), index - _lowerBounds);
  }

  IEnumerator<object?> IEnumerable<object?>.GetEnumerator()
  {
    yield break;
  }

  public IEnumerator GetEnumerator()
  {
    return _items?.GetEnumerator() ?? throw new InvalidOperationException("ArrayVariant not initialized");
  }
  //private ICollection<object?> _collectionImplementation;

  public void Add(object? item)
  {
    this[_fillCount++] = item;
  }

  public void Clear()
  {
    if (_items != null)
      Array.Clear(_items);
  }

  public bool Contains(object? value)
  {
    if (_items != null)
      foreach (var item in _items)
        if (item.Equals(value))
          return true;
    return false;
  }

  public void CopyTo(object?[] array, int arrayIndex)
  {
    if (_items != null)
      _items.CopyTo(array, arrayIndex);
  }

  public bool Remove(object? item)
  {
    return false;
  }

  public int Count
  {
    get
    {
      var count = 0;
      if (_items != null)
        foreach (var item in _items)
          if (item is not null)
            count++;
      return count;
    }
  }

  public bool IsReadOnly => false;

  /// <summary>
  ///   Resizes array with the same item type.
  ///   Set LowerBounds to 0 and UpperBounds to size-1.
  /// </summary>
  /// <param name="size">New upper bounds index</param>
  public void Resize(int size)
  {
    Resize(0, size - 1, BaseType);
  }

  /// <summary>
  ///   Resizes array with new item type.
  ///   Set LowerBounds to 0 and UpperBounds to size-1.
  ///   <param name="baseType">New array item type</param>
  /// </summary>
  /// <param name="size">New upper bounds index</param>
  public void Resize(int size, VariantType baseType)
  {
    Resize(0, size - 1, baseType);
  }

  /// <summary>
  ///   Resizes array with the same item type
  /// </summary>
  /// <param name="lowerBounds">New lower bounds index</param>
  /// <param name="upperBounds">New upper bounds index</param>
  public void Resize(int lowerBounds, int upperBounds)
  {
    Resize(lowerBounds, upperBounds, BaseType);
  }

  /// <summary>
  ///   Resizes array with the new item type
  /// </summary>
  /// <param name="lowerBounds">New lower bounds index</param>
  /// <param name="upperBounds">New upper bounds index</param>
  /// <param name="baseType">New array item type</param>
  public void Resize(int lowerBounds, int upperBounds, VariantType baseType)
  {
    if (lowerBounds != _lowerBounds || upperBounds != _upperBounds || baseType != _baseType)
    {
      var newSize = upperBounds - lowerBounds + 1;
      var newItemType = ItemTypes[baseType];
      var newItems = Array.CreateInstance(newItemType, newSize);
      if (_items != null)
      {
        if (newItemType == ItemType && newSize >= Size)
          _items.CopyTo(newItems, 0);
        else
          for (var i = 0; i < Size && i < newSize; i++)
            newItems.SetValue(Convert_ChangeType(_items.GetValue(i), newItemType), i);
      }
      _items = newItems;
      _lowerBounds = lowerBounds;
      _upperBounds = upperBounds;
      _baseType = baseType;
      ItemType = newItemType;
      _fillCount = 0;
    }
  }
}