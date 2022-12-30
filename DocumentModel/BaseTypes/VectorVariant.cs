using DocumentModel.Properties;

namespace DocumentModel;

/// <summary>
/// Variant implementation. Value is of any type.
/// </summary>
[Newtonsoft.Json.JsonConverter(typeof(VectorVariantJsonConverter))]
[QXmlArrayItem("sbyte", typeof(SByte))]
[QXmlArrayItem("int16", typeof(Int16))]
[QXmlArrayItem("int32", typeof(Int32))]
[QXmlArrayItem("int64", typeof(Int64))]
[QXmlArrayItem("byte", typeof(Byte))]
[QXmlArrayItem("uint16", typeof(UInt16))]
[QXmlArrayItem("uint32", typeof(UInt32))]
[QXmlArrayItem("uint64",typeof(UInt64))]
[QXmlArrayItem("single", typeof(Single))]
[QXmlArrayItem("double", typeof(Double))]
[QXmlArrayItem("char", typeof(Char))]
[QXmlArrayItem("string", typeof(String))]
[QXmlArrayItem("dateonly", typeof(DateOnly))]
[QXmlArrayItem("datetime", typeof(DateTime))]
[QXmlArrayItem("boolean", typeof(Boolean))]
[QXmlArrayItem("decimal", typeof(Decimal))]
[QXmlArrayItem("hexword", typeof(HexWord))]
[QXmlArrayItem("null", Value = null)]
[QXmlArrayItem("guid", typeof(Guid))]
[QXmlArrayItem("byte[]", typeof(byte[]))]
[QXmlArrayItem("variant", typeof(Variant))]
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
