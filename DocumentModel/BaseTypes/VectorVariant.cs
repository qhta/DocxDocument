using DocumentModel.Properties;

namespace DocumentModel;

/// <summary>
/// Variant implementation. Value is of any type.
/// </summary>
[XmlRoot("Vector")]
public record VectorVariant: Variant, IList<object?>
{
  public VectorVariant()
  {
    VariantType = VariantType.Vector;
  }

  public VectorVariant(VariantType baseType)
  {
    VariantType = VariantType.Vector;
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
    if (item == null)
      _items.Add(DBNull.Value);
    else
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
