using DocumentModel;
namespace DocumentModel;

/// <summary>
///   Array Variant implementation.
/// </summary>
[XmlRoot("Array")]
[TypeConverter(typeof(ArrayXmlTypeConverter))]
public class ArrayVariant : Variant, ICollection<object?>, IEquatable<ArrayVariant>
{
  private VariantType _baseType;
  private int _fillCount;
  private Array? _items;
  private int _lowerBounds;
  private int _upperBounds;

  /// <summary>
  /// Default constructor
  /// </summary>
  public ArrayVariant()
  {
    base.VariantType = VariantType.Array;
  }

  /// <summary>
  /// Initializes a new instance of the ArrayVariant class with the specified base type and array size.
  /// </summary>
  /// <param name="baseType">The type of elements that the array will contain.</param>
  /// <param name="size">The number of elements in the array. Must be non-negative.</param>
  public ArrayVariant(VariantType baseType, int size)
  {
    base.VariantType = VariantType.Array;
    Resize(size, baseType);
  }

  /// <summary>
  /// Initializes a new instance of the ArrayVariant class with the specified base type and bounds.
  /// </summary>
  /// <param name="baseType">The type of elements contained in the array variant.</param>
  /// <param name="lowerBounds">The inclusive lower bound of the array index.</param>
  /// <param name="upperBounds">The inclusive upper bound of the array index.</param>
  public ArrayVariant(VariantType baseType, int lowerBounds, int upperBounds)
  {
    base.VariantType = VariantType.Array;
    Resize(lowerBounds, upperBounds, baseType);
  }

  /// <summary>
  /// Gets the variant type of the value represented by this instance.
  /// </summary>
  [XmlIgnore] public new VariantType VariantType => VariantType.Array;
  /// <summary>
  ///   Array Base Type
  /// </summary>
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

  /// <summary>
  /// Returns an enumerator that iterates through the collection.
  /// </summary>
  /// <returns>An enumerator that can be used to iterate through the collection.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the collection has not been initialized.</exception>
  public IEnumerator GetEnumerator()
  {
    return _items?.GetEnumerator() ?? throw new InvalidOperationException("ArrayVariant not initialized");
  }
  //private ICollection<object?> _collectionImplementation;
  public void Add(object? item)
  {
    this[_fillCount++] = item;
  }

  /// <summary>
  /// 
  /// </summary>
  public void Clear()
  {
    if (_items != null)
      Array.Clear(_items);
  }

  /// <summary>
  /// Determines whether the collection contains a specific value.
  /// </summary>
  /// <param name="value">The object to locate in the collection. The value can be null.</param>
  /// <returns>true if the value is found in the collection; otherwise, false.</returns>
  public bool Contains(object? value)
  {
    if (_items != null)
      foreach (var item in _items)
        if (item.Equals(value))
          return true;
    return false;
  }

  /// <summary>
  /// Copies the elements of the collection to the specified array, starting at the specified array index.
  /// </summary>
  /// <param name="array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have
  /// zero-based indexing.</param>
  /// <param name="arrayIndex">The zero-based index in the destination array at which copying begins.</param>
  public void CopyTo(object?[] array, int arrayIndex)
  {
    if (_items != null)
      _items.CopyTo(array, arrayIndex);
  }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="item"></param>
  /// <returns></returns>
  public bool Remove(object? item)
  {
    return false;
  }

  /// <summary>
  /// Gets the number of non-null items contained in the collection.
  /// </summary>
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

  /// <summary>
  /// Gets a value indicating whether the collection is read-only. Always false.
  /// </summary>
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

  /// <summary>
  /// Determines whether the current ArrayVariant instance is equal to the specified ArrayVariant.
  /// </summary>
  /// <remarks>Equality is determined by comparing the variant type, lower and upper bounds, and the contents of
  /// the underlying array. Two ArrayVariant instances are considered equal if all these components are equal.</remarks>
  /// <param name="other">The ArrayVariant to compare with the current instance. Can be null.</param>
  /// <returns>true if the specified ArrayVariant is equal to the current instance; otherwise, false.</returns>
  public bool Equals(ArrayVariant? other)
  {
    if (other == null)
      return false;
    var result =
      _VariantType == other._VariantType
      && _lowerBounds == other._lowerBounds 
      && _upperBounds == other._upperBounds
      && _items?.Length == other._items?.Length;
    if (result && _items!=null && other._items!=null)
      for (int i = 0; i < _items.Length; i++)
      {
        var item = _items.GetValue(i);
        var otherItem = other._items.GetValue(i);
        if (item != otherItem)
          return false;
      }
    return true;
  }

  /// <summary>
  /// Serves as the default hash function for the current object.
  /// </summary>
  /// <remarks>The returned hash code is based on the object's variant type, bounds, and items. Objects that are
  /// equal according to the overridden Equals method will return the same hash code. The hash code may vary between
  /// application executions.</remarks>
  /// <returns>A 32-bit signed integer hash code that represents the current object.</returns>
  public override int GetHashCode()
  {
    var result =
      HashCode.Combine(_VariantType.GetHashCode(),
       _lowerBounds.GetHashCode(),
       _upperBounds.GetHashCode(),
       _items?.Length.GetHashCode() ?? 0);
    if (_items!=null)
      for (int i = 0; i < _items.Length; i++)
      {
        var item = _items.GetValue(i);
        result = HashCode.Combine(item?.GetHashCode());
      }
    return result;
  }
}