using DocumentModel.BaseTypes;

namespace DocumentModel;

/// <summary>
///   Variant implementation. Value is of any type.
/// </summary>
[XmlRoot("Vector")]
[TypeConverter(typeof(VectorTypeXmlConverter))]
[JsonConverter(typeof(VectorJsonConverter))]
public class VectorVariant : Variant, IList<object?>
{

#pragma warning disable CS8600
#pragma warning disable CS8603
  private List<object?> _items => (List<object?>)_Value;
#pragma warning restore

  public VectorVariant()
  {
    _Value = new List<object?>();
    base.VariantType = VariantType.Vector;
  }

  public VectorVariant(VariantType baseType): this()
  {
    BaseType = baseType;
  }

  [XmlIgnore] public new VariantType VariantType => VariantType.Vector;
  [XmlIgnore] public new string TypeName => "Vector";

//  [TypeConverter(typeof(VariantValueConverter))]
//  [XmlConverter(typeof(VectorValueXmlConverter))]
  [XmlIgnore]
  public override object? Value
  {
    get => _Value;
    set => SetValue(value);
  }

  /// <summary>
  ///   Vector Base Type
  /// </summary>
  public VariantType? BaseType { get; set; }

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
    //if (item == null)
    //  _items.Add(DBNull.Value);
    //else
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

  public override bool Equals(Variant? variant)
  {
    if (variant is VectorVariant other)
      return this.Equals(other);
    return base.Equals(variant);
  }

  public virtual bool Equals(VectorVariant? other)
  {
    if (other == null) return false;
    if (this._items == null && other._items == null)
      return true;
    if (this._items == null || other._items == null)
      return false;
    if (this._items.Count != other._items.Count)
      return false;
    for (int i = 0; i<_items.Count; i++)
    {
      var thisItem = this._items[i];
      var otherItem = other._items[i];
      if (thisItem != null)
      {
        if (!thisItem.Equals(otherItem)) return false;
      }
      else
      if (otherItem != null)
      {
        if (!otherItem.Equals(thisItem)) return false;
      }
    }
    return true;
  }

  public override int GetHashCode()
  {
    return base.GetHashCode();
  }

  public override string? ToString(IFormatProvider? provider = null)
  {
    var result = "Vector";
    if (BaseType != null) result += $" of {BaseType}";
    result += " = [" + string.Join(" ", _items.Select(item => item?.ToString() ?? "")) + "]";
    return result;
  }

  public override string? ToString()
  {
    return ToString(null);
  }
}