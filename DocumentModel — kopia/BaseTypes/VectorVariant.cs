namespace DocumentModel;

/// <summary>
/// Variant implementation. Value is of any type.
/// </summary>
public record VectorVariant: Variant, IList<object?>
{
  public static Dictionary<VariantType, Type> ItemTypes = new()
  {
    { VariantType.SByte, typeof(SByte) },
    { VariantType.Int16, typeof(Int16) },
    { VariantType.Int32, typeof(Int32) },
    { VariantType.Int64, typeof(Int64) },
    { VariantType.Byte, typeof(Byte) },
    { VariantType.UInt16, typeof(UInt16) },
    { VariantType.UInt32, typeof(UInt32) },
    { VariantType.UInt64, typeof(UInt64) },
    { VariantType.Single, typeof(Single) },
    { VariantType.Double, typeof(Double) },
    { VariantType.Bstr, typeof(String) },
    { VariantType.Lpstr, typeof(String) },
    { VariantType.Lpwstr, typeof(String) },
    { VariantType.Date, typeof(DateTime) },
    { VariantType.DateTime, typeof(DateTime) },
    { VariantType.Bool, typeof(Boolean) },
    { VariantType.Currency, typeof(Decimal) },
    { VariantType.Error, typeof(HexInt) },
    { VariantType.ClassId, typeof(Guid) },
    { VariantType.ClipboardData, typeof(byte[]) },
    { VariantType.Variant, typeof(object) },
  };
  public VectorVariant()
  {
  }

  public VectorVariant(VariantType baseType)
  {
    BaseType = baseType;
  }

  /// <summary>
  /// Vector Base Type
  /// </summary>
  public VariantType? BaseType { get; set; }

  private List<object?> _items = new List<object?>();

  public IEnumerator<object?> GetEnumerator()
  {
    return _items.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)_items).GetEnumerator();
  }

  public void Add(object? item)
  {
    _items.Add(item);
  }

  public void Clear()
  {
    _items.Clear();
  }

  public bool Contains(object? item)
  {
    return _items.Contains(item);
  }

  public void CopyTo(object?[] array, int arrayIndex)
  {
    _items.CopyTo(array, arrayIndex);
  }

  public bool Remove(object? item)
  {
    return _items.Remove(item);
  }

  public int Count => _items.Count;

  public bool IsReadOnly => false;

  public int IndexOf(object? item)
  {
    return _items.IndexOf(item);
  }

  public void Insert(int index, object? item)
  {
    _items.Insert(index, item);
  }

  public void RemoveAt(int index)
  {
    _items.RemoveAt(index);
  }

  public object? this[int index]
  {
    get => _items[index];
    set => _items[index] = value;
  }
}
